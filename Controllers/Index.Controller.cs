using Microsoft.AspNetCore.Mvc;

namespace qubitcode_server.Controllers
{
  [Route("api/")]
  public class IndexController
  {
    [HttpGet]
    public string Get()
    {
      return "Hello there!";
    }

    [HttpPost]
    public string Post()
    {
      return "Hello there!";
    }
  }
}
