using Character;
using Combat;
using Enemies;
using API;
Personaje nuevoPj;
Personaje pjPeleador = new Personaje();
FabricaDePjs fp = new FabricaDePjs();
List<Personaje> ListaPjs = new List<Personaje>();
PersonajesJson Json = new PersonajesJson();
var boredApiService = new BoredApiService();

Random rand = new Random();
int s = 1;
int selec = rand.Next(1,11);

Console.WriteLine("𝔊𝔢𝔫𝔢𝔯𝔞𝔱𝔢 𝔫𝔢𝔴 𝔭𝔧𝔰?");
Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 ❞𝕰𝖓𝖙𝖊𝖗❞ 𝖙𝖔 𝖌𝖊𝖓𝖊𝖗𝖆𝖙𝖊");
Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖔𝖙𝖍𝖊𝖗 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
var key = Console.ReadKey();

if (PersonajesJson.Existe("Personajes.Json"))
{
    ListaPjs = PersonajesJson.LeerPj("Personajes.json");
    if (key.Key == ConsoleKey.Enter)
    {
        for (int i = 0; i < 10; i++)
        {
        nuevoPj = fp.CrearPj();
        ListaPjs.Add(nuevoPj);
        }
        PersonajesJson.GuardarPj("Personajes.Json", ListaPjs);
    }
}
else
{
    for (int i = 0; i < 10; i++)
    {
    nuevoPj = fp.CrearPj();
    ListaPjs.Add(nuevoPj);
    }
    PersonajesJson.GuardarPj("Personajes.Json", ListaPjs);
}

Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
Console.WriteLine("█░░░░░░██████████░░░░░░█░░░░░░░░░░░░░░█░░░░░░█████████░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██████████░░░░░░█░░░░░░░░░░░░░░█████░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█");
Console.WriteLine("█░░▄▀░░██████████░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░█████████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░░░░░░░░░░░░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█");
Console.WriteLine("█░░▄▀░░██████████░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░█████████░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░░░░░░░░░█████░░░░░░▄▀░░░░░░█░░▄▀░░░░░░▄▀░░█");
Console.WriteLine("█░░▄▀░░██████████░░▄▀░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░░░░░▄▀░░█░░▄▀░░█████████████████░░▄▀░░█████░░▄▀░░██░░▄▀░░█");
Console.WriteLine("█░░▄▀░░██░░░░░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█████████░░▄▀░░█████░░▄▀░░██░░▄▀░░█");
Console.WriteLine("█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████████░░▄▀░░█████░░▄▀░░██░░▄▀░░█");
Console.WriteLine("█░░▄▀░░██░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░░░░░██░░▄▀░░█░░▄▀░░░░░░░░░░█████████░░▄▀░░█████░░▄▀░░██░░▄▀░░█");
Console.WriteLine("█░░▄▀░░░░░░▄▀░░░░░░▄▀░░█░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░█████████░░▄▀░░██░░▄▀░░█░░▄▀░░██████████░░▄▀░░█░░▄▀░░█████████████████░░▄▀░░█████░░▄▀░░██░░▄▀░░█");
Console.WriteLine("█░░▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░██████████░░▄▀░░█░░▄▀░░░░░░░░░░█████████░░▄▀░░█████░░▄▀░░░░░░▄▀░░█");
Console.WriteLine("█░░▄▀░░░░░░▄▀░░░░░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██████████░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█");
Console.WriteLine("█░░░░░░██░░░░░░██░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██████████░░░░░░█░░░░░░░░░░░░░░█████████░░░░░░█████░░░░░░░░░░░░░░█");
Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
Console.WriteLine("█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░████░░░░░░░░░░░░░░███░░░░░░██░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█");
Console.WriteLine("█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░████░░▄▀▄▀▄▀▄▀▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█");
Console.WriteLine("█░░░░░░▄▀░░░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█░░░░░░▄▀░░░░░░████░░▄▀░░░░░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█░░░░░░▄▀░░░░░░█");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████████░░▄▀░░████████░░▄▀░░██░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░█████████████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█████░░▄▀░░████████░░▄▀░░██░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░█████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░████████░░▄▀░░██░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░▄▀░░█░░░░░░░░░░▄▀░░█████░░▄▀░░████████░░▄▀░░██░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░░░░░░░░░█░░░░░░░░░░▄▀░░█████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░██░░▄▀░░█████████░░▄▀░░█████░░▄▀░░████████░░▄▀░░██░░▄▀░░███░░▄▀░░██░░▄▀░░█░░▄▀░░█████████████████░░▄▀░░█████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀░░░░░░▄▀░░█░░▄▀░░██░░▄▀░░█░░░░░░░░░░▄▀░░█████░░▄▀░░████████░░▄▀░░░░░░▄▀░░░░█░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█░░░░░░░░░░▄▀░░█████░░▄▀░░█████");
Console.WriteLine("█████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░████████░░▄▀▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█████░░▄▀░░█████");
Console.WriteLine("█████░░░░░░█████░░░░░░░░░░░░░░█░░░░░░██░░░░░░█░░░░░░░░░░░░░░█████░░░░░░████████░░░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█████░░░░░░█████");
Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████");
Thread.Sleep(2000);
Console.Clear();
Thread.Sleep(1000);

