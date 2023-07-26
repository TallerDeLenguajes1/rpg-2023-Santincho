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
            daño = (pj.Destreza * pj.Fuerza * pj.Nivel + pj.PoderMagico - enem.Armor * enem.Velocidad);
        } else
        {
            daño = (enem.Destreza * enem.Fuerza * enem.Nivel + enem.PoderMagico - pj.Armor * pj.Velocidad)/500;
        }
        if (daño < 0)
        {
            daño = 0;
        }
        return daño;
    }
}