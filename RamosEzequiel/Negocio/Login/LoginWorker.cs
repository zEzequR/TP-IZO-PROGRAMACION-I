using Datos;
using Entidades;

namespace Negocio.Login
{
    public class LoginWorker
    {
        public static bool? AuthData(string userInput, string passwrdInput)
        {
            if (string.IsNullOrEmpty(userInput) || string.IsNullOrEmpty(passwrdInput))
            {
                return null;
            }

            foreach (Entidades.User user in UserDB.users)
            {
                if (userInput == user.username && passwrdInput == user.password && (!string.IsNullOrEmpty(userInput) && !string.IsNullOrEmpty(passwrdInput)))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool isUserOrAdmin(string userInput)
        {
            foreach (Entidades.User user in UserDB.users)
            {
                if (userInput == user.username && user.type == 1)
                {
                    return true;
                }
            }
            return false;
        }
    } 
}