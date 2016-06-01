using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamC
{
    class Product
    {
        private  string name;
        private  string content;
        private  int  price;
        public Product() {
            name = content = "";
            price = 0;
        }
        public void SetName(string Newname)
        {
            name = Newname;
        }

        public string getName()
        {
            return name;
        }

        public void SetContent(string NewContent)
        {
            content = NewContent;
        }

        public string getContent()
        {
            return content;
        }
        public void SetPrice(int NewPrice)
        {
            price = NewPrice;
        }

        public int getPrice()
        {
            return price;
        }
    }
}
