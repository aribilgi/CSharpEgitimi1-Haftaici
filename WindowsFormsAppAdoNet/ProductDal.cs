using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsAppAdoNet
{
    public class ProductDal
    {
        //Veritabanı işlemleri için AdoNet kütüphanesini kullanıyoruz
        //Ado neti kullanmak için yukarıya using kısmına system.data.sqlclient i eklemeliyiz
        SqlConnection _connection = new SqlConnection(); //Sql server a bağlanma nesnemiz

    }
}
