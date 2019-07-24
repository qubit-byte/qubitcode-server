namespace QubitDBApi
{
  public class QubitMongoDBSettings : IQubitMongoDBSettings
  {
    public string UsersCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface IQubitMongoDBSettings
  {
    string UsersCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}