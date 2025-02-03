using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthWindow.InterFace;

namespace AuthWindow.InterFace
{
    internal interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }

    }
}
public class Product : IProduct
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - {Price:C}"; 
    }
}

