using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
using ETicaretSitesi.User;
using System.Net.Mail;
using System.Security.Permissions;

namespace ETicaretSitesi
{
    public class DB
    {
        static string connectionString = @"Data Source=DESKTOP-8OMH2KA\SQLEXPRESS;Initial Catalog=Dbo_ETicaret2;Integrated Security=True";

        static SqlConnection connection = new SqlConnection(connectionString);


        public static DataSet getAllBooks(string orderby, string sira)
        {


            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
                "KitapResim, KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, " +
                "Tbl_Kategoriler.KategoriAdi, Tbl_Yayinevleri.YayineviAdi, " +
                "(select COUNT(*) from Tbl_Kitaplar) as ToplamKitapSayisi from Tbl_Kitaplar " +
                "inner join Tbl_Kategoriler on " +
                "Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
                "inner join Tbl_Yazarlar on " +
                "Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
                "inner join Tbl_Yayinevleri on " +
                "Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
                "ORDER BY " + orderby + " " + sira + " ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet getKitapDetay(string kitapid)
        {
            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
                "KitapResim, KitapKategoriid, KitapYazarid, KitapYayineviid, " +
                "KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, Tbl_Kategoriler.KategoriAdi, " +
                "Tbl_Yayinevleri.YayineviAdi from Tbl_Kitaplar " +
                "inner join Tbl_Kategoriler on " +
                "Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
                "inner join Tbl_Yazarlar on " +
                "Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
                "inner join Tbl_Yayinevleri on " +
                "Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
                "where Tbl_Kitaplar.Kitapid = @kitid ORDER BY Tbl_Kitaplar.Kitapid";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kitid", kitapid);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet getFirstLast5Books(string orderby, string sira)
        {
            string sql = "select TOP(5) Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
                "KitapResim, KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, Tbl_Kategoriler.KategoriAdi, " +
                "Tbl_Yayinevleri.YayineviAdi from Tbl_Kitaplar " +
                "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
                "inner join Tbl_Yazarlar on Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
                "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
                "ORDER BY " + orderby + " " + sira + " ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet getYorumlar(string kitapid)
        {
            string sql = "select Tbl_Yorumlar.Yorumid, Yorumicerik, YorumKitapid, " +
                "YorumKullaniciid, YorumTarihi, " +
       "(Tbl_Kullanicilar.KullaniciAdi + ' ' + Tbl_Kullanicilar.KullaniciSoyadi) as adsoyad, " +
                "Tbl_Kitaplar.KitapAdi from Tbl_Yorumlar " +
                "inner join Tbl_Kitaplar on " +
                "Tbl_Yorumlar.YorumKitapid = Tbl_Kitaplar.Kitapid " +
                "inner join Tbl_Kullanicilar on " +
                "Tbl_Yorumlar.YorumKullaniciid = Tbl_Kullanicilar.Kullaniciid " +
                "where Tbl_Kitaplar.Kitapid =" + kitapid;
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet KitapAraisim(string kitapadi)
        {
            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, KitapResim," +
            "KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, Tbl_Kategoriler.KategoriAdi, " +
            "Tbl_Yayinevleri.YayineviAdi, " +
            "(select COUNT(*) from Tbl_Kitaplar) as ToplamKitapSayisi from Tbl_Kitaplar " +
            "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
            "inner join Tbl_Yazarlar on Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
            "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
            "where Tbl_Kitaplar.KitapAdi like '%' + '" + kitapadi + "' + '%' " +
            "ORDER BY Tbl_Kitaplar.KitapOrtalamaPuani desc ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet bulSonuc = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(bulSonuc);
            connection.Close();
            return bulSonuc;
        }
        public static DataSet getAllYazarlar()
        {
            string sql = "select Tbl_Yazarlar.Yazarid, YazarAdiSoyadi " +
                "from Tbl_Yazarlar ORDER BY Tbl_Yazarlar.YazarAdiSoyadi";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open(); adaptor.Fill(result); connection.Close();
            return result;
        }
        public static DataSet getAllKategori()
        {
            string sql = "select Tbl_Kategoriler.Kategoriid, KategoriAdi " +
                "from Tbl_Kategoriler ORDER BY Tbl_Kategoriler.KategoriAdi";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open(); adaptor.Fill(result); connection.Close();
            return result;
        }
        public static DataSet getAllYayinevleri()
        {
            string sql = "select Tbl_Yayinevleri.Yayineviid, YayineviAdi " +
                "from Tbl_Yayinevleri ORDER BY Tbl_Yayinevleri.YayineviAdi";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open(); adaptor.Fill(result); connection.Close();
            return result;
        }
        public static DataSet getBookYazar(string yaz)
        {
            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
        "KitapResim, KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, " +
        "Tbl_Kategoriler.Kategoriid, " +
        "Tbl_Kategoriler.KategoriAdi, Tbl_Yayinevleri.YayineviAdi, " +
        "(select COUNT(*) from Tbl_Kitaplar) as ToplamKitapSayisi from Tbl_Kitaplar " +
        "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
        "inner join Tbl_Yazarlar on Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
        "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
        "where Tbl_Yazarlar.Yazarid =" + yaz + " " +
        "ORDER BY Tbl_Kitaplar.KitapOrtalamaPuani desc ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet bulSonuc = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(bulSonuc);
            connection.Close();
            return bulSonuc;
        }
        public static DataSet getBookKategori(string kat)
        {
            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
        "KitapResim, KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, " +
        "Tbl_Kategoriler.Kategoriid, " +
        "Tbl_Kategoriler.KategoriAdi, Tbl_Yayinevleri.YayineviAdi, " +
        "(select COUNT(*) from Tbl_Kitaplar) as ToplamKitapSayisi from Tbl_Kitaplar " +
        "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
        "inner join Tbl_Yazarlar on Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
        "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
        "where Tbl_Kategoriler.Kategoriid =" + kat + " " +
        "ORDER BY Tbl_Kitaplar.KitapOrtalamaPuani desc ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet bulSonuc = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open();
            adaptor.Fill(bulSonuc);
            connection.Close();
            return bulSonuc;
        }
        public static DataSet getBookYayinevi(string yev)
        {
            string sql = "select Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, " +
        "KitapResim, KitapOrtalamaPuani, Tbl_Yazarlar.YazarAdiSoyadi, " +
        "Tbl_Kategoriler.KategoriAdi, Tbl_Yayinevleri.Yayineviid, " +
        " Tbl_Yayinevleri.YayineviAdi, " +
        "(select COUNT(*) from Tbl_Kitaplar) as ToplamKitapSayisi from Tbl_Kitaplar " +
        "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
        "inner join Tbl_Yazarlar on Tbl_Kitaplar.KitapYazarid = Tbl_Yazarlar.Yazarid " +
        "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
        "where Tbl_Yayinevleri.Yayineviid =" + yev + " " +
        "ORDER BY Tbl_Kitaplar.KitapOrtalamaPuani desc ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet bulSonuc = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(bulSonuc);
            connection.Close();
            return bulSonuc;
        }
        public static int getKitapSayisiYazar(string yazid)
        {
            string sql = "select count(*) from Tbl_Kitaplar inner join Tbl_Yazarlar on Tbl_Yazarlar.Yazarid " +
                      "= Tbl_Kitaplar.KitapYazarid where Tbl_Kitaplar.KitapYazarid = '" + yazid + "'";
            SqlCommand command = new SqlCommand(sql, connection); connection.Open();
            int toplam = 0; SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                toplam = reader.GetInt32(0);
            }
            reader.Close(); connection.Close();
            return toplam;
        }
        public static int getKitapSayisiKategori(string yazid)
        {
            string sql = "select count(*) from Tbl_Kitaplar inner join Tbl_Kategoriler on Tbl_Kategoriler." +
             "Kategoriid = Tbl_Kitaplar.KitapKategoriid where Tbl_Kitaplar.KitapKategoriid = '" + yazid + "'";
            SqlCommand command = new SqlCommand(sql, connection); connection.Open();
            int toplam = 0; SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                toplam = reader.GetInt32(0);
            }
            reader.Close(); connection.Close();
            return toplam;
        }
        public static int getKitapSayisiYayinevi(string yevid)
        {
            string sql = "select count(*) from Tbl_Kitaplar inner join Tbl_Yayinevleri on Tbl_Yayinevleri." +
            "Yayineviid = Tbl_Kitaplar.KitapYayineviid where Tbl_Kitaplar.KitapYayineviid = '" + yevid + "'";
            SqlCommand command = new SqlCommand(sql, connection); connection.Open();
            int toplam = 0; SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                toplam = reader.GetInt32(0);
            }
            reader.Close(); connection.Close();
            return toplam;
        }
        public static string getYazarAdi(string yazid)
        {
            string sql = "select Tbl_Yazarlar.YazarAdiSoyadi from Tbl_Yazarlar " +
                "where Tbl_Yazarlar.Yazarid = @yazid ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@yazid", yazid);
            connection.Close();
            connection.Open();
            string yazaradi = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                yazaradi = reader.GetString(0);
            }
            reader.Close();
            connection.Close();
            return yazaradi;
        }
        public static string getKategoriAdi(string katid)
        {
            string sql = "select Tbl_Kategoriler.KategoriAdi from Tbl_Kategoriler " +
                "where Tbl_Kategoriler.Kategoriid = @katid ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@katid", katid);
            connection.Close();
            connection.Open();
            string kategoriadi = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                kategoriadi = reader.GetString(0);
            }
            reader.Close();
            connection.Close();
            return kategoriadi;
        }
        public static string getYayineviAdi(string yevid)
        {
            string sql = "select Tbl_Yayinevleri.YayineviAdi from Tbl_Yayinevleri " +
                "where Tbl_Yayinevleri.Yayineviid = @yevid ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@yevid", yevid);
            connection.Close();
            connection.Open();
            string yayineviadi = "";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                yayineviadi = reader.GetString(0);
            }
            reader.Close();
            connection.Close();
            return yayineviadi;
        }
        public static void UyeOlKullanici(string kullaniciad, string kullanicisoyad, string kullaniciposta, string kulanicisifre)
        {
            string sql = "insert into Tbl_Kullanicilar (KullaniciAdi, KullaniciSoyadi, " +
                "KullaniciMail, KullaniciSifre) values (@kAdi, @kSoyadi, @kEposta, @kSifre)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kAdi", kullaniciad);
            command.Parameters.AddWithValue("@kSoyadi", kullanicisoyad);
            command.Parameters.AddWithValue("@kEposta", kullaniciposta);
            command.Parameters.AddWithValue("@kSifre", kulanicisifre);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static bool KullaniciGirisKontrol(string kullaniciposta, string kulanicisifre)
        {
            string sql = "select * from Tbl_Kullanicilar " +
                "where KullaniciMail = @kEposta and KullaniciSifre = @kSifre";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kEposta", kullaniciposta);
            command.Parameters.AddWithValue("@kSifre", kulanicisifre);
            DataSet control = new DataSet();
            bool result = false;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adapter.Fill(control);
            connection.Close();
            if (control.Tables[0].Rows.Count > 0)
                result = true;
            return result;
        }
        public static bool kontrolKullaniciMail(string kullaniciposta)
        {
            string sql = "select * from Tbl_Kullanicilar where KullaniciMail=@kEposta";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kEposta", kullaniciposta);
            DataSet resultControl = new DataSet();
            bool result = false;
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(resultControl);
            connection.Close();
            if (resultControl.Tables[0].Rows.Count > 0)
                result = true;
            return result;
        }
        public static void KitapPuaniEkle(int kitapid, string kullaniciid, float KitapPuani)
        {
            string sql;
            if (kullaniciKitapPuaniKontrol(kitapid, kullaniciid) == false)
            {
                sql = "insert into Tbl_KitapPuanlari (PuanKitapid, PuanKullaniciid, " +
                    "PuanKitapPuani) values (@kitid, @kulid, @KitPuan)";
            }
            else
            {
                sql = "update Tbl_KitapPuanlari set PuanKitapPuani = @KitPuan " +
                    "where PuanKitapid = @kitid and PuanKullaniciid = @kulid ";
            }
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kitid", kitapid);
            command.Parameters.AddWithValue("@kulid", kullaniciid);
            command.Parameters.AddWithValue("@KitPuan", KitapPuani);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            DB.KitapOrtPuanGuncelle(kitapid);
        }
        public static void KullaniciSiparisEkle(string kitapid, string kullaniciid, string sipariscode)
        {
            string sql = "insert into Tbl_Siparisler (SiparisCode, SiparisKitapid, " +
                   "SiparisKullaniciid) values (@sipcode, @skitid, @skulid)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@sipcode", sipariscode);
            command.Parameters.AddWithValue("@skitid", kitapid);
            command.Parameters.AddWithValue("@skulid", kullaniciid);
            connection.Open(); command.ExecuteNonQuery(); connection.Close();
        }
        public static bool CodeControl(string code)
        {
            string sql = "select * from Tbl_Siparisler where SiparisCode=@sCode";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@sCode", code);
            DataSet resultControl = new DataSet(); bool result = false;
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open(); adaptor.Fill(resultControl); connection.Close();
            if (resultControl.Tables[0].Rows.Count > 0)
                result = true;
            return result;
        }
        public static string RandomCode()
        {
            Random rndm = new Random(); string code;
            string letters = "ABCDE0FGHIJ1KLMNO2PQRST3UXWVY4Zabcd5efghi6jklmn7opqrs8txwuv9yz";
            do
            {
                code = "";
                for (int i = 0; i < 8; i++)
                {
                    code += letters[rndm.Next(letters.Length)];
                }
            } while (DB.CodeControl(code) == true);
            return code;
        }
        public static int getTumKitapSayisi()
        {
            string sql = "select COUNT(*) as sayi from Tbl_Kitaplar";
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Close();
            connection.Open();
            int toplam = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                toplam = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return toplam;
        }
        public static void yorumEkle(string icerik, string kulid, int kitapid)
        {
            string sql = "insert into Tbl_Yorumlar (Yorumicerik, YorumKullaniciid, " +
                "YorumKitapid) values (@icerik, @kulid, @kitid)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@icerik", icerik);
            command.Parameters.AddWithValue("@kulid", kulid);
            command.Parameters.AddWithValue("@kitid", kitapid);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static bool kullaniciKitapPuaniKontrol(int kitapid, string kullaniciid)
        {
            string sql = "select * from Tbl_KitapPuanlari where PuanKitapid=@kitid and " +
                "PuanKullaniciid = @kulid";
            SqlCommand komut = new SqlCommand(sql, connection);
            komut.Parameters.AddWithValue("@kitid", kitapid);
            komut.Parameters.AddWithValue("@kulid", kullaniciid);
            DataSet sonucKontrol = new DataSet();
            bool sonuc = false;
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            connection.Close();
            connection.Open();
            adaptor.Fill(sonucKontrol);
            connection.Close();
            if (sonucKontrol.Tables[0].Rows.Count > 0)
                sonuc = true;
            return sonuc;
        }
        public static void KitapOrtPuanGuncelle(int kitapiid)
        {
            string sql = "update Tbl_Kitaplar set KitapOrtalamaPuani = " +
                "(select ((SUM (PuanKitapPuani))/ COUNT(*)) as ort " +
                "from Tbl_KitapPuanlari where PuanKitapid = " + kitapiid +
                " Group by PuanKitapid ) where Kitapid = " + kitapiid + " ";

            SqlCommand command = new SqlCommand(sql, connection);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataSet getAllOnerilen()
        {
            string sql = "select Tbl_KitapOner.OKitapid, OKitapAdi, OKitapAciklama, OKitapFiyat, " +
                "OKitapResim, OKitapKategoriAdi, OKitapYazarAdi, OKitapYayineviAdi " +
                "from Tbl_KitapOner order by OKitapid";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static string[] OnerilenOku(string id)
        {
            string[] kitap = { "", "", "", "", "", "", "", "" };
            string sql = "select Tbl_KitapOner.OKitapid, OKitapAdi, OKitapAciklama, OKitapFiyat, " +
                "OKitapResim, OKitapKategoriAdi, OKitapYazarAdi, OKitapYayineviAdi " +
                "from Tbl_KitapOner where OKitapid = " + id + " order by OKitapid";
            SqlCommand komut = new SqlCommand(sql, connection);
            connection.Open();
            SqlDataReader okuyucu = komut.ExecuteReader(CommandBehavior.CloseConnection);
            if (okuyucu.Read())
            {
                kitap[0] = okuyucu["OKitapid"].ToString();
                kitap[1] = okuyucu["OKitapAdi"].ToString();
                kitap[2] = okuyucu["OKitapAciklama"].ToString();
                kitap[3] = okuyucu["OKitapFiyat"].ToString();
                kitap[4] = okuyucu["OKitapResim"].ToString();
                kitap[5] = okuyucu["OKitapKategoriAdi"].ToString();
                kitap[6] = okuyucu["OKitapYazarAdi"].ToString();
                kitap[7] = okuyucu["OKitapYayineviAdi"].ToString();
            }
            connection.Close();
            return kitap;
        }
        public static void onerilenSİl(int kitapid)
        {
            string sql = "delete from tbl_KitapOner where OKitapid = " + kitapid;
            SqlCommand komut = new SqlCommand(sql, connection);
            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();
        }
        public static void yeniKitapekle(string kad, string kac, float kft, string kres, string kkat, string kyaz, string kyev)
        {
            string sql = "insert into Tbl_Kitaplar (KitapAdi, KitapAciklama, KitapFiyat, " +
                "KitapResim, KitapKategoriid, KitapYazarid, KitapYayineviid, " +
                "KitapOrtalamaPuani) values (@k1, @k2, @k3, @k4, @k5, @k6, @k7, 0)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@k1", kad);
            command.Parameters.AddWithValue("@k2", kac);
            command.Parameters.AddWithValue("@k3", kft);
            command.Parameters.AddWithValue("@k4", kres);
            command.Parameters.AddWithValue("@k5", kkat);
            command.Parameters.AddWithValue("@k6", kyaz);
            command.Parameters.AddWithValue("@k7", kyev);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void yeniKitapOner(string kad, string kac, string kft, string kres, string kkat, string kyaz, string kyev)
        {
            string sql = "insert into Tbl_Kitaplar (OKitapAdi, OKitapAciklama, OKitapFiyat, " +
                "OKitapResim, OKitapKategoriAdi, OKitapYazarAdi, OKitapYayineviAdi ) " +
                "values (@k1, @k2, @k3, @k4, @k5, @k6, @k7)";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@k1", kad);
            command.Parameters.AddWithValue("@k2", kac);
            command.Parameters.AddWithValue("@k3", kft);
            command.Parameters.AddWithValue("@k4", kres);
            command.Parameters.AddWithValue("@k5", kkat);
            command.Parameters.AddWithValue("@k6", kyaz);
            command.Parameters.AddWithValue("@k7", kyev);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static int getkid(string kullaniciposta, string kulanicisifre)
        {
            string sql = "select Kullaniciid from Tbl_Kullanicilar where KullaniciMail=@kEposta and KullaniciSifre=@kSifre";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kEposta", kullaniciposta);
            command.Parameters.AddWithValue("@kSifre", kulanicisifre);
            connection.Close();
            connection.Open();
            int id = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return id;
        }
        public static bool AdminGirisKontrol(string Adminposta, string Adminsifre)
        {
            string sql = "select * from Tbl_Admin where AdminMail = @aEposta and AdminSifre = @aSifre";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@aEposta", Adminposta);
            command.Parameters.AddWithValue("@aSifre", Adminsifre);
            DataSet control = new DataSet();
            bool result = false;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adapter.Fill(control);
            connection.Close();
            if (control.Tables[0].Rows.Count > 0)
                result = true;
            return result;
        }
        public static int getAdminid(string adminposta, string adminsifre)
        {
            string sql = "select Adminid from Tbl_Admin where AdminMail=@aEposta and AdminSifre=@aSifre";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@aEposta", adminposta);
            command.Parameters.AddWithValue("@aSifre", adminsifre);
            connection.Close();
            connection.Open();
            int id = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return id;
        }
        public static void yazarekle(string adisoyadi)
        {
            string sql = "insert into Tbl_Yazarlar (YazarAdiSoyadi ) " +
                "values (@yad)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@yad", adisoyadi);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void kategoriekle(string adi)
        {
            string sql = "insert into Tbl_Kategoriler (KategoriAdi ) " +
                "values (@kad)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kad", adi);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static void yayineviekle(string adi)
        {
            string sql = "insert into Tbl_Yayinevleri (YayineviAdi ) " +
                "values (@kad)";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@kad", adi);
            connection.Close();
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static int getyazarid(string adi)
        {
            string sql = "select Yazarid from Tbl_Yazarlar " +
                "where YazarAdiSoyadi =@adi ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@adi", adi);
            connection.Close();
            connection.Open();
            int id = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return id;
        }
        public static int getkategoriid(string adi)
        {
            string sql = "select Kategoriid from Tbl_Kategoriler " +
                "where KategoriAdi =@adi ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@adi", adi);
            connection.Close();
            connection.Open();
            int id = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return id;
        }
        public static int getyayineviid(string adi)
        {
            string sql = "select Yayineviid from Tbl_Yayinevleri " +
                "where YayineviAdi =@adi ";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@adi", adi);
            connection.Close();
            connection.Open();
            int id = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }
            reader.Close();
            connection.Close();
            return id;
        }
        public static DataSet getKullaniciSiparis(string kid)
        {
            string sql = "select * from Tbl_Siparisler where SiparisKullaniciid = @skid";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@skid", kid);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet getBooks3()
        {
            string sql = "select TOP(5) * from Tbl_Kitaplar";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static DataSet get5Books()
        {
            string sql = "select TOP(5) Tbl_Kitaplar.Kitapid, KitapAdi, KitapAciklama, KitapFiyat, KitapResim," +
                "Tbl_Yazarlar.YazarAdiSoyadi, Tbl_Kategoriler.KategoriAdi, Tbl_Yayinevleri.YayineviAdi " +
                "from Tbl_Kitaplar " +
                "inner join Tbl_Kategoriler on Tbl_Kitaplar.KitapKategoriid = Tbl_Kategoriler.Kategoriid " +
                "inner join Tbl_Yazarlar on Tbl_KitapYazar.Yazarid = Tbl_Yazarlar.Yazarid " +
                "inner join Tbl_Yayinevleri on Tbl_Yayinevleri.Yayineviid = Tbl_Kitaplar.KitapYayineviid " +
                "ORDER BY Tbl_Kitaplar.Kitapid  ";

            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Close();
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
        public static bool AnyUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))
                    return true;
            }
            return false;
        }
        public static bool AnyNumber(string str)
        {
            foreach (char chr in str)
            {
                if (Char.IsNumber(chr))
                    return true;
            }
            return false;
        }
        public static bool TextBoxKontrolBosmu(string icerik)
        {
            bool sonuc = false;
            string kontrol = "";
            for (int i = 0; i < icerik.Length + 5; i++)
            {
                if (icerik == kontrol)
                    sonuc = true;
                kontrol = kontrol + " ";
            }
            return sonuc;
        }
    }
}