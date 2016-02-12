using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFSmartExercises
{
    class Animal
    {
        public string SoundItMakes { get; set; }

        public string Color { get; set; }

        public bool EatsMeat { get; set; }

        public Animal(string sound, string color, bool meat)
        {
            SoundItMakes = sound;
            Color = color;
            EatsMeat = meat;
        }

        public virtual void DescribeYourself()
        {
            Console.WriteLine("I am an animal colored {0}. I say '{1}'. ", Color, SoundItMakes);
        }
        public void HaveAHotDog()
        {
            if (EatsMeat)
            {
                Console.WriteLine("Yummy!");
            }
            else
            {
                Console.WriteLine("Not thank you.");
            }
        }
    }
}
