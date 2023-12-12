using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldObjects2
{
    internal class Designer
    {
        // Variables
        string Brand;
        double Price;
        string Material;
        string HasColor;
        string Collection;


        // Designer method
        public Designer(string brand, double price, string material, string color, string collection)

        {
            this.Brand = brand;
            this.Price = price;
            this.Material = material;
            this.HasColor = color;
            this.Collection = collection;
        }

        public string GetBrand()
        { return this.Brand; }
        public double GetPrice()
        { return this.Price; }
        public string GetMaterial()
        { return this.Material; }
        public string GetColor()
        { return this.HasColor; }
        public string GetCollection()
        { return this.Collection; }

        public void DisplayDetails()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Price: R" + Price);
            Console.WriteLine("Material: " + Material);
            Console.WriteLine("Color: " + HasColor);
            Console.WriteLine("Collection: " + Collection);
        }
    }
}
