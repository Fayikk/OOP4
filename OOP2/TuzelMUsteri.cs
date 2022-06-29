using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{   //coorporate
    //Inheritance(miras alma)
    //Musteri class'ı ebeveyndir
    internal class TuzelMUsteri:Musteri
    {
         public string SirketAdi { get; set; }
        //bir veri üzerinde matematiksel işlem yapılmıyorsa,bunların string olarak ayarlanması daha doğru olacaktır.

        public string VergiNo { get; set; }
    
    }
}
