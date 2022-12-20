using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Product_task
{
    internal class product
    {
        protected string name;
        protected int price;
        protected int count;
        public int Totallncome=0;
        public int alissayi;
        public string Name { get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                { 
                    Console.WriteLine("Meshul adi bos buraxila bilmez"); 
                }
                else
                    name= value;
            } }
        public int Price { get { return price; } 
            set { 
            if(value<1)
                    Console.WriteLine("Mehsulun qiymeti 1AZN den asagi ola bilmez");
            else
                    price = value;
            } }
        public int Count { get { return count; } set {
            if(value<=0)
                    Console.WriteLine("mehsul sayi 0dan asagi ola bilmez");
            else
                    count = value;  
            } }  
        public void Sell()
        {
            if (this.alissayi<=this.count)
            {

                this.count = this.count - this.alissayi;
                this.Totallncome+=this.alissayi*this.price;
                Console.WriteLine("Qiymet:"+this.Totallncome);
                Console.WriteLine("Qalan mehsul sayisi:"+this.count);
            }
            else

                Console.WriteLine("Qeyd elediyiniz qeder mehsul yoxdur");
            


        }
        
    }
}

