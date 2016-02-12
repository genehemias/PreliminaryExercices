using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFSmartExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal("meow", "brown", true);

            fox.Color = "red";
            fox.SoundItMakes = "yip";

            fox.DescribeYourself();
            fox.HaveAHotDog();

            Fish goldie = new Fish("glub", "yellow", true, 35);
            
            goldie.Color = "brilliant orange";
            
            goldie.Swim(5);
            goldie.DescribeYourself();

            Console.ReadKey();
        }
    }
}
