using System;
using System.Threading.Channels;

namespace nombre_magique
{
    class Program
    {
        // Demander nombre -> Toute la fonction 
        // Afficher : Rentrez un nombre

        // tester si ce nombre est valide
        // reboucer tant que le nombre n'est pas validé
        // considérer que 0 est invalide
        // retourner la valeur (int)

        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Rentrez un nombre : ");
            string str_num = Console.ReadLine();
            num = int.Parse(str_num);
            Console.WriteLine("ton nombre est bien le " + num);
        }





    }
}