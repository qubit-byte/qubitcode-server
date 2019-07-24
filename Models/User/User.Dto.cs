namespace Models.User
{
  public class UserAccesses
  {
    public string token { get; set; }
    public string bInfo { get; set; }
  }
  public class User
  {
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string bearer { get; set; }
    public string[] bits { get; set; }
    public UserAccesses[] accesses { get; set; }
    public string[] refreshes { get; set; }
  }
}