using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Inheritance
{
    class Television
    {
        public string Colour = "Black";
        public void ShowTele()
        {
            Console.WriteLine(Colour);
        }
    }

    internal class Videocon : Television
    {
        public void ChangeColour()
        {
            Colour = "Matt Black";
        }
        public void ShowVideocon()
        {
            Console.WriteLine("Videocon : " + Colour);
        }
    }
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            Videocon TV = new Videocon();
            TV.ShowTele();
            TV.ChangeColour();
            TV.ShowVideocon();
        }
    }

    // Hierarchical Inheritance
    class Fruit
    {
        public string Taste = "Sweet";
        public void ShowFruit()
        {
            Console.WriteLine("Fruit : " + Taste);
        }
    }
    class Mango : Fruit
    {
        public string Colour = "Yellow";
        public void ShowMango()
        {
            Console.WriteLine("Mango Colour : " + Colour + "\nTaste : " + Taste);
        }
    }
    class Orange : Fruit
    {
        public string Colour = "Orange";
        public void ShowOrange()
        {
            Console.WriteLine("Orange Colour : " + Colour + "\nTaste : " + Taste);
        }
    }
    class Hierarchical
    {
        static void Main(string[] args)
        {
            Mango m = new Mango();
            m.ShowFruit();
            m.ShowMango();
            Orange o = new Orange();
            o.ShowFruit();
            o.ShowOrange();
        }
    }

    // Multilevel Inheritance
    class Country
    {
        public string PrimeMinister = "Narendra Modi";
        public string Population = "135 Crore";
        public void ShowCountry()
        {
            Console.WriteLine("Prime Minister : " + PrimeMinister);
            Console.WriteLine("Population : " + Population);
        }
    }
    class State : Country
    {
        public void ChangeSPopulation()
        {
            Population = "13 Crore";
        }
        public void ShowState()
        {
            Console.WriteLine("Prime minister : " + PrimeMinister + "\nPopulation : " + Population);
        }
    }
    class District : State
    {
        public void ChangeDPopulation()
        {
            Population = "50 Lakh";
        }
        public void ShowDistrict()
        {
            Console.WriteLine("Prime minister : " + PrimeMinister + "\nPopulation : " + Population);
        }
    }
    class MultiLevel
    {
        static void Main(string[] args)
        {
            District d = new District();
            d.ShowCountry();
            d.ChangeSPopulation();
            d.ShowState();
            d.ChangeDPopulation();
            d.ShowDistrict();
        }

    }
}