Procesamiento proce = new Procesamiento();
Personaje pj = new Personaje();
pjPeleador = proce.GetPj(ListaPjs, s, selec);
Console.WriteLine("𝖄𝖔𝖚𝖗 𝖋𝖎𝖌𝖍𝖙𝖊𝖗 𝖎𝖘...");
pj.MostrarPj(pjPeleador);
Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("𝕾𝖔𝖒𝖊𝖙𝖍𝖎𝖓𝖌 𝖎𝖘 𝖍𝖆𝖕𝖕𝖊𝖓𝖎𝖓𝖌...");
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("𝕴 𝖒𝖎𝖌𝖍𝖙 𝖋𝖎𝖌𝖍𝖙...");
Thread.Sleep(1000);
Console.Clear();

Console.WriteLine("千讠Ꮆ卄七");
Thread.Sleep(1500);
Console.Clear();

Enemigo enemigo;
FabricaDeEnemigos fe = new FabricaDeEnemigos();
bool final = false;
int n = 1, turno;
int lectura;
do
{
    switch (n)
    {
        case 3:
            enemigo = fe.CrearJefe(n);
            break;
        case 6:
            enemigo = fe.CrearJefe(n);
            break;
        case 9:
            enemigo = fe.CrearJefe(n);
            break;
        case 10:
            enemigo = fe.CrearJefe(n);
            break;
        default:
            enemigo = fe.CrearEnemigo(n);
            break;
    }
    do
    {
        turno = 1;
        do
        {
            Console.Clear();
            Console.WriteLine("ℭ𝔬𝔪𝔟𝔞𝔱 𝔑°", + n);
            Console.WriteLine("-----𝓒𝓸𝓶𝓫𝓪𝓽-----");
            Console.WriteLine("-----𝓒𝓱𝓸𝓸𝓼𝓮 𝔂𝓸𝓾𝓻 𝓶𝓸𝓿𝓮-----");
            Console.WriteLine("|  (𝟙) 𝔹𝕒𝕤𝕚𝕔   |   |  (𝟚) 𝕊𝕡𝕖𝕔𝕚𝕒𝕝   |");
            Console.WriteLine("| (𝟛) 𝕌𝕝𝕥𝕚𝕞𝕒𝕥𝕖 |   | (𝟜) 𝔻𝕖𝕗𝕖𝕟𝕤𝕖   |");
        } while (int.TryParse(Console.ReadLine(), out lectura) & lectura > 4);
        Console.WriteLine("Vida enemigo: " + enemigo.Vida);
        switch (lectura)
        {
            case 1:
                enemigo.Vida -= proce.Daño(enemigo, pjPeleador, turno);
                Console.WriteLine("Damage" + proce.Daño(enemigo, pjPeleador, turno));
                break;
            case 2:
                enemigo.Vida -= proce.Daño(enemigo, pjPeleador, turno) * (3/2);
                break;
            case 3:
                enemigo.Vida -= proce.Daño(enemigo, pjPeleador, turno) * 4;
                break;
            case 4:
                pjPeleador.Armor += 10;
                break;
        }
        Console.WriteLine("Vida enemigo: " + enemigo.Vida);
        if (enemigo.Vida > 0)
        {
            turno = 2;
            pjPeleador.Vida -= proce.Daño(enemigo, pjPeleador, turno);
        }
        if (lectura == 4)
        {
            pjPeleador.Armor -= 10;
        }
    } while (pjPeleador.Vida > 0 & enemigo.Vida > 0);
    if (enemigo.Vida <= 0)
    {
        var randomActivity = await boredApiService.GetRandomActivityAsync();
        Console.WriteLine("𝕴❜𝖒 𝖏𝖚𝖘𝖙 𝖆 𝖈𝖍𝖆𝖗𝖌𝖎𝖓𝖌 𝖘𝖈𝖗𝖊𝖊𝖓...");
        Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
        Console.WriteLine($"Something you can do if u want: {randomActivity}");
        Console.ReadKey();
    }
    n++;
} while (pjPeleador.Vida > 0 & !final);