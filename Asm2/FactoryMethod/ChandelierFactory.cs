
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLightFactory.Light1;
namespace ClassLibraryLightFactory.FactoryMethod
{
    public class ChandelierFactory : ILightFactory
    {
        public Light CreateLight(int chip, int wattage, int bulbNumbers, double weight)
        {
            var chandelier = new Chandelier
            {
                Chip = chip,
                Wattage = wattage,
                BulbNumbers = bulbNumbers,
                Weight = weight,
                FrameStructure = "flowing waterfallshape",
                Reflector = "aluminum"
            };
            return chandelier;
        }
    }
}
