using EducationalResourceAPI.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace EducationalResourceAPI.Services
{
    public class EducationalResourceService : IEducationalResourceService
    {
        private readonly IMongoCollection<EducationalResource> _resources;

        public EducationalResourceService(IOptions<DatabaseSettings> mongoSettings)
        {
            var client = new MongoClient(mongoSettings.Value.ConnectionString);
            var database = client.GetDatabase(mongoSettings.Value.DatabaseName);
            _resources = database.GetCollection<EducationalResource>("Resources");
        }

        public async Task<List<EducationalResource>> GetAllResourcesAsync(int page, int pageSize)
        {

            return await _resources.Find(resource => true)
                .Skip((page - 1) * pageSize)
                .Limit(pageSize)
                .ToListAsync();
        }
        public async Task<EducationalResource?> GetResourceByIdAsync(string id) =>
            await _resources.Find(resource => resource.Id == id).FirstOrDefaultAsync();

        public async Task CreateResourceAsync(EducationalResource resource) =>
            await _resources.InsertOneAsync(resource);

        public async Task UpdateResourceAsync(string id, EducationalResource resource) =>
            await _resources.ReplaceOneAsync(r => r.Id == id, resource);

        public async Task DeleteResourceAsync(string id) =>
            await _resources.DeleteOneAsync(resource => resource.Id == id);
    }
}
