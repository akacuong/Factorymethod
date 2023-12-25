using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLightFactory.Light1;
namespace ClassLibraryLightFactory.FactoryMethod
{
    public class LedStringFactory : ILightFactory
    {
        public Light CreateLight(int chip, int wattage, int bulbNumbers, double weight)
        {
            var ledstring = new LedString
            {
                Chip = chip,
                Wattage = wattage,
                BulbNumbers = bulbNumbers,
                Weight = weight,
                MaterialProtect= "acrylic plastic",
                Elasticity= "High elasticity and flexibility"
            };
            return ledstring;
        }
    }
}
