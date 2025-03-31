using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;

namespace Places.Application.Services;

public class DataService : IDataService
{
    private readonly IConfiguration _configuration;

    public DataService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> UploadFile(string container, string content)
    {
        BlobContainerClient blobContainerClient = new BlobContainerClient(_configuration["ConnectionStrings:BlobConnection"], _configuration["AppSettings:ContainerName"]);
        BlobClient blobClient = blobContainerClient.GetBlobClient(container);
        _ = await blobClient.UploadAsync(BinaryData.FromBytes(Convert.FromBase64String(content)), overwrite: true);

        return $"{blobContainerClient.Uri.AbsoluteUri.ToString()}/{container}";
    }

    public async Task<string> UploadBlobFile(string path, byte[] content)
    {
        BlobContainerClient blobContainerClient = new BlobContainerClient(_configuration["ConnectionStrings:BlobConnection"], _configuration["AppSettings:ContainerName"]);
        BlobClient blobClient = blobContainerClient.GetBlobClient(path);
        using var ms = new MemoryStream(content);
        await blobClient.UploadAsync(ms, overwrite: true);

        return $"{blobContainerClient.Uri.AbsoluteUri}/{path}";
    }
}