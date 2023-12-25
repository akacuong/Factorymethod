using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibraryLightFactory.Light1
{
    public class Chandelier : Light
    {
        public string FrameStructure { get; set; }
        public string Reflector { get; set; }
        public override string DisplayInformation()
        {
            string information =
                        $"Chip: {Chip} MCOB\n" +
                        $"Wattage: {Wattage}w\n" +
                        $"Bulb Numbers: {BulbNumbers} bulb\n" +
                        $"Weight: {Weight} kg\n" +
                        $"Frame Structure: {FrameStructure}\n" +
                        $"Reflector: {Reflector}\n";
            return information;
        }
        public override bool IsTurnOn(bool click)
        {
            if (BulbNumbers > 0&& click==true)
            {
                Console.WriteLine("The chandelier is turned on.");
                return true;
            }
            else
            {
                Console.WriteLine("The chandelier is turned off.");
                return false;
            }
        }
        public int AdjustColor(int number)
        {
            if (!IsTurnOn(true))
            {
                Console.WriteLine("Chandelier is turned off. You have to turn it on to adjust the color.");
                return 0;
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("The chandelier is bright with a bright yellow image");
                    return number;
                case 2:
                    Console.WriteLine("The chandelier is bright with a slightly orange-yellow image");
                    return number;
                case 3:
                    Console.WriteLine("The chandelier is bright with a white color image");
                    return number;
                default:
                    Console.WriteLine("Invalid color number. Defaulting to 0.");
                    return 0;
            }
        }
    }
}
