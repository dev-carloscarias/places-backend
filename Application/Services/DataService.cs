using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.Extensions.Configuration;

namespace Places.Application.Services;

public class DataService : IDataService
{
    private readonly IConfiguration _configuration;

    public DataService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> UploadFile(string blobName, string base64)
    {
        // 0️⃣  Validación de configuración
        var conn = _configuration.GetConnectionString("BlobConnection");
        var containerName = _configuration["AppSettings:ContainerName"]?
                            .Trim().ToLowerInvariant();

        if (string.IsNullOrWhiteSpace(conn) || string.IsNullOrWhiteSpace(containerName))
            throw new InvalidOperationException("Config: conexión o contenedor nulo.");

        // 1️⃣  Cliente de servicio y contenedor
        var serviceClient = new BlobServiceClient(conn);
        var container = serviceClient.GetBlobContainerClient(containerName);

        // 2️⃣  Crea el contenedor solo si no existe
        await container.CreateIfNotExistsAsync();   // si existe, devuelve null

        // 3️⃣  Sube el blob
        var blobClient = container.GetBlobClient(blobName);
        await blobClient.UploadAsync(
            BinaryData.FromBytes(Convert.FromBase64String(base64)),
            overwrite: true);

       
        var contentType = GetContentType(blobName); 
                                                    
        var uploadOptions = new BlobUploadOptions
        {
            HttpHeaders = new BlobHttpHeaders
            {
                ContentType = contentType,
                ContentDisposition = "inline"
            }
        };

        await blobClient.UploadAsync(
            BinaryData.FromBytes(Convert.FromBase64String(base64)),
            uploadOptions);

        return $"{container.Uri}/{blobName}";

    }

    public async Task<string> UploadBlobFile(string path, byte[] content)
    {
        BlobContainerClient blobContainerClient = new BlobContainerClient(_configuration["ConnectionStrings:BlobConnection"], _configuration["AppSettings:ContainerName"]);
        BlobClient blobClient = blobContainerClient.GetBlobClient(path);
        using var ms = new MemoryStream(content);
        await blobClient.UploadAsync(ms, overwrite: true);

        return $"{blobContainerClient.Uri.AbsoluteUri}/{path}";
    }

    private string GetContentType(string fileName)
    {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();

        return extension switch
        {
            ".pdf" => "application/pdf",
            ".jpg" => "image/jpeg",
            ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            _ => "application/octet-stream" // Default si no sabemos
        };
    }
}