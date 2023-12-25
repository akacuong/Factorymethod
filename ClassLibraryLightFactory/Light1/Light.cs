using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLightFactory.Light1
{
    public abstract class Light
    {
        public int Chip { get; set; }
        public int Wattage { get; set; }
        public int BulbNumbers { get; set; }
        public double Weight { get; set; }
        public abstract bool IsTurnOn(bool click);
        public abstract string DisplayInformation();
    }
}
