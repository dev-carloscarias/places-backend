using Microsoft.AspNetCore.SignalR;
using Places.Application.Interfaces;
using Places.Domain.Entities;

namespace Places.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    private readonly IDataService _dataService;

    private readonly IDataFileService _dataFileService;

    private readonly IEmailService _emailService;
    private readonly INotificationsService _notificationsService;

    private readonly ICurrentUserService _currentUserService;
    private readonly IHubContext<NotificationHub> _notificationHubContext;

    public UserService(IUserRepository userRepository, IDataService dataService, IDataFileService dataFileService,
        IEmailService emailService, ICurrentUserService currentUserService, INotificationsService notificationsService, IHubContext<NotificationHub> notificationHubContext)
    {
        _userRepository = userRepository;
        _dataService = dataService;
        _dataFileService = dataFileService;
        _emailService = emailService;
        _currentUserService = currentUserService;
        _notificationHubContext = notificationHubContext;
        _notificationsService = notificationsService;
    }

    public async Task<bool> Any()
    {
        return await _userRepository.AnyAsync();
    }

    public async Task<bool> Any(Expression<Func<User, bool>> predicate)
    {
        return await _userRepository.AnyAsync(predicate);
    }

    public Task<User> Create(User model)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(int id)
    {
        var original = await _userRepository.GetByIdAsync(id);

        if (original is not null)
        {
            await _userRepository.RemoveAsync(original);
            return;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<User> Edit(User model)
    {
        var id = model.Id;
        var original = await _userRepository.GetByIdAsync(id);

        if (!string.IsNullOrEmpty(model.ProfilePicture))
        {
            try
            {
                model.ProfilePicture = await _dataService.UploadFile($"{model.Id}/{Guid.NewGuid().ToString()}.png", model.ProfilePicture);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        if (original is not null)
        {
            //copy the values from model to original

            original.FirstName = model.FirstName;
            original.LastName = model.LastName;
            original.Email = model.Email;
            original.Telephone = model.Telephone;
            original.DateOfBirth = model.DateOfBirth;
            original.CountryId = model.CountryId;
            original.Address = model.Address;
            original.CorporateEmail = model.CorporateEmail;
            original.AboutMe = model.AboutMe;
            original.Hobbies = model.Hobbies;
            original.ProfilePicture = string.IsNullOrEmpty(model.ProfilePicture) ? original.ProfilePicture : model.ProfilePicture;

            return await _userRepository.UpdateAsync(original);
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await _userRepository.GetAllAsync();
    }

    public async Task<User> GetById(int id)
    {
        var current = await _userRepository.FindUserbyIdAsync(id);

        if (current is not null)
        {
            return current;
        }

        throw new NotFoundException(LanguageConst.IdNotFound);
    }

    public async Task<IEnumerable<User>> GetAdminUsers()
    {
        return await _userRepository.FindAmins();
    }


    public async Task<QueryResult<User>> GetByQueryRequestAsync(QueryRequest queryRequest)
    {
        return await _userRepository.GetByQueryRequestAsync(queryRequest);
    }

    public async Task<IEnumerable<User>> GetAllPendingOwners()
    {
        return await _userRepository.FindAllAsync(x => x.IsActive && x.IsPendingToResolve);
    }

    public async Task<User> OwnerRegistrationById(int userId)
    {
        var user = await GetById(userId);

        return user;
    }

    public async Task OwnerRegistration(OwnerRegistrationDto owner)
    {
        var user = await GetById(owner.UserId);
        if (user is not null)
        {
            user.RegistrationDate = DateTimeOffset.Now;
            user.IsOwnerApproved = false;
            user.IsPendingToResolve = true;
            user.FirstName = owner.FirstName;
            user.LastName = owner.LastName;
            user.Email = owner.Email;
            user.Telephone = owner.Telephone;
            user.Address = owner.Address;

            foreach (var file in owner.DataFiles)
            {
                string filePath = file.Path;
                string extension = file.DataTypeExtension.ToString();

                // Manejo especial para la foto de perfil
                if (file.DataFileType == DataFileType.Profile && file.DataTypeExtension.ToString() != "-1")
                {
                    // Solo subimos una nueva foto si DataTypeExtension no es -1
                    filePath = await _dataService.UploadFile($"{user.Id}/{Guid.NewGuid().ToString()}.{extension}", file.Path);
                }
                else if (file.DataFileType != 0 && !string.IsNullOrEmpty(file.Path))
                {
                    // Para los otros documentos, siempre subimos el archivo si hay un path
                    filePath = await _dataService.UploadFile($"{user.Id}/{Guid.NewGuid().ToString()}.{extension}", file.Path);
                }
  
                // Asignar los filePath y tipos a los campos correspondientes
                switch (file.DataFileType)
                {
                    case DataFileType.Profile: // Foto de Perfil
                        user.PhotoVerification = filePath;
                        break;
                    case  DataFileType.PersonalId: // Documento de Identificación
                        user.DocumentoId = filePath;
                        user.DocumentoIdType = file.DataTypeExtension.ToString();
                        break;
                    case  DataFileType.Businness: // Patente de Comercio
                        user.BusinessPatent = filePath;
                        user.BusinessPatentType = file.DataTypeExtension.ToString();
                        break;
                    case  DataFileType.Legal: // Representación Legal
                        user.LegalRepresentation = filePath;
                        user.LegalRepresentationType = file.DataTypeExtension.ToString();
                        break;
                }

                Console.WriteLine($"Archivo procesado: DataFileType={file.DataFileType}, Path={filePath}, DataTypeExtension={file.DataTypeExtension}");
            }

            await _userRepository.UpdateAsync(user);

            //Notificacion a los admins
            var users = await this.GetAdminUsers();
            foreach (var userAdmin in users)
            {
                var adminMessage = $"Se ha enviado una solicitud de propietario de sitio: {user.FirstName} {user.LastName}";
                var guatemalaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
                var guatemalaTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, guatemalaTimeZone);

                var notificationAdmin = new Notification
                {
                    UserId = userAdmin.Id,
                    profilePhoto = user.ProfilePicture,
                    Message = adminMessage,
                    Timestamp = guatemalaTime
                };
                var connectionAdmin = ConnectionMapping.GetConnectionId(userAdmin.Id);
                if (!string.IsNullOrEmpty(connectionAdmin))
                {
                    await _notificationHubContext.Clients.Client(connectionAdmin)
                        .SendAsync("ReceiveNotification", notificationAdmin);
                }
                try
                {
                    await _notificationsService.CreateNotification(notificationAdmin);
                    await _emailService.SendOwnerRegistrationRequest(user, adminMessage);
                }
                catch(Exception e) { Console.WriteLine(e); }
            }
        }
    }

    public async Task OwnerApprobation(OwnerApprobationDto owner)
    {
        var user = await GetById(owner.UserId);
        if (user is not null)
        {
            user.IsOwnerApproved = owner.IsApproved;
            user.IsOwnerRejected = !owner.IsApproved;
            user.RejectReason = owner.RejectReason;
            user.IsPendingToResolve = false;

            await _userRepository.UpdateAsync(user);
            var message = owner.IsApproved
                        ? "¡Felicidades! Tu solicitud de propietario ha sido aprobada, Bienvenido a la familia de Places."
                        : $"Tu solicitud de propietario ha sido rechazada. Razón: {owner.RejectReason}";
            await _emailService.SendOwnerRegistrationResult(user, message);
            
            DateTime messageSentAt;
            if (!DateTime.TryParse(owner.sentAt, out messageSentAt))
            {
                // Si no se puede parsear, usar DateTime.UtcNow como respaldo
                messageSentAt = DateTime.UtcNow;
            }
            try
            {
                var guatemalaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time");
                var guatemalaTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, guatemalaTimeZone);

                var userApproval = await GetById(owner.UserApprovedId);
                var notification = new Notification
                {
                    UserId = user.Id,
                    profilePhoto = userApproval.ProfilePicture,
                    Message = message,
                    Timestamp = guatemalaTime
                };
                var connectionId = ConnectionMapping.GetConnectionId(user.Id);
                if (!string.IsNullOrEmpty(connectionId))
                {
                    await _notificationHubContext.Clients.Client(connectionId)
                        .SendAsync("ReceiveNotification", notification);
                }

                // Guardar la notificación en la base de datos
                await _notificationsService.CreateNotification(notification);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public async Task<User?> GetCurrentUser()
    {
        return await _currentUserService.GetCurrentUserIdAsync();
    }
}