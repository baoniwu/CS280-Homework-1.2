using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Number = "004";
            pokemon.Name = "Charmander";
            pokemon.Height = 2.0f;
            pokemon.Weight = 12f;
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";

            Console.WriteLine("編號:#{0}, 名字:{1}", pokemon.Number, pokemon.Name);
        }
    }
}