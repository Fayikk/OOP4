using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //isimlendirme kurallarına uymamız gerekmektedir
            //Burası bizim mainimizdir.
            //1 numaralı ürünümüzü oluşturalım
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnıtPrice = 500;
            product1.UnıtsInStock = 3;
            //2 numaralı ürünümüzü oluşturalım
            //değişken tanımlamaları aşağıdaki gibi tanımlanabilir.
            Product product2 = new Product {Id=2,CategoryId=5,UnıtsInStock=5,
                ProductName="Kalem",UnıtPrice=35 };
            //instance creation(örnek oluşturma)
            //PascalCase    CamelCase
            //case sensitive (küçük-büyük bharf duyarlılığı)
            ProductManager productManager = new ProductManager();
            //product türünden product1'i vermiş olduk.
           
            //int,double,bool... değer tipleridir.
            //ancak diziler,class,abstract class,interface..referans tipleridir
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//"kamera" string ifadesini döndürür

            productManager.Topla2(3, 6);
            //aşağıdaki değeri return değerimize atamış olduk fonksiyondaki
            int toplamasonucu = productManager.Topla(5, 6);
            Console.WriteLine(toplamasonucu);
            Console.WriteLine(toplamasonucu*4);


        }
    }
}
