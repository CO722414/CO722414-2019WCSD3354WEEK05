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
            public string dog_name;
            public string dog_breed;
            public dog next_dog;
            public dog prev_dog;

        }
        class birthday_party
        {
            public dog peanut;
            public dog fifi;
            public dog clarane;
            public dog roy;

            public dog head;
            public dog tail;
            public dog temporary;

        }
    }
}
