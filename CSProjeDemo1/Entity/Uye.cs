using CSProjeDemo1.Abstract;
using CSProjeDemo1.Contract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entity
{
    public class Uye : IUye
    {
        public int UyeNumarasi { get ; set ; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }

        public void KitapIadeEt(Kitap kitap)
        {
            if (OduncKitaplar.Contains(kitap))
            {
                OduncKitaplar.Remove(kitap);
                kitap.Durum = Durum.OduncAlabilir;
            }
        }

        public void KitapOduncAl(Kitap kitap)
        {
            if (kitap.Durum == Durum.OduncAlabilir)
            {
                OduncKitaplar.Add(kitap);
                kitap.Durum = Durum.OduncVerildi;
            }
        }
    }
}
