using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {   //stack            //heap       değerler
            //string[] isimler = new string[] { "fayik", "murat", "kerem", "mustafa" };
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]);
            //console.writeline(isimler[2]);
            //isimler[3] = "ecem";
            //console.writeline(isimler[3]);
            //isimler = new string[5];//new dediğimiz anda aslında belelkte yeni bir 5 elemanlı bomboş bir yer oluşur(boş bir array oluşur)
            ////aşağıdaki yazdırma işlemlerini aslında yazdırır ama boş yazdırır nedeni de,
            ////yukarıda anlattığımız gibi aslında ilk oluşumun(arrayin) bellekteki yerinin
            ////isimler = new string[5]; bu ifade ile değiştirilmesidir.
            ////bundan dolayı yeri değişen arrayin(belleğin farklı bir bölgesine geçen yapının değeri boş döner). 
            //console.writeline(isimler[0]);
            //console.writeline(isimler[1]); console.writeline(isimler[2]);
            ////isimler[4] = "ecem"; out of the range hatası alıyoruz
            //isimler[4] = "fayik";
            //console.writeline(isimler[4]);
            //yukarıdaki ifadelerin bizim için probleme dönüşmmemesi için koleksiyonları kullanırız.

            //string listesi oluşturduk
            //arraylere göre daha dinamik bir yapıya sahiptir.
            //koleksiyonlar,arraylere göre elimizdeki değerlerin kaybedilmemesi için daha toleranslıdır.
            List<String > isimler2 = new List<String> {"Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //listeler ile ilgili birsürü fonksiyon vardır.
            
        }  
    }
}
