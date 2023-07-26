using Character;
using Enemies;
namespace Combat;
public class Procesamiento
{
    public Personaje GetPj(List<Personaje> Listapj, int s, int selec)
    {
        Personaje pjBuscado = new Personaje();
        foreach (var item in Listapj)
        {
            if (s == selec)
            {
                pjBuscado = item;
            }
            s++;
        }
        return pjBuscado;
    } 
    public int Daño(Enemigo enem, Personaje pj, int quien)
    {
        int daño;
        if (quien == 1)
        {
            daño = (pj.Destreza * pj.Fuerza * pj.Nivel - enem.Armor * enem.Velocidad)/200 + pj.PoderMagico;
        } else
        {
            daño = (enem.Destreza * enem.Fuerza * enem.Nivel - pj.Armor * pj.Velocidad)/500 + enem.PoderMagico;
        }
        if (daño < 0)
        {
            daño = 0;
        }
        return daño;
    }
    public void VidaPj(int vida)
    {
        if (vida > 75)
        {
            Console.WriteLine("𝕳𝖊𝖆𝖑𝖙𝖍: |█|█|█|█|");
        } else
        {
            if (vida > 50)
            {
                Console.WriteLine("𝕳𝖊𝖆𝖑𝖙𝖍: |█|█|█|░|");
            } else
            {
                if (vida > 25)
                {
                    Console.WriteLine("𝕳𝖊𝖆𝖑𝖙𝖍: |█|█|░|░|");
                } else
                {
                    Console.WriteLine("𝕳𝖊𝖆𝖑𝖙𝖍: *̸͎̫̙͋͑̚*̸̢͎͕͌͋͘*̸̙̪̻͒͐͒*̸͔͇͍͑̔͘*̸̡̙͕̔͒*̴̡̝͍̔̕͠*̴̫̪͓̾̾̚");
                }
            }
        }
    }
    public void Cargas(int cargas)
    {
        switch (cargas)
        {
            case 0:
                Console.WriteLine("𝕮𝖍𝖆𝖗𝖌𝖊𝖘: ( ⓞ / ⓞ / ⓞ )");
                break;
            case 1:
                Console.WriteLine("𝕮𝖍𝖆𝖗𝖌𝖊𝖘: ( 🅞 / ⓞ / ⓞ )");
                break;
            case 2:
                Console.WriteLine("𝕮𝖍𝖆𝖗𝖌𝖊𝖘: ( 🅞 / 🅞 / ⓞ )");
                break;
            case 3:
                Console.WriteLine("𝕮𝖍𝖆𝖗𝖌𝖊𝖘: ( 🅞 / 🅞 / 🅞 )");
                break;
        }
    }
}