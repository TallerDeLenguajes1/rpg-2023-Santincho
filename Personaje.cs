using System.Text.Json;
using System.Text.Json.Serialization;
using CharClass;
namespace Character;

public class Personaje
{
    ///////////////*CARACTERISTICAS*///////////////
    private int velocidad; //1 a 10
    private int destreza; //1 a 5
    private int fuerza; //1 a 10
    private int poderMagico; //0
    private int nivel; //1 a 10 
    private int armor; //1 a 10
    private int arma; //0 a 5 (depende del arma)
    private int vida; //100
    private int cargas;

    public int Velocidad { get => velocidad; set => velocidad = value; }
    public int Destreza { get => destreza; set => destreza = value; }
    public int Fuerza { get => fuerza; set => fuerza = value; }
    public int PoderMagico { get => poderMagico; set => poderMagico = value; }
    public int Nivel { get => nivel; set => nivel = value; }
    public int Armor { get => armor; set => armor = value; }
    public int Arma { get => arma; set => arma = value; }
    public int Vida { get => vida; set => vida = value; }
    public int Cargas { get => cargas; set => cargas = value; }

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

    public void MostrarPj(Personaje pj)
    {
        Console.WriteLine("ℂ𝕙𝕒𝕣𝕒𝕔𝕥𝕖𝕣 𝕀𝕟𝕗𝕠");
        Console.WriteLine("𝕹𝖆𝖒𝖊: "+pj.Name);
        Console.WriteLine("𝕿𝖞𝖕𝖊: "+pj.Tipo);
        Console.WriteLine("𝕬𝖌𝖊: "+pj.Edad);
        Console.WriteLine("ℂ𝕒𝕣𝕒𝕔𝕥𝕖𝕣𝕚𝕤𝕥𝕚𝕔𝕤");
        Console.WriteLine("𝕾𝖙𝖗𝖊𝖓𝖌𝖙𝖍: "+pj.Fuerza);
        Console.WriteLine("𝕽𝖊𝖘𝖎𝖘𝖙𝖊𝖓𝖈𝖊: "+pj.Armor);
        Console.WriteLine("𝕷𝖊𝖛𝖊𝖑: "+pj.Nivel);
        Console.WriteLine("𝕸𝖆𝖌𝖎𝖈𝖆𝖑 𝕻𝖔𝖜𝖊𝖗: "+pj.PoderMagico);
    }
}

public class FabricaDePjs
{
    public Personaje CrearPj() 
    {
        Personaje pj = new Personaje();
        Random rand = new Random();
        Tipos poten = new Tipos();
        // Carga de Datos
        string[] Tipo = {"Caballero", "Barbaro", "Espadachin", "Guerrero", "Ninja", "Astuto",
        "Asesino", "Ladron", "Mago", "Guardabosque"}; 
        pj.Tipo = Tipo[rand.Next(0, 6)];
        string[] Name = {"Estaban", "Julian", "Jorge", "Jesus", "Jose", "Santiago", "Julieta", "Maria", "Carla", "Maia",
        "Jazmin", "Guillermo", "Sergio", "Rocio"};
        pj.Name = Name[rand.Next(0, 14)];
        string[] Nick = {"Iatele", "Nnsalei", "Oratharle", "Bleaahasa", "Phadanar", "Kel", "Fide", "Kylefier",
        "Uzo", "Wrau", "Variaisth"};
        pj.Name = Name[rand.Next(0, 14)];
        pj.Nick = Nick[rand.Next(0,11)];
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
        pj.Fuerza = rand.Next(5,11);
        pj.PoderMagico = rand.Next(1,6);
        pj.Armor = rand.Next(1,11);
        pj.Arma = 0;
        pj.Nivel = rand.Next(1,11);
        pj.Vida = 100;
        pj.Cargas = 0;
        poten.Potenciador(pj);
        return pj;
    }

}

public class PersonajesJson
{
    static public void GuardarPj(string nombreArchivo,List<Personaje> Lista)
    {
        String Json = JsonSerializer.Serialize(Lista);
        File.WriteAllText(nombreArchivo, Json);
    }
    static public List<Personaje> LeerPj(string NombreArchivo){
        var ListadoPersonajes = new List<Personaje>();

        string TextoJson = File.ReadAllText(NombreArchivo);

        if (!string.IsNullOrEmpty(TextoJson))
        {
            ListadoPersonajes = JsonSerializer.Deserialize<List<Personaje>>(TextoJson)!;
        }
        
        return ListadoPersonajes;
    }
    static public bool Existe(string NombreArchivo)
    {
        if (File.Exists(NombreArchivo))
        {
            var InfoArchivo = new FileInfo(NombreArchivo);

            if (InfoArchivo.Length>0)
            {
                return true;
            }else
            {
                return false;
            }
        }else
        {
            return false;
        }
    }
}