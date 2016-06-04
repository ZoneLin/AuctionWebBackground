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
        private  DateTime lastTime;
        private int num;
        public Product() {
            name = content = "";
            price = 0;
            num = 1;
            lastTime = DateTime.Now;
        }
        public Product(string NewName, string NewContent, int NewPrice, int NewNum = 1) {
            num = NewNum;
            name = NewName;
            content = NewContent;
            price = NewPrice;
            lastTime = DateTime.Now;
        }
        public void SetName(string Newname)
        {
            name = Newname;
            lastTime = DateTime.Now;
        }

        public string getName()
        {
            return name;
        }

        public void SetContent(string NewContent)
        {
            content = NewContent;
            lastTime = DateTime.Now;
        }

        public string getContent()
        {
            return content;
        }
        public void SetPrice(int NewPrice)
        {
            price = NewPrice;
            lastTime = DateTime.Now;
        }

        public int getPrice()
        {
            return price;
        }

        public DateTime getLastTime()
        {
            return lastTime;
        }
        public int getNum() {
            return num;
        }
        public void setNum(int NewNum){
            num = NewNum;
        }
    }
}
