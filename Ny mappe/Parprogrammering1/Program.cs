namespace Parprogrammering1
{
    class Program
    {
        public static void Main(string[] arg)
        {
            List<NewPet>petList = new List<NewPet>();
            Init();
            DisplayPets();
            Console.Read();
            FoodPoopOrPet();

            int Randomizer()
            {
                var Random = new Random();
                int RandomNumber = Random.Next(0, 3);
                return RandomNumber;
            }

            void FoodPoopOrPet()
            {   
                int rand = Randomizer();
                if (rand == 0)
                {
                    Console.WriteLine("Your pet needs to use the loo...");
                }
                else if (rand == 1)
                {
                    Console.WriteLine("Your pet is hungry AF!");
                } else
                {
                    Console.WriteLine("Please pet your pet!");
                }
                HelpPet(rand);
                
            }

            void HelpPet(int rand)
            {
                Console.WriteLine("\n a. Pet your Pet! \n b. Feed your pet! \n c. Help your pet to the toilet!");
                
                var input = Console.ReadLine();
                string convertTostring;
                if (rand == 0)
                {
                    convertTostring = "a";
                } else if (rand == 1)
                {
                    convertTostring = "b";
                } else { convertTostring = "c"; }
                 
                if (input == convertTostring )
                 {
                    Console.WriteLine("Well done, your pet looks very satisfied.");
                }
                 else
                 {
                     Console.WriteLine("Get better");
                 }
            }


            void CreatePet(string input)
            {
                var inputName = new NewPet(input);
                petList.Add(inputName);
            }

             void Init()
            {
                Console.WriteLine("What is the name of your new pet?");
                var inputName = Console.ReadLine();
                CreatePet(inputName);
                Console.WriteLine("What is the name of your second pet?");
                inputName = Console.ReadLine();
                CreatePet(inputName);
                Console.WriteLine("What is the name of your third pet?");
                inputName = Console.ReadLine();
                CreatePet(inputName);
            }

             void DisplayPets()
             {
                 Console.WriteLine("Look at these awesome pets: ");
                    foreach (var pet in petList)
                     { Console.WriteLine(pet.Name);
                 }
             }





             /*
             static void Continue()
             {
                 Console.Clear();
                 if(pet1.NeedFood){}
             }
             */
        }
    }
}