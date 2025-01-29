using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationalResourceAPI.Models
{
    public class EducationalResource
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Title")]
        public string Title { get; set; } = string.Empty;

        [BsonElement("Description")]
        public string Description { get; set; } = string.Empty;

        [BsonElement("Category")]
        public string Category { get; set; } = string.Empty;

        [BsonElement("Author")]
        public string Author { get; set; } = string.Empty;

        [BsonElement("PublishedDate")]
        public DateTime PublishedDate { get; set; } = DateTime.UtcNow;
    }
}
