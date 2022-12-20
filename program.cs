using Product_task;
using System.Runtime.CompilerServices;
product Product = new product();
Console.WriteLine(Product.name);

Console.WriteLine("1 Mehsulun 1iymeti 20 Azndir");
Console.WriteLine("Bu mehsuldan 10 eded vardir");
 
do
{
   
        Console.WriteLine("Mehsuldan nece eded almaq istiyirsiniz");
        Product.alissayi = Convert.ToInt32(Console.ReadLine());
        Product.Sell();
 
}while(Product.count>=Product.alissayi);
