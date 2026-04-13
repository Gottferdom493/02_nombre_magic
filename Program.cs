using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre()
        {
            // tester si ce nombre est valide entre pas
            // reboucler tant que le nombre n'est pas validé
            int num = 0;
            int num_min = 0;
            int num_max = 0;

            while (num <= 0)
            {

                Console.WriteLine();
                Console.Write("Choisiser le nombre min : ");
                string str_num_min = Console.ReadLine();
                num_min = int.Parse(str_num_min);
                Console.WriteLine("tu as choisi le nombre " + num_min);

                Console.WriteLine();
                Console.Write("Choisiser le nombre max : ");
                string str_num_max = Console.ReadLine();
                num_max = int.Parse(str_num_max);
                Console.WriteLine("tu as choisi le nombre " + num_max);

                // Afficher : Rentrez un nombre
                Console.WriteLine();
                Console.Write("Rentrez votre un nombre : ");
                string str_num = Console.ReadLine();
                num = int.Parse(str_num);
                Console.WriteLine("tu as choisi le nombre " + num);

                try
                {

                    //num_min = int.Parse(str_num_min);
                    //num_max = int.Parse(str_num_max);
                    
                    // Identifie le string en en Integer et donc peut etre une condition pour suprimer les strings
                    num = int.Parse(str_num);

                    // Considérer que 0 est invalide
                    if ((num == 0) || (num_min == 0) || (num_max == 0))
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser le 0 ");
                    }
                    else if (num_min > num_max)
                    {
                        Console.WriteLine("Erreur : Ton nombre min est plus grand que le max ");
                    }
                    else if ((num < 0) || (num_min < 0) || (num_max < 0))
                    {
                        Console.WriteLine("Erreur : Tu ne peux pas utiliser de nombre négatif ");
                    }
                    else if (num > num_max)
                    {
                        Console.WriteLine("Erreur : Tu es au dessus de la valeur " + num_max);
                    }
                    else if (num < num_min)
                    {
                        Console.WriteLine("Erreur : Tu es en dessous de la valeur " + num_min);
                    }
                    else // retourner la valeur validé (int)
                    {
                        Console.WriteLine("Ton nombre est valide " + num);
                    }
                }

                catch
                {
                    Console.WriteLine("Tu n'a pas écri de nombre mais : " + num);                    
                }
            }
            return num;


        }
        static void Main(string[] args)
        {
           int num = DemanderNombre();  
        }
    }
}