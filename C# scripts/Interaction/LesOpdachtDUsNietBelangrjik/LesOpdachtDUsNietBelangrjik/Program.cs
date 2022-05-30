using System;
using System.IO;

namespace LesOpdrachtDUsNietBelangrijk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RpgCharacter hero = new RpgCharacter();
            Console.WriteLine(hero.name);
            Console.WriteLine(hero.str);
            Console.WriteLine(hero.hp);
            Console.ReadLine();

        }

    }
    internal class RpgCharacter
    {

        internal RpgCharacter(int str, int hp, string name)
        {
            this.str = str;
            this.hp = hp;
            this.name = name;
        }
        internal RpgCharacter()
        {

        }
        internal readonly string name = "Cloud strife";
        internal int str = 999;
        internal int hp = 9999;
    }

}