using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class User
    {
        public int id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string nombre { get; set; }

        public string apellido { get; set; }

        public string? email { get; set; }

        public int type { get; set; }

        public bool status { get; set; }

        public DateTime lastTime { get; set; }

    public User(int id, string username, string password, string nombre, string apellido, string email, int type, bool status, DateTime lastTime)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.type = type;
            this.status = true;
            this.lastTime = lastTime;
        }
    }
}