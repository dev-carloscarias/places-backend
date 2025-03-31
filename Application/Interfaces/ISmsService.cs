namespace Places.Application.Interfaces;

public interface ISmsService
{
    string SendVerificationMessage(User  user);
}