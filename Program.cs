namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : faire un compteur qui va de 1 à 10

        int compteur;
        for (compteur = 1; compteur <= 10; compteur++)
        {
            Console.WriteLine(compteur);
        }
        
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"

        int decompte;
        for (decompte = 5; decompte >= 1; decompte--)
        {
            Console.WriteLine(decompte);
        }
        Console.WriteLine("Bonne Année");
        
        // Etape 3 : faire un compteur qui va de -4 à 2

        for (compteur = -4; compteur <= 2; compteur++)
        {
            Console.WriteLine(compteur);
        }
        
        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15

        for (compteur = 0; compteur <= 15; compteur += 2)
        {
            Console.WriteLine(compteur);
        }

        compteur--;
        Console.WriteLine(compteur);
        
        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        do
        {
            Console.WriteLine("Dis oui");
        } while (Console.ReadLine() != "oui");

        Console.WriteLine("Tu as dis oui");
        
        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}