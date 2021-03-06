using MAVN.Service.Campaign.Domain.Models;
using System.Threading.Tasks;

namespace MAVN.Service.Campaign.Domain.Repositories
{
    public interface IFileInfoRepository
    {
        Task<FileModel> GetAsync(string ruleId);

        Task<string> InsertAsync(FileModel model);

        Task UpdateAsync(FileModel model);

        Task DeleteAsync(string ruleId);
    }
}
