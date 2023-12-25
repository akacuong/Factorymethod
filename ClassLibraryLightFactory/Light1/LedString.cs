using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLightFactory.Light1
{
    public class LedString : Light
    {
        public string MaterialProtect { get; set; }
        public string Elasticity { get; set; }
        public override string DisplayInformation()
        {
            string information =
                $"Chip: {Chip} MCOB\n" +
                $"Wattage: {Wattage}w\n" +
                $"Bulb Numbers: {BulbNumbers} bulb\n" +
                $"Weight: {Weight} kg\n" +
                $"MaterialProtect: {MaterialProtect}\n" +
                $"Elasticity:  {Elasticity}\n";
            return information;
        }
        public override bool IsTurnOn(bool click)
        {
            if (click == true)
            {
                Console.WriteLine("The Led string is turned on, light color is red.");
                return true;
            }
            else
            {
                Console.WriteLine("The Led string is turned off.");
                return false;
            }
        }
        private bool continueColorCycle = false;
        public void LightMode(int mode)
        {
            if (IsTurnOn(true)) { 
            switch (mode)
          {
             case 1:
             Console.WriteLine("Set light mode to Blue Light.");
             break;
             case 2:
             Console.WriteLine("Set the light mode to Purple light.");
             break;
             case 3:
             Console.WriteLine("Set light mode to Red Light.");
             break;
             case 4:
             Console.WriteLine("Light through Continuous blue, purple and red light:");
             continueColorCycle = true;
             Task.Run(() => ColorCycle());
             continueColorCycle = false;
             break;         
             default:
              Console.WriteLine("Invalid light mode. No changes were made.");
                break;
            }
           }
        }
        private void ColorCycle()
        {
           for(int i = 0; i <= 2; i++) 
            { 
             {
                Console.WriteLine("Blue Light");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Purple Light");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Red Light");
                System.Threading.Thread.Sleep(1000);
              }
           }
        }
        public void TimerMode(int minute)
        {
            if (IsTurnOn(true))
            {
                Console.WriteLine($"Timer mode set for {minute} minutes. Led string will turn off after {minute} minutes.");
                int delayMilliseconds = minute * 60 * 1000;
                Task.Delay(delayMilliseconds).Wait(); 
                Console.WriteLine($"Led string turned off after {minute} minutes.");
                IsTurnOn(false);
            }
        }
    }
}
