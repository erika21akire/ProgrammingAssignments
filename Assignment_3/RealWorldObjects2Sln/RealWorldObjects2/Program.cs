using System.ComponentModel.Design;

namespace RealWorldObjects2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of DesignerBag
            Designer Versace = new Designer("Versace", 76800, "Leather", "Black", "La Medusa");
            
            Designer SteveMadden = new Designer("Steve Madden", 1899, "Leather", "Black & Clear", "Bonang Exclusive");

            Designer Aldo = new Designer("Aldo ", 1499, "Synthetic", "White & Gold", "HAOACAN");

            // Call the DisplayDetails method to print the bag details
            Versace.DisplayDetails();
        }
    }
}
