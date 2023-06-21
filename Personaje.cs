using System.Text.Json;
using System.Text.Json.Serialization;
namespace Character;

public class Personaje
{
    ///////////////*CARACTERISTICAS*///////////////
    private int velocidad; //1 a 10
    private int destreza; //1 a 5
    private int fuerza; //1 a 10
    private int nivel; //1 a 10 
    private int armor; //1 a 10
    private int vida; //100

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Vida { get => vida; set => vida = value; }
    ///////////////*DATOS*///////////////
    private string? tipo;
    private string? name;
    private string? nick;
    private DateTime fdn;
    private int edad;//0 a 300

    public string? Tipo { get => tipo; set => tipo = value; }
    public string? Name { get => name; set => name = value; }
    public string? Nick { get => nick; set => nick = value; }
    public DateTime Fdn { get => fdn; set => fdn = value; }
    public int Edad { get => edad; set => edad = value; }

}

public class FabricaDePjs
{
    public Personaje CrearPj() {
        Personaje pj = new Personaje();
        Random rand = new Random();
        // Carga de Datos
        string[] Tipo = {"Caballero", "Barbaro", "Espadachin", "Guerrero", "Ninja", "Astuto",
        "Asesino", "Ladron", "Mago", "Guardabosque"}; 
        pj.Tipo = Tipo[rand.Next(0, 6)];
        string[] Name = {"Estaban", "Julian", "Jorge", "Jesus", "Jose", "Santiago", "Julieta", "Maria", "Carla", "Maia",
        "Jazmin", "Guillermo", "Sergio", "Rocio"};
        pj.Name = Name[rand.Next(0, 14)];
        string[] Nick = {"Iatele", "Nnsalei", "Oratharle", "Bleaahasa", "Phadanar", "Kel", "Fide", "Kylefier",
        "Uzo", "Wrau", "Variaisth"};
        pj.Name = Nick[rand.Next(0, 11)];
        string anioAct = DateTime.Now.ToString("yyyy");
        int anioA = 0;
        bool resul = int.TryParse(anioAct, out anioA);
        int dia;
        int mes = rand.Next(1,13);
        int anio = rand.Next(anioA - 300, anioA); 
        switch (mes)
        {
            case 2:
                dia = rand.Next(1,30);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                dia = rand.Next(1,31);
                break;
            default:
                dia = rand.Next(1,32);
                break;
        }
        pj.Fdn = new DateTime (anio, mes, dia);
        pj.Edad = anioA - anio;
        // Cargar Caracteristicas
        pj.Velocidad = rand.Next(1,11);
        pj.Destreza = rand.Next(1,6);
        pj.Fuerza = rand.Next(1,11);
        pj.Armor = rand.Next(1,11);
        pj.Nivel = rand.Next(1,11);
        pj.Vida = 100;
        return pj;
    }

    public class PersonajeJson
    {
        public void GuardarPj(List<Personaje> lista, string nombre) {
            //serializacion
            string Json = JsonSerializer.Serialize(aserializar);
            File.WriteAllText("personajes.json", Json);
        }
        public List<Personaje> LeerPj(string nombre) {
            List<Personaje>listPj;
            //deserializacion
            string jsonString =  File.ReadAllText("personajes.json");
            Personaje personajeDeserializado = JsonSerializer.Deserialize<Personaje>;
            return listPj;
        }

        public bool Existe(string nombre) {
            //verifico que exista el archivo
            return;
        }

    }

}