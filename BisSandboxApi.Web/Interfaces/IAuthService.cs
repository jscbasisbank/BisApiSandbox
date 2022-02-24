namespace BisSandboxApi.Web.Interfaces;

public interface IAuthService
{
    ApiResponse LogIn(AuthRequest request);
    ApiResponse LogOut(LogOutRequest request);
}