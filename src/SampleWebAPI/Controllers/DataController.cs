
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class DataController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData()
    {
        // ❌ Synchronous blocking
        var data = LoadData();
        return Ok(data);
    }

    private List<string> LoadData()
    {
        var result = new List<string>();
        for (int i = 0; i < 1000; i++)
        {
            result.Add("Item " + i); // Simulate N+1 DB queries
        }
        return result;
    }
}
