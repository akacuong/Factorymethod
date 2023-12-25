using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLightFactory.Light1
{
    public class SpotLight : Light
    {
        public string Lens { get; set; }
        public string Mirror { get; set; }
        public string Motor { get; set; }
        public double LightIntensity { get; set; }
        public override string DisplayInformation()
        {
            string information =
                        $"Chip: {Chip} MCOB\n" +
                        $"Wattage: {Wattage}w\n" +
                        $"Bulb Numbers: {BulbNumbers} bulb\n" +
                        $"Weight: {Weight} kg\n" +
                        $"Lens: {Lens}\n" +
                        $"Mirror : {Mirror}\n" +
                        $"Motor:{Motor}\n" +
                        $"LightIntensity:{LightIntensity} lm\n";
            return information;
        }
        public override bool IsTurnOn(bool click)
        {
            if (LightIntensity > 0 && click == true)
            {
                Console.WriteLine("The SpotLight is turned on.");
                return true;
            }
            else
            {
                Console.WriteLine("The SpotLight is turned off.");
                return false;
            }
        }
        public void GoboCreation(int kind)
        {
            if (IsTurnOn(true))
            {
                Console.Write("Creating Gobo: ");
                if (kind == 1)
                {
                    Console.WriteLine("Flower-shaped light Gobo");
                }
                else if (kind == 2)
                {
                    Console.WriteLine("Hearts-shaped light Gobo");
                }
                else if (kind == 3)
                {
                    Console.WriteLine("Bubbles-shaped light Gobo");
                }
                else if (kind == 4)
                {
                    Console.WriteLine("Stars-shaped light Gobo");
                }
                else
                {
                    Console.WriteLine("Invalid Gobo kind. No Gobo created.");
                }
            }
            else
            {
                Console.WriteLine("Creating Gobo cannot be performed");
            }
        }
        public void FastFlashing()
        {
            if (IsTurnOn(true))
            {
                LightIntensity *= 3;
                Console.WriteLine($"SpotLight is fast flashing with LightIntrnsity={LightIntensity}Lm!");
            }
            else
            {
                Console.WriteLine("Fast flashing cannot be performed because the SpotLight is turned off.");
            }
        }
    }
}
