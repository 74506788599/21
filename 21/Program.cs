using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        //R = Rouge; O = Orange; V = Vert
        {
            char couleur;
            do
            {
                Console.WriteLine("Couleur du feu : [R/O/V]");
                couleur = Console.ReadKey().KeyChar;
            } while (couleur != 'R' && couleur != 'O' & couleur != 'V');
            if (couleur == 'R')
            {
                Console.WriteLine("s'arreter");
            }
            else
            {
                if (couleur == 'O')
                {
                    Console.WriteLine("ralentir");
                }
                else
                {
                    Console.WriteLine("roulez");
                }
            }
            Console.ReadLine();
        }
    }
}
