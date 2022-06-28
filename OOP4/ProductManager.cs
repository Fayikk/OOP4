using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class ProductManager
    {
        //ürün ile ilgili operasyonalr bulunur.
        //string ad=Product product (der gibi uygulanmalıdır.)
        //bana bir tane product ver anlamına gelmektedir
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        //tipi belli edildiği için değer döndürecektir
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        //kodlarımız değiştirilebilir olmalıdır.Bu yüzden değer döndüren ifadelerin kullanılması daha doğru olur.

        //değer döndürülemez çünkü türü belli edilmemiştir.

        public void Topla2(int sayi1, int sayi2)
        {
             Console.WriteLine(sayi1 + sayi2);
            

         }
    }
}
