using Models.User;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace QubitDBApi.User
{
  public class UserService
  {
    private readonly IMongoCollection<UserModel> _user;

    public UserService(IQubitMongoDBSettings settings)
    {
      var client = new MongoClient(settings.ConnectionString);
      var database = client.GetDatabase(settings.DatabaseName);

      _user = database.GetCollection<UserModel>(settings.UsersCollectionName);
    }

    public List<UserModel> GetAllUsers()
    {
      return _user.Find(userModel => true).ToList();
    }
  }
}