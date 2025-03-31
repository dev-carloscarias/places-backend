namespace Places.Application.Interfaces;

public interface IDataService
{
    Task<string> UploadFile(string container, string content);
    Task<string> UploadBlobFile(string path, byte[] content);
}