using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * * * Auther: Liam Morton
 * * * date: 2020/08/20
 * * * File: Animal.cs
 * * * Program: MatchMaker (C# Basics)
 * * * Description: This program is a match maker for people and pets
 * * * this is the abstract class for animal and is used to store data about animals
 * * * */
namespace CSharp_Basics
{
    abstract class Animal
    {
        //data for animal
        //it declares functions used by all child classes
        public abstract void PrintName();
        public abstract void PrintIntrest();
    }
}
