using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim
{
    /*
    ana program:Erisim  yard.program:banka uygulama
    iki seviyede Access Modifier olur
    1-internal
       a)Class seviyesi
          internal veya boş olursa kendi kapsama alanında kullanılır.başka katmanda kullanılamaz.
       b)Public class seviyesi:sınırlama yok
    2-member üyesi method ve özellikler
       a)public olursa her yerde kullanılır
       b)private olursa kendi sınıfında erişilir.get set yazmak gerekir
       c)protected olursa kendi sınıfında ve kendisinden türetilen sınıflardan erişilir(miras), başka sınıfta get set yazmak gerekir
       d)Protected Internal 
    
    
    
    /*
     Class seviyesi internal veya public 
     Hiçbir koymazsak default varsaylanı internaldır.
    internal olursa kendi içinde (ddl) erişilir.
    public olursa her yerden erişilir.
    Üye seviyesi =özellik/method hepsine üye


     */
    public class Musteri
    {
        public int Id { get; set; }
        public string Unvan { get; set; }

        private string kKNO;

        public string GetKKNO()
        {
            return kKNO;
       
        }

        public void SetKKNO(string value)
        {
            string ykk = value.ToString();
            kKNO = "******" + ykk.Substring(ykk.Length - 4);
        }

        private string telNo;

        public string GetTelNo()
        {
            return telNo;
        }

        public void SetTelNo(string value)
        {
            telNo ="********" + value.Substring(value.Length - 4);

          
        }

        private string tCNO;

        public string GetTCNO()
        {
            return tCNO;
        }

        public void SetTCNO(string value)
        {
            //Substring:kullanıldığı string tipli değişkende içeriğin belli bir kısmının alınmasını geri kalan kısmın atılmasını sağlar.
            string tc = value;
            //tCNO = value.ToString();
            tCNO="****"+tc.Substring(tc.Length - 5);//5 harfi göster
        }

      
      
    }
}