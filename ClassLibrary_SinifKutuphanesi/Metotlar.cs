using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_SinifKutuphanesi
{
    public class Metotlar
    {
        public static bool MailGonder(string mail)
        {
            if (!string.IsNullOrEmpty(mail))
            {
                //Buraya mail gönderme kodları gelecek
                return true;
            }
            else return false;
        }
    }
}
