using Product_task;
using System.Runtime.CompilerServices;

Console.WriteLine("1 Mehsulun 1iymeti 20 Azndir");
Console.WriteLine("Bu mehsuldan 10 eded vardir");
product Product = new product(); 
do
{
   
        Console.WriteLine("Mehsuldan nece eded almaq istiyirsiniz");
        Product.alissayi = Convert.ToInt32(Console.ReadLine());
        Product.Sell();
 
}while(Product.count>=Product.alissayi);
