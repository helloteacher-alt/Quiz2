using System;

namespace Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Input Total rose:");
            int numRose = int.Parse(Console.ReadLine());
            Console.Write("Input Total Sun flower:");
            int numSunflower = int.Parse(Console.ReadLine());
            int i;
            if (numRose > 0)
            {
                Console.WriteLine("Input Rose:");
                Console.WriteLine("----------");
                Console.WriteLine(" ");
                for (i = 0; i < numRose; i++)
                {
                    Console.Write("ID:");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Plant name:");
                    string plantName = Console.ReadLine();
                    Console.Write("Plant description:");
                    string plantDescription = Console.ReadLine();
                    Console.Write("Amount:");
                    int plantNum = int.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    string plantHeight = Console.ReadLine();
                    Console.Write("Circumference:");
                    string plantCircum = Console.ReadLine();
                    //Rose.AddRose();
                }
                Console.Clear();
            }
            if (numSunflower > 0)
            {
                Console.WriteLine("Input Sun Flower:");
                Console.WriteLine("----------");
                Console.WriteLine(" ");
                for (i = 0; i < numRose; i++)
                {
                    Console.Write("ID:");
                    int ID = int.Parse(Console.ReadLine());
                    Console.Write("Plant name:");
                    string plantName = Console.ReadLine();
                    Console.Write("Plant description:");
                    string plantDescription = Console.ReadLine();
                    Console.Write("Amount:");
                    int plantNum = int.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    string plantHeight = Console.ReadLine();
                    Console.Write("Circumference:");
                    string plantCircum = Console.ReadLine();
                    PropertyOfPlant Sunflower = new PropertyOfPlant(ID, plantName, plantDescription, plantNum, plantHeight, plantCircum);
                    //Sunflower.AddSunflower();
                }
                Console.Clear();
            }
        }
        
    }
    class PropertyOfPlant
    {
        public int ID;
        public string plantName;
        public string plantDescription;
        public int plantNum;
        public string plantHeight;
        public string plantCircum;
        public PropertyOfPlant(int valueID,string valuePlantName,string valuePlantDescription,int valuePlantNum,string valuePlantHeight,string valuePlantCircum)
        {
            ID = valueID;
            plantName = valuePlantName;
            plantDescription = valuePlantDescription;
            plantName = valuePlantName;
            plantHeight = valuePlantHeight;
            plantCircum = valuePlantCircum;
           }
    }
    /*class AddFlower
    {
        public AddFlower AddRose()
        {

        }
        public AddFlower AddSunFlower()
        {

        }
        
    }*/
}
