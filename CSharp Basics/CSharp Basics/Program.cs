using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
/**************************************************************/
/* Auther: Liam Morton
 * date: 2020/08/20
 * File: Program.cs
 * Program: MatchMaker (C# Basics)
 * Description: This program is a match maker for people and pets
 * this is the main file for the program and is used to add people 
 * and pets to a list and then find the best matches for them
 */
namespace CSharp_Basics
{
    internal class Program
    {
        /*
         * Main: this is the main function for the program
         * it get user input and then calls the correct function
         */
        static void Main(string[] args){
            //control variable
            int CV = 10;
            //chat used to store single keyboard input
            char = 'a';
            //double is used to store large floats
            double = 0.0;
            string userInput;
            //list of people and pets
            List<Pets> allPets = new List<Pets>();
            List<Persion> allPeople = new List<Persion>();

            //loop to get user input while CV is 0
            while (CV != 0)
            {
                //show user options
                Console.WriteLine("add people or pet to list: \ntype 1 to add persion \ntype 2 to add pet \ntype 3 to find the best matches \nor type 0 to end program \ntype hear: ");
                //error handeling for converting user input to int
                try
                {
                   userInput = Console.ReadLine();
                   //parse used to covert data types
                   CV = int.Parse(userInput);
                }catch (FormatException)
                {
                    //error message
                    Console.WriteLine("cant covert input to int");
                }
                
                //switch statment to call function based on Cv value
                switch (CV)
                {
                    //0 is used to end the program
                    case 0:
                        break;
                    //1 runs Addpersion function to add persion to the list
                    case 1:
                        AddPersion(allPeople);
                        break;
                    //2 runs AddPet function to add pet to the list
                    case 2:
                        AddPet(allPets);
                        break;
                    //3 runs FindMatch function to find the best matches
                    case 3:
                        FindMatch(allPeople, allPets);
                        break;
                    //default is used to handel improper input
                    default:
                        Console.WriteLine("Improper Input: " + CV);
                        break;
                }
            }
        }

        /*
         * FindMatch: this function is used to find the best matches for people and pets
         * it takes in two lists one of people and one of pets
         * it then loops through both lists and finds the best matches
         * it then prints the matches to the console
         */
        static public void FindMatch(List<Persion> people, List<Pets> pet)
        {
            //loop through both lists
            //p is used to loop through people
            //pets is used to loop through pets
            foreach (Persion p in people){
                foreach(Pets pets in pet)
                {
                    //check if the pet has a owner and if the persion has a pet
                    if (!pets.hasPersion() || !p.hasPetstat())
                    {
                        //check if the persion and pet have the same intrest
                        if(p.getIntrest() == pets.getIntrest())
                        {
                            //check if the persion can afford the pet
                            if(p.getCash() >= pets.getPrice())
                            {
                                //set the persion and pets stats to true
                                p.sethasPetStat(true);
                                pets.SetPersionStat(true);
                                
                                //set the persion and pets names to each other
                                p.setPetName(pets.getName());
                                pets.setPetOwner(p.getName());

                                //print the match to the console
                                Console.WriteLine(p.getName() + " has matched with " + pets.getName() + "\n");
                            }
                            //if the persion cant afford the pet print a message to the console
                            else
                            {
                                Console.WriteLine(p.getName() + " cant afford " + pets.getName() + "\n");
                            }
                        //if the persion and pet dont have the same intrest print a message to the console
                        }else if(p.getCash() >= pets.getPrice())
                        {
                            Console.WriteLine(p.getName() + "can afored " + pets.getName() + " but has defrrent intrest\n");
                        //if the persion allready has a pet print a message to the console
                        }else
                        {
                            Console.WriteLine(p.getName() + "all ready has a pet: " + p.getPetName() + "\n");
                        }
                    }
                }
            }

        }

        /*
         * AddPersion: this function is used to add a persion to the list
         * it takes in a list of persion
         * it then gets user input and adds a persion to the list
         */
        static public void AddPersion(List<Persion> people)
        {
            //set up variables
            string userInput;
            //create a new persion
            Persion P = new Persion();

            //get user input for persion name
            Console.WriteLine("Inter persion name: ");
            userInput = Console.ReadLine();
            //set the persion name
            P.setName(userInput);

            //get user input for persion intrest
            Console.WriteLine("Inter persion Intrest: ");
            userInput = Console.ReadLine();
            //set the persion intrest
            P.setIntrest(userInput);

            //get user input for persion cash
            Console.WriteLine("How much mony do you have: ");
            userInput = Console.ReadLine();
            //convert user input to int
            int price = int.Parse(userInput);
            //set the persion cash
            P.setCash(price);

            //print the persion to the console
            Console.WriteLine("New persion was added\n");
            //print the persion name and intrest using the print functions
            P.PrintName();
            P.PrintIntrest();
            Console.WriteLine("Cost: " + P.getCash());

            //add the persion to the list
            people.Add(P);
        }

        /*
         * AddPet: this function is used to add a pet to the list
         * it takes in a list of pets
         * it then gets user input and adds a pet to the list
         */
        static public void AddPet(List<Pets> pet)
        {
            //set up variables
            string userInput;
            //create a new pet
            Pets P = new Pets();

            //get user input for pet name
            Console.WriteLine("Inter Pets name: ");
            userInput = Console.ReadLine();
            //set the pet name
            P.setName(userInput);

            //get user input for pet intrest
            Console.WriteLine("Inter Pets Intrest: ");
            userInput = Console.ReadLine();
            //set the pet intrest
            P.setIntrest(userInput);

            //get user input for pet cost
            Console.WriteLine("Inter cost of pet: ");
            userInput = Console.ReadLine();
            //convert user input to int
            int price = int.Parse(userInput);
            //set the pet cost
            P.setPrice(price);

            //print the pet to the console
            Console.WriteLine("New pet was added\n");
            //print the pet name and intrest using the print functions
            P.PrintName();
            P.PrintIntrest();
            Console.WriteLine("Cost: " + P.getPrice());

            //add the pet to the list
            pet.Add(P);
        }
    }
}
