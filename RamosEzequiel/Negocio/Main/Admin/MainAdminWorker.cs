using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Business.Main.Admin
{
     public class MainAdminWorker
    {
        public List<Entidades.User> RecoverList()
        {
            return UserDB.RecoverList();
        }
    }
}
