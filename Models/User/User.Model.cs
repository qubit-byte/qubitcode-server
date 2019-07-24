using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.User
{
  public class UserModel
  {
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)] public string Id { get; set; }
    [BsonElement("name")] public string name { get; set; }
    [BsonElement("email")] public string email { get; set; }
    [BsonElement("password")] public string password { get; set; }
    [BsonElement("bearer")] public string bearer { get; set; }
    [BsonElement("bits")] public string[] bits { get; set; }
    [BsonElement("accesses")] public UserAccesses[] accesses { get; set; }
    [BsonElement("refreshes")] public string[] refreshes { get; set; }
  }
}
