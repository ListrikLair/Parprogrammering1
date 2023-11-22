using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering1
{
    internal class NewPet
    {
        public string Name;
        public int Age;
        public bool NeedFood = true;
        public bool NeedPoop;
        public bool NeedPets;

        public NewPet(string name, int age, bool needFood, bool needPoop, bool needPets)
        {
            Name = name;
            Age = age;
            NeedFood = needFood;
            NeedPoop = needPoop;
            NeedPets = needPets;
        }

        public NewPet(string name)
        {
            Name = name;
        }

        public void Show()
        {
            Console.WriteLine($"Your pet's name is {Name} and it's age is {Age} NeedFood = {NeedFood}");
        }

        public void IsHungry()
        {
            
        }
    }
}
