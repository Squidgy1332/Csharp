using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
 * * Auther: Liam Morton
 * * date: 2020/08/20
 * * File: Pets.cs
 * * Program: MatchMaker (C# Basics)
 * * Description: This program is a match maker for people and pets
 * * this is the class for pets and is used to store data about pets
 * * and to print data about pets
 * * it extends the abstract Animal class
 * */
namespace CSharp_Basics
{
    internal class Pets : Animal
    {
        //data for pets
        //private so that it can only be accessed by this class
        //string is used to store text
        private string Name;
        //bool is used to store true or false
        private bool HasPersion;
        private string Intrest;
        private string PersionName;
        //float is used to store numbers with decimal places
        private float Price;

        //constructor for pets
        /*
         * this is used to set the default values for pets
         */
        public Pets()
        {
            Name = "";
            HasPersion = false;
            Intrest = "";
            PersionName = "";
            Price = 0f;
        }

        /*
         * PrintIntrest: this function is used to print the pets name and what it is intrested in
         */
        public override void PrintIntrest()
        {
            Console.WriteLine(getName() + " Is Intrested in: " + getIntrest() + "\n");
        }

        /*
         * PrintName: this function is used to print the pets name
         */
        public override void PrintName()
        {
            Console.WriteLine(getName());
        }

        /*
         * getPersionName: this function is used to get the name of the persion that owns the pet
         */
        public string getPersionName()
        {
            return this.PersionName;
        }

        /*
         * getName: this function is used to get the name of the pet
         */
        public string getName()
        {
            return this.Name;
        }

        /*
         * getIntrest: this function is used to get the intrest of the pet
         */
        public string getIntrest()
        {
            return this.Intrest;
        }

        /*
         * getPrice: this function is used to get the price of the pet
         */
        public float getPrice()
        {
            return this.Price;
        }

        /*
         * hasPersion: this function is used to check if the pet has a persion
         */
        public bool hasPersion()
        {
            return this.HasPersion;
        }

        /*
         * SetPersionStat: this function is used to set the persion stat
         * it takes in a bool
         */
        public void SetPersionStat(bool stat)
        {
            this.HasPersion = stat;
        }

        /*
         * setPetOwner: this function is used to set the persion name
         * it takes in a string
         */
        public void setPetOwner(string nam)
        {
            this.PersionName = nam;
        }

        /*
         * setName: this function is used to set the pet name
         * it takes in a string
         */
        public void setName(string nam)
        {
            this.Name = nam;
        }

        /*
         * setIntrest: this function is used to set the pet intrest
         * it takes in a string
         */
        public void setIntrest(string intr)
        {
            this.Intrest = intr;
        }

        /*
         * setPrice: this function is used to set the pet price
         * it takes in a float
         */
        public void setPrice(float pri)
        {
            this.Price = pri;
        }
    }
}
