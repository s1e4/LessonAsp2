namespace MinimalApi2.Auth
{
    public interface IUserRepository
    {
        UserDto GetUser(UserDto userModel);
    }
}
