using Game2024_Batailles.Bataille;
using Game2024_Batailles.Cartes;
using Game2024_Batailles.Tools;

namespace Game2024_Batailles;

internal class Program
{
    static void Main(string[] args)
    {
        JeuDeCarte jeu = new JeuDeCarte();
        Log.Display(jeu.ToString());
        Partie partie = jeu.CreePartieDeBataille();
        partie.Demarrer();
    }
}