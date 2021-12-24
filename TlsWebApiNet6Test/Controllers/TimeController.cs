using Microsoft.AspNetCore.Mvc;

namespace TlsWebApiNet6Test.Controllers
{
  [ApiController]
  [Route("api/time")]
  public class TimeController : ControllerBase
  {
    [HttpGet]
    [Route("")]
    public async Task<DateTime> GetCurrentTime()
    {
      return DateTime.Now;
    }
  }
}