using Safari;

class Program
{
    static void Main(string[] args)
    {
        Tiger fluffy = new Tiger(70.5f);
        Penguin penny = new Penguin(21);

        fluffy.MakeSound();
        penny.MakeSound();

        fluffy.Hunt();
        penny.Hunt(); 
        penny.Swim();
    }
}
