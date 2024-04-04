namespace PokemonDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokemonContext context = new PokemonContext();

            IQueryable<Pokemon> query = context.Pokemon;
            Console.WriteLine("All Pokemon");
            foreach (Pokemon p in query)
            {
                Console.WriteLine("Name: " + p.Name + " Abilitys: " + p.Ability1 + "," + p.Ability2 + " Type: " + p.Type1 + "," + p.Type2);
            }
            Console.WriteLine("\n\n");

            Console.WriteLine("Find all water types");
            var WaterType = context.Pokemon.Where(p => p.Type1 == "Water" || p.Type2 == "Water");
            foreach (Pokemon p in WaterType)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("\n\n");

            var Pika = from p in context.Pokemon
                       where p.Name == "Pikachu"
                       select p;

            Console.WriteLine("Find Pikachu");
            foreach (Pokemon p in Pika)
            {
                Console.WriteLine("Name: " + p.Name + " Abilitys: " + p.Ability1 + "," + p.Ability2 + " Type: " + p.Type1 + "," + p.Type2);
            }
        }
    }
}
