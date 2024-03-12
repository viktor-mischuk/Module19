using Module19.BLL.Exceptions;
using Module19.BLL.Models;
using Module19.BLL.Services;
using Module19.PLL.Helpers;

namespace Module19.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.WriteLine("Введите почтовый адрес пользователя которого хотите добавить в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }

        }

        public void Show(IEnumerable<User> friends)
        {
            if (friends.Count() == 0)
            {
                AlertMessage.Show("К сожалению у Вас пока нет друзей!");
                return;
            }
            SuccessMessage.Show("Ваши друзья");
            foreach (var friend in friends)
            {
                Console.WriteLine($"{friend.LastName} {friend.FirstName}, {friend.Email}");
            }
        }
    }
}
