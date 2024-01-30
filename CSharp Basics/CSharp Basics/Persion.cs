using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * * Auther: Liam Morton
 * * date: 2020/08/20
 * * File: Persion.cs
 * * Program: MatchMaker (C# Basics)
 * * Description: This program is a match maker for people and pets
 * * this is the class for persion and is used to store data about persion
 * * its extends the abstract Animal class
 * * */
namespace CSharp_Basics
{
    internal class Persion : Animal
    {
        //data for persion
        //private so that it can only be accessed by this class
        //float is used to store numbers with decimal places
        private float Cash;
        //string is used to store text
        private string Name;
        private string Intrest;
        private string PetName;
        //bool is used to store true or false
        private bool hasPet;

        /*constructor for persion
         * this is used to set the default values for persion
         * */
        public Persion()
        {
            Cash = 0f;
            Name = "";
            Intrest = "";
        }

        /*
         * PrintIntrest: this function is used to print the persion name and what it is intrested in
         */
        public override void PrintIntrest()
        {
            Console.WriteLine(getName() + " Is Intrested in: " + getIntrest() + "\n");
        }

        /*
         * PrintName: this function is used to print the persion name
         */
        public override void PrintName()
        {
            Console.WriteLine(getName());
        }

        /*
         * hasPetstat: this function is used to return the hasPet stat
         */
        public bool hasPetstat()
        {
            return this.hasPet;
        }

        /*
         * getName: this function is used to return the name
         */
        public string getName()
        {
            return this.Name;
        }

        /*
         * getIntrest: this function is used to return the intrest
         */
        public string getIntrest()
        {
            return this.Intrest;
        }

        /*
         * getCash: this function is used to return the cash
         */
        public float getCash()
        {
            return this.Cash;
        }

        /*
         * getPetName: this function is used to return the pet name
         */
        public string getPetName()
        {
            return this.PetName;
        }

        /*
         * setPetName: this function is used to set the pet name
         */
        public void setPetName(string name)
        {
            this.PetName = name;
        }

        /*
         * setPetName: this function is used to set the pet name
         */
        public void sethasPetStat(bool pet)
        {
            this.hasPet = pet;
        }

        /*
         * setCash: this function is used to set the cash
         */
        public void setName(string nam)
        {
            this.Name = nam;
        }

        /*
         * setIntrest: this function is used to set the intrest
         */
        public void setIntrest(string intr)
        {
            this.Intrest = intr;
        }

        /*
         * setCash: this function is used to set the cash
         */
        public void setCash(float ca)
        {
            this.Cash = ca;
        }
    }
}
