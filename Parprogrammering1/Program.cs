namespace Parprogrammering1
{
    class Program
    {
        public static void Main(string[] arg)
        {
            Init();
            var pet1 = new NewPet("Kåre");
            pet1.Show();

            
            static void CreatePet(string input)
            {
                var inputName = new NewPet(input);
                inputName.Show();
            }

            static void Init()
            {
                Console.WriteLine("What is the name of your new pet?");
                var inputName1 = Console.ReadLine();
                Console.WriteLine("What is the name of your second pet?");
                var inputName2 = Console.ReadLine();
                Console.WriteLine("What is the name of your third pet?");
                var inputName3 = Console.ReadLine();
                CreatePet(inputName);
            }

            static void Continue()
            {
                Console.Clear();
                if(pet1.NeedFood){}
            }
        }
    }
}