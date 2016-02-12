using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFSmartExercises
{
    class Fish : Animal
    {
        public int DistanceSwam { get; set; }
        
        public Fish(string sound, string color, bool meat, int distance) : base(sound, color, meat)
        {
            SoundItMakes = sound;
            Color = color;
            EatsMeat = meat;
            DistanceSwam = distance;
        }

        public override void DescribeYourself()
        {
            Console.WriteLine("I am a FISH colored {0}. I say '{1}'. I have swuam {2} feet today.", Color, SoundItMakes, DistanceSwam);
        }

        public void Swim(int feetSwam)
        {
            DistanceSwam += feetSwam;
        }
    }
}
