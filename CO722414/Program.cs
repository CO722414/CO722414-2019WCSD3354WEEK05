using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO722414
{
    class Program
    {
        static void Main(string[] args)
        { }

      class dog
        {
            public dog(string name, string breed)
            {
                dog_name = name;
                dog_breed = breed;
            }

            public dog()
            {
            }

            public string dog_name;
            public string dog_breed;
            public dog next_dog;
            public dog prev_dog;

        }
        class birthday_party
        {
            public dog peanut;
            public dog fifi;
            public dog clarance;
            public dog roy;

            public dog head;
            public dog tail;
            public dog temporary;
            public void pea()

            {
                peanut = new dog("peanut", "Bichon");
                fifi = new dog("fifi", "Poodle");
                clarance = new dog("Clarence", "German Sheppard");
                roy = new dog("Roy", "Beagle");

                peanut.prev_dog = null;
                peanut.next_dog = fifi;
                fifi.prev_dog = peanut;
                fifi.next_dog = clarance;
                clarance.prev_dog = fifi;
                clarance.next_dog = roy;
                roy.prev_dog = clarance;
                roy.next_dog = null;
                head = peanut;
                tail = roy;

            }

        }
    }
}
