using Product_task;
using System.Runtime.CompilerServices;
product Product = new product();
Product.Name="Case";
Product.Count=15;
Product.Price = 20;
Console.WriteLine(Product.Name);
Console.WriteLine("1 Mehsulun qiymeti"+Product.Price+" Azndir");
Console.WriteLine("Bu mehsuldan"+Product.Count+" eded vardir");

do
{

    Console.WriteLine("Mehsuldan nece eded almaq istiyirsiniz");
    
    
        Product.alissayi = Convert.ToInt32(Console.ReadLine());
    if (Product.alissayi > 0)
        Product.Sell();
    else if (Product.alissayi == 0)
    {
        Console.WriteLine("Geldiyiniz ucun tesekkurler");
        Console.WriteLine("Borcunuz"+Product.Totallncome);
        break;
    }
    else
    {
        Console.WriteLine("menfi eded daxil edile bilmez yeniden daxil edin");
        Product.alissayi = Convert.ToInt32(Console.ReadLine());
        Product.Sell();
    }
    
    
        
} while (Product.Count >= Product.alissayi); 
