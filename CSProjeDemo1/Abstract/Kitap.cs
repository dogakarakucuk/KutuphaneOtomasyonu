using CSProjeDemo1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1.Abstract
{
    public abstract class Kitap
    {
        public delegate void KitapDurumDegistiMi(Kitap kitap, Durum eskiDurum, Durum yeniDurum);

        public event KitapDurumDegistiMi KitapDurumDegisti;
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public string YayinEvi { get; set; }
        public string Yayin { get; set; }
        public DateTime YayinYili { get; set; }

        private Durum _durum;
        public Durum Durum
        {
            get { return _durum; }
            set
            {
                if (_durum != value)
                {
                    Durum eskiDurum = _durum;
                    _durum = value;
                    KitapDurumDegisti?.Invoke(this, eskiDurum, _durum);
                }
            }
        }


    }
}
