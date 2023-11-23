using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEM_SUPER
{
    public class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail() 
        {
            // aca pongo datos manual, pero se podria obtener de la base de datos
            senderMail = "systemsoporte3@gmail.com";
            password = "ewmorbyeetsuqjjj";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpClient();

        }

    }

}
