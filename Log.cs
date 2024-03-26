using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Crud
{
    public class Log
    {
        public int Log_ID { get; set; }
        public int Log_Id_User { get; set; }
        public string Log_Login { get; set; }
        public DateTime Log_DateTimeConnexion { get; set; }
        public DateTime Log_DateTimeDeconnexion { get; set; }
        
    }
}
