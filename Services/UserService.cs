using netcore_school.Applications.User;

namespace netcore_school.Services
{
    public class UserService
    {
        private readonly UserApplication _userApplication;

        public UserService(UserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        public async Task<(bool exito, string message, object data)> FindUserAsync()
        {
            var (status, data) = await _userApplication.FindUsersAsync();

            if (!status)
                return (false, "No se pudo obtener la información de monedas.", null);

            return (true, "Lista de monedas/billetes", data);
        }   
    }
}
