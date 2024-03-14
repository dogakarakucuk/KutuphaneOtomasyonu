using CSProjeDemo1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Contract
{
    public interface IUye
    {
        public int UyeNumarasi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<Kitap> OduncKitaplar { get; set; }
        public void KitapOduncAl(Kitap kitap);
        public void KitapIadeEt(Kitap kitap);

    }
}
