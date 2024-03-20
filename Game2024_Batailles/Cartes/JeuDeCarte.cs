using System.Text;
using Game2024_Batailles.Bataille;

namespace Game2024_Batailles.Cartes;

struct JeuDeCarte
{
    private readonly List<Carte> _cartes;

    public JeuDeCarte()
    {
        _cartes = new List<Carte>();
        //Ajout des cartes
        for (int i = 0; i < 52; i++)
        {
            _cartes.Add(new Carte() { Couleur = (Couleurs)(i / 13), Valeur = (Valeurs)((i % 13) + 2) });
        }

        //Ajout d'un Joker
        _cartes.Add(new Carte() { Couleur = Couleurs.None, Valeur = Valeurs.Joker });
    }

    public Partie CreePartieDeBataille()
    {
        Queue<Carte> cartesJ1 = new Queue<Carte>();
        Queue<Carte> cartesJ2 = new Queue<Carte>();

        bool estJoueur1 = true;
        while (_cartes.Count > 0)
        {
            int rand = Random.Shared.Next(_cartes.Count);
            (estJoueur1 ? cartesJ1 : cartesJ2).Enqueue(_cartes[rand]);
            _cartes.Remove(_cartes[rand]);
            estJoueur1 = !estJoueur1;
        }

        return new Partie(cartesJ1, cartesJ2);
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        foreach (Carte carte in _cartes)
        {
            stringBuilder.AppendLine($"{(carte.Valeur is Valeurs.Joker ? "Joker" : $"{carte.Valeur} de {carte.Couleur}")}");
        }

        return stringBuilder.ToString();
    }
}
