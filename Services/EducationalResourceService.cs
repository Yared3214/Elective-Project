using EducationalResourceAPI.Models;
using EducationalResourceAPI.Repositories;

namespace EducationalResourceAPI.Services
{
    public class EducationalResourceService
    {
        private readonly EducationalResourceRepository _repository;

        public EducationalResourceService(EducationalResourceRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EducationalResource>> GetAllResourcesAsync() =>
            await _repository.GetAllResourcesAsync();

        public async Task<EducationalResource?> GetResourceByIdAsync(string id) =>
            await _repository.GetResourceByIdAsync(id);

        public async Task CreateResourceAsync(EducationalResource resource) =>
            await _repository.CreateResourceAsync(resource);

        public async Task UpdateResourceAsync(string id, EducationalResource resource) =>
            await _repository.UpdateResourceAsync(id, resource);

        public async Task DeleteResourceAsync(string id) =>
            await _repository.DeleteResourceAsync(id);
    }
}
