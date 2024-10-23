using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace W3_PatikaKutuphanesi
{
    public class Kutuphane //class olusturuyoruz
    {
        public string KitapAdi {  get; set; } //property olusturduk
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime YayinTarihi; //bu da field yani alan olusturduk 

        public Kutuphane() //bu bir parametre almayan constructor
        {
            YayinTarihi = DateTime.Today;
        }

        public Kutuphane(string _kitapAdi, string _yazarAdi, string _yazarSoyadi, int _sayfaSayisi, string _yayinevi) 
            //bu parametre alan bir constructor
        {
            _kitapAdi = KitapAdi;
            _yazarAdi = YazarAdi;
            _yazarSoyadi = YazarSoyadi;
            _sayfaSayisi = SayfaSayisi;
            _yayinevi = Yayinevi;
            YayinTarihi = DateTime.Today;

        }

        public void BilgiYazdir() //bu bir metot 
        {
            Console.WriteLine($"Kitap Adi = {KitapAdi} \r\nYazar = {YazarAdi} {YazarSoyadi} \r\nYayinevi = {Yayinevi} \r\nSayfa Sayisi = {SayfaSayisi}" +
                $"\r\nYayin Tarihi = {YayinTarihi.ToShortDateString()} \r\n------------------------------- \r\n");
        }


    }
}
