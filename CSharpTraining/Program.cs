using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using static CSharpTraining.Util;
using static System.Console;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero hero = null;

            //old syntax of checking if an instance is null or not 
            WriteLine(hero != null ? hero.SuperPower : "You aint a super hero.");

            //Using new operator
            WriteLine(hero?.SuperPower ?? "You aint a super hero.");

            //using lists

            List<SuperHero> superHeroes = null;
            WriteLine(superHeroes?[0].SuperPower ?? "There is no such thing as super heros.");
            ReadLine();
        }
        
    }
    public class SuperHero
    {
        public string SuperPower { get; set; } = "Run faster";
    }
}

