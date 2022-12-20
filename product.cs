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
        public string name;
        public int price=20;
        public int count=10;
        public int Totallncome=0;
        public int alissayi;
        
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
