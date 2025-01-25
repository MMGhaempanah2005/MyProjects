
using ZOO;

Console.WriteLine("How many types of Animals do you have?");
int number  = Convert.ToInt32(Console.ReadLine());
Animal[] animals = new Animal[number];

for (int i = 0; i < number; i++)
{
    Console.WriteLine($"please enter Animal[{(i+1)}] name :");
    string name = Console.ReadLine();

    Console.WriteLine($"please enter Animal[{(i + 1)}] species :");
    string species = Console.ReadLine();

    Console.WriteLine($"please enter Animal[{(i + 1)}] age :");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"please enter Animal[{(i + 1)}] specialfeatures :");
    string specialfeatures = Console.ReadLine();

    Console.WriteLine($"please enter Animal[{(i + 1)}] numbers :");
    int Numbers = Convert.ToInt32(Console.ReadLine()); 


    Animal a = new Animal(name, species, age, specialfeatures, number);
    animals[i]= a;

}
Console.ForegroundColor = ConsoleColor.Green;

foreach (Animal animal in animals)
{
    Console.WriteLine($"name:{animal.name} species:{animal.species} age:{animal.age} specialfeatures:{animal.specialfeatures} numbers:{animal.numbers}");
}
Console.ResetColor();