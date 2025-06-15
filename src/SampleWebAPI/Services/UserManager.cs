
// ❌ Violates SOLID: tightly coupled class doing too much

public class UserManager
{
    public void CreateUser(string username)
    {
        // Save to DB
    }

    public void SendWelcomeEmail(string username)
    {
        // Sends email
    }

    public void LogCreation(string username)
    {
        // Logs to file
    }
}
