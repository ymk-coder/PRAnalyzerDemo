
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
{
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // ❌ Vulnerable to SQL Injection
        var conn = new SqlConnection("Server=.;Database=AppDb;Trusted_Connection=True;");
        var cmd = new SqlCommand($"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'", conn);
        conn.Open();
        var reader = cmd.ExecuteReader();
        return reader.HasRows ? Ok() : Unauthorized();
    }
}
