namespace Safari
{
    internal class HuntingGround : SafariEnvironment<IHunt>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is IHunt && animal is IFly)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting in the skies above the hunting ground");
                }
                else if (animal is IHunt && animal is ISwim)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting in the waters of the hunting ground");
                }
                else if (animal is IHunt)
                {
                    Console.WriteLine(animal.GetType().Name + " is hunting on land in the hunting ground");
                }
            }
        }
    }
}