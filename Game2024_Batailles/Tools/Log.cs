using Game2024_Batailles.Cartes;

namespace Game2024_Batailles.Tools;

static class Log
{
    const string FILENAME = "result.txt";

    static Log()
    {
        File.CreateText(FILENAME).Dispose();
    }

    public static void Display(Carte carteJ1, Carte carteJ2)
    {
        string text = $"{((carteJ1.Valeur is Valeurs.Joker) ? "Joker" : $"{carteJ1.Valeur} de {carteJ1.Couleur}")} vs {((carteJ2.Valeur is Valeurs.Joker) ? "Joker" : $"{carteJ2.Valeur} de {carteJ2.Couleur}")}{Environment.NewLine}";
        Console.Write(text);
        File.AppendAllText(FILENAME, text);
    }

    public static void Display(string message)
    {
        Console.WriteLine(message);
        File.AppendAllText(FILENAME, $"{message}{Environment.NewLine}");
    }
}
