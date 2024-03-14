using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Entity
{
    public class Kutuphane
    {
        public List<Kitap> Kitaplar { get; set; }
        public List<Uye> Uyeler { get; set; }
        public void KitapOduncVer(Uye uye, Kitap kitap)
        {
            if (Kitaplar.Contains(kitap) && kitap.Durum == Durum.OduncAlabilir)
            {
                uye.KitapOduncAl(kitap);
                kitap.Durum = Durum.OduncVerildi;
            }
        }

        public void KitapIadeAl(Uye uye, Kitap kitap)
        {
            if (uye.OduncKitaplar.Contains(kitap))
            {
                uye.KitapIadeEt(kitap);
                kitap.Durum = Durum.OduncAlabilir;
            }
        }

        public void DurumGuncelle(Kitap kitap, Durum durum)
        {
            if (Kitaplar.Contains(kitap))
            {
                kitap.Durum = durum;
            }
        }
    }
}
