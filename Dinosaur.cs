namespace JurassicPark
{
    // static void DisplayGreeting()
    // {
    //     Console.WriteLine("------------------------------------------");
    //     Console.WriteLine("   🦕 🦖 Welcome to Jurassic Park 🦖 🦕    ");
    //     Console.WriteLine("------------------------------------------");
    //     Console.WriteLine();
    //     Console.WriteLine();


    // }
    class Dinosaur
    {
        public string Name { get; set; }
        public string Diet { get; set; }
        public double WhenAcquired { get; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }


        public string DisplayDinosaur()
        {
            return ($"{Name} is a {Diet} that was acquired {WhenAcquired}, it weighs {Weight} & is in enclosure {EnclosureNumber}.");
        }
    }
}

