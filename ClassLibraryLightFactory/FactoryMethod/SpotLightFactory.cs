using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLightFactory.Light1;
namespace ClassLibraryLightFactory.FactoryMethod
{
    public class SpotLightFactory : ILightFactory
    {
        public Light CreateLight(int chip, int wattage, int bulbNumbers, double weight)
        {
            var spotLight = new SpotLight
            {
                Chip = chip,
                Wattage = wattage,
                BulbNumbers = bulbNumbers,
                Weight = weight,
                Lens = "High-Quality Lens",
                Mirror = "Reflective Mirror",
                Motor = "Quiet Motor",
                LightIntensity = 2005.5
            };
            return spotLight;
        }
    }

}
