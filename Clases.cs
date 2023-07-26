using Character;
namespace CharClass;

public class Tipos
{
    public Personaje Potenciador(Personaje pj){
        switch (pj.Tipo)
        {
            case "Caballero":
                pj.Armor += 20;
                pj.Fuerza += 5;
                break;
            case "Barbaro":
                pj.Armor += 5;
                pj.Fuerza += 20;
                break;
            case "Espadachin":
                pj.Destreza += 15;
                pj.Fuerza += 10;
                break;
            case "Guerrero":
                pj.Armor += 10;
                pj.Fuerza += 15;
                break;
            case "Ninja":
                pj.Destreza += 15;
                pj.Fuerza += 5;
                pj.Velocidad += 5;
                break;
            case "Astuto":
                pj.Destreza += 10;
                pj.Velocidad += 15;
                break;
            case "Asesino":
                pj.Destreza += 20;
                pj.Fuerza += 5;
                break;
            case "Ladron":
                pj.Destreza += 10;
                pj.Velocidad += 15;
                break;
            case "Mago":
                pj.PoderMagico += 20;
                pj.Nivel += 1;
                break;
            case "Guardabosque":
                pj.Destreza += 10;
                pj.Velocidad += 10;
                pj.PoderMagico += 5;
                break;
        }
        return pj;
    }
}