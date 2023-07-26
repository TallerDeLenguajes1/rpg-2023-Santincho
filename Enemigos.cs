using System.Text.Json;
using System.Text.Json.Serialization;
namespace Enemies;
public class Enemigo
{
    ///////////////*CARACTERISTICAS*///////////////
    private int velocidad; //1 a 10
    private int destreza; //1 a 5
    private int fuerza; //1 a 10
    private int poderMagico; //0
    private int nivel; //1 a 10 
    private int armor; //1 a 10
    private int vida; //100

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int PoderMagico { get => poderMagico; set => poderMagico = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Vida { get => vida; set => vida = value; }
    ///////////////*DATOS*///////////////
}

public class FabricaDeEnemigos
{
    public Enemigo CrearEnemigo(int nivel) {
        Enemigo enemigo = new Enemigo();
        Random rand = new Random();
        // Cargar Caracteristicas
        enemigo.Velocidad = rand.Next(1,6);
        enemigo.Destreza = rand.Next(1,6);
        enemigo.Fuerza = rand.Next(1,11);
        enemigo.PoderMagico = rand.Next(1,6);
        enemigo.Armor = rand.Next(1,6);
        enemigo.Nivel = nivel;
        enemigo.Vida = 50 * nivel;
        return enemigo;
    }

    public Enemigo CrearJefe(int nivel) {
        Enemigo jefe = new Enemigo();
        Random rand = new Random();
        // Cargar Caracteristicas
        jefe.Velocidad = rand.Next(1,6);
        jefe.Destreza = rand.Next(5,11);
        jefe.Fuerza = rand.Next(10,21);
        jefe.PoderMagico = rand.Next(5,16);
        jefe.Armor = rand.Next(1,11);
        jefe.Nivel = nivel;
        jefe.Vida = 500 * nivel/3;
        return jefe;
    }

}