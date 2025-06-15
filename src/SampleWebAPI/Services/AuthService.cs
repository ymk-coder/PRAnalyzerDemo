
// Changed auth logic that could affect login system
public class AuthService
{
    public bool Login(string user, string password)
    {
        return user == "admin"; // BAD: ignoring password
    }
}
