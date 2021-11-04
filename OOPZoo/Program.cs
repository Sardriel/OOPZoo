using System;

namespace OOPZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzivatel u = new Uzivatel("Jan Novák", 33);
            Administrator a = new Administrator("Josef Nový", 25);
            u = a;
            
        }
    }
}
