using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Rs.Application.Common.Models;
using Rs.Domain.Shared;
using Rs.Infrastructure.Common.Errors;
using Rs.Utility;

namespace Rs.Infrastructure.Services;

public class FileService(IWebHostEnvironment hostEnvironment) : IFileService
{
    public async Task<Result<FileUploadResult>> UploadFileAsync(IFormFile file, string writeTo)
    {
        try
        {
            var fileName = FileUtility.SafeFileName(file);
            var directoryPath = Path.Combine(hostEnvironment.WebRootPath, writeTo);
            var path = Path.Combine(directoryPath, fileName);

            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            
            await using var fs = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(fs);

            return FileUploadResult.Add(fileName,
                Path.GetExtension(file.FileName),
                Path.Combine(writeTo, fileName));
        }
        catch (Exception e)
        {
            return Result.Failure<FileUploadResult>(FileUploadError.CanNotUploadFile);
        }
    }

    public Result<FileStream> GetFile(string filePath)
    {
        var path = Path.Combine(hostEnvironment.WebRootPath, filePath);

        if (!File.Exists(path))
        {
            return Result.Failure<FileStream>(FileUploadError.NotExistFile);
        }
        var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
        return fileStream;
    }

    public Result<bool> DeleteFile(string filePath)
    {
        var path = Path.Combine(hostEnvironment.WebRootPath, filePath);
        
        if (!File.Exists(path))
        {
            return Result.Failure<bool>(FileUploadError.NotExistFile);
        }
        try
        {
            File.Delete(path);

            return true;
        }
        catch (Exception e)
        {
            return Result.Failure<bool>(FileUploadError.CanNotUploadFile);
        }
    }
}