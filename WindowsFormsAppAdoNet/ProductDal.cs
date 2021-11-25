using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsAppAdoNet
{
    public class ProductDal
    {
        //Veritabanı işlemleri için AdoNet kütüphanesini kullanıyoruz
        //Ado neti kullanmak için yukarıya using kısmına system.data.sqlclient i eklemeliyiz
        SqlConnection _connection = new SqlConnection(@"server=(LocalDB)\MSSQLLocalDB; initial catalog=UrunYonetimiAdoNet; Integrated security=True"); //Sql server a bağlanma nesnemiz
        void ConnectionKontrol()//Veritabanı bağlantısının açık olup olmadığını kontrol eden metot
        {
            if (_connection.State == ConnectionState.Closed) //Yukardaki _connection bağlantı nesnemizin durumu bağlantı durumlarından kapalıya eşitse
            {
                _connection.Open(); // Bağlantıyı aç
            }
        }

        public List<Product> GetAll()
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    StokMiktari = Convert.ToInt32(reader["StokMiktari"]),
                    UrunFiyati = Convert.ToDecimal(reader["UrunFiyati"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();

            return products;
        }

        public DataTable GetAllDataTable()
        {
            ConnectionKontrol();//Bağlantı kontrolü yaptık
            SqlCommand komut = new SqlCommand("select * from products", _connection);//veritabanına sorgumuzu gönderdik
            SqlDataReader reader = komut.ExecuteReader();//veritabanındaki kayıtları okuduk
            DataTable dataTable = new DataTable();//Okuduğumuz kayıtları yükleyeceğimiz data tabloyu oluşturduk
            dataTable.Load(reader);//data tabloya veritabanından çektiğimiz kayıtları yükledik
            reader.Close();//veri okuyucuyu kapattık
            _connection.Close();
            return dataTable;//kayıtların yüklendiği data tabloyu geriye döndürdük
        }

        public void Add(Product product)
        {
            ConnectionKontrol();
            SqlCommand command = new SqlCommand("Insert into Products values (@UrunAdi,@UrunFiyati,@StokMiktari)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", product.UrunFiyati);
            command.Parameters.AddWithValue("@StokMiktari", product.StokMiktari);
            command.ExecuteNonQuery();
            command.Dispose();
            _connection.Close();
        }

    }
}
