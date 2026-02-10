using Microsoft.AspNetCore.Components.Forms;

namespace MiniShop6.Services.IServices
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(IBrowserFile file, string folderName);
        void DeleteFile(string filePath);
    }
}
