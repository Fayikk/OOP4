using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
     class Product //Entity
    {   //prop yazıp snippet edebiliriz.
        public int Id { get; set; }
        //Foreıgn key
        public int CategoryId { get; set; }
        public string  ProductName { get; set; }
        public double UnıtPrice { get; set; }
        public int Category { get; set; }
        public int UnıtsInStock { get; set; }

        //CRUD(create,read,update,delete)operasyonları
    }
}
