using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Persion : Animal
    {
        private float Cash;
        private string Name;
        private string Intrest;
        private string PetName;
        private bool hasPet;

        public Persion()
        {
            Cash = 0f;
            Name = "";
            Intrest = "";
        }

        public override void PrintIntrest()
        {
            Console.WriteLine(getName() + " Is Intrested in: " + getIntrest() + "\n");
        }

        public override void PrintName()
        {
            Console.WriteLine(getName());
        }

        public bool hasPetstat()
        {
            return this.hasPet;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getIntrest()
        {
            return this.Intrest;
        }

        public float getCash()
        {
            return this.Cash;
        }

        public string getPetName()
        {
            return this.PetName;
        }

        public void setPetName(string name)
        {
            this.PetName = name;
        }

        public void sethasPetStat(bool pet)
        {
            this.hasPet = pet;
        }

        public void setName(string nam)
        {
            this.Name = nam;
        }

        public void setIntrest(string intr)
        {
            this.Intrest = intr;
        }

        public void setCash(float ca)
        {
            this.Cash = ca;
        }
    }
}
