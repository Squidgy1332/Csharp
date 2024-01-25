using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Basics
{
    internal class Program
    {
        
        static void Main(string[] args){
            int CV = 10;
            string userInput;
            List<Pets> allPets = new List<Pets>();
            List<Persion> allPeople = new List<Persion>();

            while (CV != 0)
            {
                Console.WriteLine("add people or pet to list: \ntype 1 to add persion \ntype 2 to add pet \ntype 3 to find the best matches \nor type 0 to end program \ntype hear: ");
                try
                {
                   userInput = Console.ReadLine();
                   CV = int.Parse(userInput);
                }catch (FormatException)
                {
                    Console.WriteLine("cant covert input to int");
                }
                
                switch (CV)
                {
                    case 0:
                        break;
                    case 1:
                        AddPersion(allPeople);
                        break;
                    case 2:
                        AddPet(allPets);
                        break;
                    case 3:
                        FindMatch(allPeople, allPets);
                        break;
                    default:
                        Console.WriteLine("Improper Input: " + CV);
                        break;
                }
            }
        }

        static public void FindMatch(List<Persion> people, List<Pets> pet)
        {
            foreach (Persion p in people){
                foreach(Pets pets in pet)
                {
                    if (!pets.hasPersion() || !p.hasPetstat())
                    {
                        if(p.getIntrest() == pets.getIntrest())
                        {
                            if(p.getCash() >= pets.getPrice())
                            {
                                p.sethasPetStat(true);
                                pets.SetPersionStat(true);
                                
                                p.setPetName(pets.getName());
                                pets.setPetOwner(p.getName());

                                Console.WriteLine(p.getName() + " has matched with " + pets.getName() + "\n");
                            }
                            else
                            {
                                Console.WriteLine("No match for: " + p.getName());
                            }
                        }else if(p.getCash() >= pets.getPrice())
                        {
                            Console.WriteLine(p.getName() + "can afored " + pets.getName() + " but has defrrent address\n");
                        }
                    }
                }
            }

        }

        static public void AddPersion(List<Persion> people)
        {
            string userInput;
            Persion P = new Persion();

            Console.WriteLine("Inter persion name: ");
            userInput = Console.ReadLine();
            P.setName(userInput);

            Console.WriteLine("Inter persion Intrest: ");
            userInput = Console.ReadLine();
            P.setIntrest(userInput);

            Console.WriteLine("How much mony do you have: ");
            userInput = Console.ReadLine();
            int price = int.Parse(userInput);
            P.setCash(price);

            Console.WriteLine("New persion was added\n");
            P.PrintName();
            P.PrintIntrest();
            Console.WriteLine("Cost: " + P.getCash());

            people.Add(P);
            
        }

        static public void AddPet(List<Pets> pet)
        {
            string userInput;
            Pets P = new Pets();

            Console.WriteLine("Inter Pets name: ");
            userInput = Console.ReadLine();
            P.setName(userInput);

            Console.WriteLine("Inter Pets Intrest: ");
            userInput = Console.ReadLine();
            P.setIntrest(userInput);

            Console.WriteLine("Inter cost of pet: ");
            userInput = Console.ReadLine();
            int price = int.Parse(userInput);
            P.setPrice(price);

            Console.WriteLine("New pet was added\n");
            P.PrintName();
            P.PrintIntrest();
            Console.WriteLine("Cost: " + P.getPrice());

            pet.Add(P);
        }
    }
}
