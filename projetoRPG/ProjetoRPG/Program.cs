using System;
using ProjetoRPG.src.entities;

namespace ProjetoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            
            knight arus = new knight("Arus", 23, "Knight");
            Wizard maria = new Wizard("maria", 21, "wizard");
            Console.Write(maria.Attack(7));
            Console.Write(maria.Attack(1));

            
        }
    }
}
