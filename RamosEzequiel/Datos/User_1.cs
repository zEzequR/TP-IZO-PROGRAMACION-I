using Entidades;

namespace Datos
{
    public class UserDB
    {
        private static int counter = 0;
        public static List<Entidades.User> users = new List<Entidades.User>();

        static UserDB()
        {
            users.Add(new Entidades.User(counter++,"admin","admin","admin","admin", null, 0, true, DateTime.Now));
            users.Add(new Entidades.User(counter++, "zezee", "1234", "Ezequiel", "Ramos", null, 1, true, DateTime.Now));
            foreach (var User in users)
            {
                System.Diagnostics.Debug.WriteLine("-----foreach de la lista---------");
                System.Diagnostics.Debug.WriteLine(User.id + " ID");
                System.Diagnostics.Debug.WriteLine(User.username + " nombre de usuario");
                System.Diagnostics.Debug.WriteLine(User.password + " contraseña");
                System.Diagnostics.Debug.WriteLine(User.nombre + " nombre");
                System.Diagnostics.Debug.WriteLine(User.apellido + " apellido");
                System.Diagnostics.Debug.WriteLine(User.email + " email");
                System.Diagnostics.Debug.WriteLine(User.type + " tipo");
                System.Diagnostics.Debug.WriteLine(User.status + " estado");
                System.Diagnostics.Debug.WriteLine(User.lastTime + " fecha de registro");
            }
        }

        public static List<Entidades.User> RecoverList()
        {
            foreach (var User in users)
            {
                System.Diagnostics.Debug.WriteLine("-----foreach de la lista en Recover List---------");
                System.Diagnostics.Debug.WriteLine(User.id + " ID");
                System.Diagnostics.Debug.WriteLine(User.username + " nombre de usuario");
                System.Diagnostics.Debug.WriteLine(User.password + " contraseña");
                System.Diagnostics.Debug.WriteLine(User.nombre + " nombre");
                System.Diagnostics.Debug.WriteLine(User.apellido + " apellido");
                System.Diagnostics.Debug.WriteLine(User.email + " email");
                System.Diagnostics.Debug.WriteLine(User.type + " tipo");
                System.Diagnostics.Debug.WriteLine(User.status + " estado");
                System.Diagnostics.Debug.WriteLine(User.lastTime + " fecha de registro");
            }
            return users;
        }

        public static int UserIDHandler()
        {
            return counter++;
        }

        public static User AddUser(int id, string username, string password, string nombre, string apellido, string email, int type, bool status, DateTime fechaRegistro)
        {
            System.Diagnostics.Debug.WriteLine("----ACA EN TEORÍA ENTRO A AGREGAR AL USUARIO EN LA LISTA DE TODOS LOS USUARIOS--");
            User newUser = new User(id, username, password, nombre, apellido, email, type, status, fechaRegistro);
            users.Add(newUser);
            return newUser;
        }

        public static User? GetUsers(int id)
        {
            foreach (var user in users)
            {
                if (user.id == id)
                {
                    return user;
                }
            }
            return null;
        }

        public static bool modifyUser(User? userToModify, string username, string password, string nombre, string apellido, string? email, int type)
        {
            System.Diagnostics.Debug.WriteLine("ENTRO ACA A MODIFICAR EL USUARIO");
            System.Diagnostics.Debug.WriteLine($"Comparando atributos:");
            System.Diagnostics.Debug.WriteLine($"username: {userToModify.username} == {username}");
            System.Diagnostics.Debug.WriteLine($"password: {userToModify.password} == {password}");
            System.Diagnostics.Debug.WriteLine($"nombre: {userToModify.nombre} == {nombre}");
            System.Diagnostics.Debug.WriteLine($"apellido: {userToModify.apellido} == {apellido}");
            System.Diagnostics.Debug.WriteLine($"email: {userToModify.email} == {email}");
            System.Diagnostics.Debug.WriteLine($"type: {userToModify.type} == {type}");
            if (userToModify == null || (userToModify.username == username && userToModify.password == password && userToModify.nombre == nombre && userToModify.apellido == apellido && userToModify?.email == email && userToModify?.type == type))
            {
                return false;
            }
            else
            {
                userToModify.username = username;
                userToModify.password = password;
                userToModify.nombre = nombre;
                userToModify.apellido = apellido;
                userToModify.email = email;
                userToModify.type = type;
                System.Diagnostics.Debug.WriteLine("usuario modificado en la DB");
                System.Diagnostics.Debug.WriteLine(userToModify.id + " ID");
                System.Diagnostics.Debug.WriteLine(userToModify.username + " nombre de usuario");
                System.Diagnostics.Debug.WriteLine(userToModify.password + " contraseña");
                System.Diagnostics.Debug.WriteLine(userToModify.nombre + " nombre");
                System.Diagnostics.Debug.WriteLine(userToModify.apellido + " apellido");
                System.Diagnostics.Debug.WriteLine(userToModify.email + " email");
                System.Diagnostics.Debug.WriteLine(userToModify.type + " tipo");
                System.Diagnostics.Debug.WriteLine(userToModify.status + " estado");
                System.Diagnostics.Debug.WriteLine(userToModify.lastTime + " fecha de registro");
                return true;
            }
        }

        public static bool deleteUser(User userToDelete)
        {
            UserDB.users.Remove(userToDelete);

            return true;
        }
    }
}
