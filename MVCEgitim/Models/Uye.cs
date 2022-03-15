using System;
using System.ComponentModel; // Validation için
using System.ComponentModel.DataAnnotations; // Validation için bu kütüphaneleri ekliyoruz
using System.Web;

namespace MVCEgitim.Models
{
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Ad Alanını Doldurunuz!")] // aşağıdaki ad alanı için boş geçilemez kuralı koyduk
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        [EmailAddress] // Email formatını zorunlu kılmak için bu attribute kullanılır
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Required, DisplayName("TC Kimlik Numarası")] // ekranda property adı yerine kendi yazımızı yazdırmak için display name kullanıyoruz
        [MinLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakterden az olamaz!")]
        [MaxLength(11, ErrorMessage = "TC Kimlik Numarası 11 karakterden fazla olamaz!")]
        public string TCKimlikNo { get; set; }
        [DisplayName("Doğum Tarihi"), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}"), DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("Kullanıcı Adınız")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Şifreniz")]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage = "{0} {2} karaktarden uzun olmalı.", MinimumLength = 5)]
        public string Sifre { get; set; }
        [DisplayName("Şifrenizi Tekrar Giriniz")]
        [DataType(DataType.Password)]
        [Compare("Sifre")] // yukardaki property adını kontrol etmesi için compare attribute unu ekledik
        public string SifreTekrar { get; set; }
    }
}