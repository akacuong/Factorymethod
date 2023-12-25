using ClassLibraryLightFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryLightFactory.Light1;
namespace ClassLibraryLightFactory.FactoryMethod
{
    public interface ILightFactory
    {
        Light CreateLight(int chip, int wattage, int bulbNumbers, double weight);
    }

}
