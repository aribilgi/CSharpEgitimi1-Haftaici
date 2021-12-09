using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppEFCodeFirst.Entities
{
    [Table("Kategoriler")] //Burası aşağıdaki class ın veritabanındaki hangi tablo ile ilişkilendirileceğini belirler
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public bool Durum { get; set; }
    }
}
