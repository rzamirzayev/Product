using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_task
{
    internal class Milk:product
    { 
       
        
            private int volume;
            private int fatrate;

            public int Volume { get { return volume; } set { volume = value; } }
            public int Fatrate { get { return fatrate; } set { fatrate = value; } }
        

    }
}
