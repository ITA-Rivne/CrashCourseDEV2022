using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model
{
    public class Phone
    {
        public string Title { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
        public Phone(string title, string company, int price)
        {
            Title = title;
            Company = company;
            Price = price;

        }
    }

}
