using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{    //generics 
    //çalışacağımzı özel bir tip tanımlaması yapıyoruz
    //ben mylist'imde t ile çalışacağım
     class MyList<T>
    {
        T[] items;
        //constructer
        //MyList classı new lenirse constructer otomatik olarak çalışır.
        //arraylerin oluşturulabilmesi için new'lenmesi gerekiyor.
        //Dolayısıyla bu yüzden constructor kullanarak arraylerin newleme işlemini gerçekleştirdik.

        public MyList()
        {
            
            items = new T[0];
        }
        public void Add(T item)
        {   //aşağıda items array'imi aslında daha dinamik bir hale getiriyorum.
            //temprArray geçici referans tutucu array oluşturmak için kullandık.

            T[] tempArray = items;
            items = new T[items.Length+1];
           //temparray'e emaneten verdiğimiz değerleri bellekteki yerimizi
           //1 arttırdıktan sonra temparray'den,verdiğimiz değerleri geri alıyoruz.
           
            for(int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];    
            }
           //bellekte yer açtığımız 1 bölümlük hazneye girilen item'ın atamasını yaptık.

            items[items.Length-1] = item;
        }

    }
}
