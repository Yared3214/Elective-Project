using EducationalResourceAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationalResourceAPI.Services
{
    public interface IEducationalResourceService
    {
        Task<List<EducationalResource>> GetAllResourcesAsync();
        Task<EducationalResource?> GetResourceByIdAsync(string id);
        Task CreateResourceAsync(EducationalResource resource);
        Task UpdateResourceAsync(string id, EducationalResource resource);
        Task DeleteResourceAsync(string id);
    }
}