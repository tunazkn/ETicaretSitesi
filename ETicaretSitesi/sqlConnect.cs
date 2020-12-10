using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;

namespace ETicaretSitesi
{
    public class sqlConnect
    {

        static string connectionString = @"Data Source=DESKTOP-8OMH2KA\SQLEXPRESS;Initial Catalog=Dbo_ETicaret2;Integrated Security=True";

        static SqlConnection connection = new SqlConnection(connectionString);


        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-8OMH2KA\SQLEXPRESS;Initial Catalog=Dbo_ETicaret2;Integrated Security=True");
            baglan.Open();

            return baglan;
        }
        /*
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-8OMH2KA\SQLEXPRESS;Initial Catalog=Dbo_ETicaret2;Integrated Security=True");
            baglan.Open();

            return baglan;
        }*/
        /*


        public static DataSet getBooks()
        {
            string sql = "select * from Tbl_Kitaplar";
            SqlCommand command = new SqlCommand(sql, connection);
            DataSet result = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(command);
            connection.Open();
            adaptor.Fill(result);
            connection.Close();
            return result;
        }
            /* aşağıdaki fonksiyonlar örnek fonksiyonlar onlardan yardım alınnacak

            public static DataSet getProducts()
            {
                string sql = "SELECT Product.pID, mainName, " +
                   "bName, FtDescription, cpName, " +
                   "sName, quName , Product.pName FROM Product " +
                   "INNER JOIN MainGroup ON Product.MainID = MainGroup.MainID " +
                   "INNER JOIN Brand ON Product.bID = Brand.bID " +
                   "INNER JOIN Feature ON Product.FtID = Feature.ftID " +
                   "INNER JOIN ComProduct ON Product.cpID = ComProduct.cpID " +
                   "INNER JOIN Series ON Product.sID = Series.sID " +
                   "INNER JOIN Quality ON Product.quID = Quality.quID";

                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open();
                adaptor.Fill(result);
                connection.Close();
                return result;
            }
            /*"select * from Product";*

            /*"selet select Product.pID , Product.MainID , mainName as mn, Product.bID , " +
            "bName as bn, Product.FtID , FtDescription as fd , Product.cpID , cpName as cn , Product.sID , " +
            "sName as sn , Product.quID , quName as qn , Product.pName FROM Product " +
            "INNER JOIN MainGroup ON MainGroup.MainID = Product.mainID " +
            "INNER JOIN Brand ON Brand.bID = Product.bID " +
            "INNER JOIN Feature ON Feature.FtID = Product.ftID " +
            "INNER JOIN ComProduct ON ComProduct.cpID = Product.cpID " +
            "INNER JOIN Series ON  Series.sID =  Product.sID" +
            "INNER JOIN Quality ON Quality.quID = Product.quID";*

            /*"select Product.pID as PID, Product.pName as mgd, cpName as sgd, " +
            "bName as bd, FtDescription as  etd, mainName as sd, " +
            "sName as qd, quName as jd FROM Product " +
            "INNER JOIN MainGroup ON MainGroup.MainID = Product.mainID " +
            "INNER JOIN Brand ON Brand.bID = Product.bID " +
            "INNER JOIN Feature ON Feature.FtID = Product.ftID " +
            "INNER JOIN ComProduct ON ComProduct.cpID = Product.cpID " +
            "INNER JOIN Series ON  Series.sID =  Product.sID" +
            "INNER JOIN Quality ON Quality.quID = Product.quID;";*
            public static DataSet getComProduct()
            {
                string sql = "select Product.pID as PID, Product.pName , ComProduct.cpName as cn, " +
                    "Brand.bName as bn, Feature.FtDescription as fn, MainGroup.mainName as mn, " +
                    "Quality.quName as qn, Series.sName as sn , FROM Product " +
                    "INNER JOIN ComProduct ON Product.cpID = ComProduct.cpID " +
                    "INNER JOIN Brand ON Product.bID = Brand.bID " +
                    "INNER JOIN Feature ON Product.FtID = Feature.ftID " +
                    "INNER JOIN MainGroup ON Product.MainID = MainGroup.mainID " +
                    "INNER JOIN Quality ON Product.quID = Quality.quID " +
                    "INNER JOIN Series ON Product.sID = Series.sID;";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open();
                adaptor.Fill(result);
                connection.Close();
                return result;
            }
            public static DataSet getMaterials()
            {
                string sql = "select * from Materials order by MatName";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open();
                adaptor.Fill(result);
                connection.Close();
                return result;
            }
            public static DataSet getMainGroups()
            {
                string sql = "select * from MainGroup order by mainName";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open(); adaptor.Fill(result); connection.Close();
                return result;
            }
            public static DataSet getSubGroups()
            {
                string sql = "select * from SubGroup order by subName";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open(); adaptor.Fill(result); connection.Close();
                return result;
            }
            public static DataSet getBrands()
            {
                string sql = "select * from Brand order by bName";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open(); adaptor.Fill(result); connection.Close();
                return result;
            }
            public static DataSet getQuality()
            {
                string sql = "select * from Quality order by quName";
                SqlCommand command = new SqlCommand(sql, connection);
                DataSet result = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(command);
                connection.Open(); adaptor.Fill(result); connection.Close();
                return result;
            }

            protected void LinkbtnShowProduct_Click(object sender, EventArgs e)
            {
                string urunKodu = (sender as LinkButton).CommandArgument;
                try
                {/*
                    txtMalzemeDuzenleUrunKod.Text = DBIslemleri.ReadProduct(urunKodu)[0];
                    txtMalzemeDuzenleUrunAd.Text = DBIslemleri.ReadProduct(urunKodu)[1];
                    txtMalzemeDuzenleUrunStok.Text = DBIslemleri.ReadProduct(urunKodu)[2];*
                }
                catch { }
            }
            public static string[] ReadProduct(string ProductCode)
            {
                string[] Products = { "", "", "", "", "", "", "", "", "" };
                string sql = "select pID, MainID, bID, FtID, cpID, sID, quID, ReID, Pname from " +
                    "Product where pID = '" + ProductCode + "'";
                SqlCommand komut = new SqlCommand(sql, connection);
                DataSet sonucKontrol = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(komut);
                connection.Open();
                SqlDataReader Reader = komut.ExecuteReader(CommandBehavior.CloseConnection);
                if (Reader.Read())
                {
                    Products[0] = Reader["pID"].ToString();
                    Products[1] = Reader["MainID"].ToString();
                    Products[2] = Reader["bID"].ToString();
                    Products[3] = Reader["FtID"].ToString();
                    Products[4] = Reader["cpID"].ToString();
                    Products[5] = Reader["sID"].ToString();
                    Products[6] = Reader["quID"].ToString();
                    Products[7] = Reader["ReID"].ToString();
                    Products[8] = Reader["Pname"].ToString();
                }
                connection.Close();
                return Products;
            }
            /*public static string[] AlinanOku(string alinanNo)
            {
                string[] alinanlar = { "", "", "", "", "", "", "", "", "", "" };
                string sql = "select alinanlar.alinan_no, alinanlar.urun_kodu, urun_adi, kullanici_adi + ' ' + kullanici_soyadi " +
                    "as kullaniciAdSoyad, personeller.personel_no, personel_adi + ' ' + personel_soyadi as personelAdSoyad, " +
                    "personel_tel, alinanlar.alinan_adet, CONVERT(varchar,alinanlar.alis_tarihi,104) as alis_tarihi, " +
                    "CONVERT(varchar,alinanlar.teslim_tarihi,23) as teslim_tarihi, teslim_durum " +
                    "from alinanlar inner join urunler on urunler.urun_kodu = alinanlar.urun_kodu " +
                    "inner join kullanicilar on kullanicilar.kullanici_ID = alinanlar.kullanici_ID " +
                    "inner join personeller on personeller.personel_no = alinanlar.personel_no " +
                    "where alinanlar.alinan_no = " + alinanNo;
                SqlCommand komut = new SqlCommand(sql, baglanti);
                DataSet sonucKontrol = new DataSet();
                SqlDataAdapter adaptor = new SqlDataAdapter(komut);
                baglanti.Open();
                SqlDataReader okuyucu = komut.ExecuteReader(CommandBehavior.CloseConnection);
                if (okuyucu.Read())
                {
                    alinanlar[0] = okuyucu["alinan_no"].ToString();
                    alinanlar[1] = okuyucu["urun_kodu"].ToString();
                    alinanlar[2] = okuyucu["urun_adi"].ToString();
                    alinanlar[3] = okuyucu["alinan_adet"].ToString();
                    alinanlar[4] = okuyucu["kullaniciAdSoyad"].ToString();
                    alinanlar[5] = okuyucu["personelAdSoyad"].ToString();
                    alinanlar[6] = okuyucu["personel_tel"].ToString();
                    alinanlar[7] = okuyucu["alis_tarihi"].ToString();
                    alinanlar[8] = okuyucu["teslim_tarihi"].ToString();
                    alinanlar[9] = okuyucu["teslim_durum"].ToString();
                }
                baglanti.Close();
                return alinanlar;
            }*/
        }
}