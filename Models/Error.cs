namespace qubitcode_server.Models
{
  public class Error
  {
    public int id { get; private set; }
    public string message { get; private set; }
    public bool error;

    public Error(int Id)
    {
      id = Id;
      switch (id)
      {
        case 1:
          message = "Missing content in request body";
          break;
        case 2:
          message = "Invalid user email";
          break;
        case 3:
          message = "Password has to be at least 6 characters";
          break;
        default:
          message = "Error";
          break;
      }

      error = true;
    }
  }
}
