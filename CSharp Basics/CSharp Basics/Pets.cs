using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    internal class Pets : Animal
    {
        private string Name;
        private bool HasPersion;
        private string Intrest;
        private string PersionName;
        private float Price;

        public Pets()
        {
            Name = "";
            HasPersion = false;
            Intrest = "";
            PersionName = "";
            Price = 0f;
        }

        public override void PrintIntrest()
        {
            Console.WriteLine(getName() + " Is Intrested in: " + getIntrest() + "\n");
        }

        public override void PrintName()
        {
            Console.WriteLine(getName());
        }

        public string getPersionName()
        {
            return this.PersionName;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getIntrest()
        {
            return this.Intrest;
        }

        public float getPrice()
        {
            return this.Price;
        }

        public bool hasPersion()
        {
            return this.HasPersion;
        }

        public void SetPersionStat(bool stat)
        {
            this.HasPersion = stat;
        }

        public void setPetOwner(string nam)
        {
            this.PersionName = nam;
        }

        public void setName(string nam)
        {
            this.Name = nam;
        }

        public void setIntrest(string intr)
        {
            this.Intrest = intr;
        }

        public void setPrice(float pri)
        {
            this.Price = pri;
        }
    }
}
