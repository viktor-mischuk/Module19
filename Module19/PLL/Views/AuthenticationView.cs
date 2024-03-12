using Module19.BLL.Exceptions;
using Module19.BLL.Models;
using Module19.BLL.Services;
using Module19.PLL.Helpers;

namespace Module19.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.Write("Введите почтовый адрес: ");
            authenticationData.Email = Console.ReadLine();

            Console.Write("Введите пароль: ");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("Вы успешно вошли в социальную сеть!");
                SuccessMessage.Show($"Добро пожаловать {user.FirstName}");

                Program.userMenuView.Show(user);
            }
            catch (WrongPasswordException) 
            {
                AlertMessage.Show("Пароль не корректный");
            }
            catch(UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден");
            }
        }
    }
}
