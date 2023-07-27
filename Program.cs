using Character;
using Combat;
using Enemies;
using API;
using Equitment;
Personaje nuevoPj, pjPeleador;
Equipamiento arma = new Equipamiento();
FabricaDePjs fp = new FabricaDePjs();
List<Personaje> ListaPjs = new List<Personaje>();
PersonajesJson Json = new PersonajesJson();
var boredApiService = new BoredApiService();

Random rand = new Random();
int s = 1;
int selec = rand.Next(1,11);
Console.Clear();
Console.WriteLine("𝔊𝔢𝔫𝔢𝔯𝔞𝔱𝔢 𝔫𝔢𝔴 𝔭𝔧𝔰?");
Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 ❞1❞ 𝖙𝖔 𝖌𝖊𝖓𝖊𝖗𝖆𝖙𝖊");
Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖔𝖙𝖍𝖊𝖗 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
int key;
int.TryParse(Console.ReadLine(), out key);

if (PersonajesJson.Existe("Personajes.Json"))
{
    ListaPjs = PersonajesJson.LeerPj("Personajes.json");
    if (key == 1)
    {
        ListaPjs.Clear();
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
int n = 1, turno;
int lectura;
bool lec;
int daño;
int encontrar;
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
        daño = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("ℭ𝔬𝔪𝔟𝔞𝔱 𝔑° " + n);
            Console.WriteLine("-----𝓒𝓸𝓶𝓫𝓪𝓽-----");
            proce.VidaPj(pjPeleador.Vida);
            Console.WriteLine("          "+ pjPeleador.Vida + "/100");
            proce.Cargas(pjPeleador.Cargas);
            Console.WriteLine("Charges: " + pjPeleador.Cargas + "/3");
            Console.WriteLine("-----𝓒𝓱𝓸𝓸𝓼𝓮 𝔂𝓸𝓾𝓻 𝓶𝓸𝓿𝓮-----");
            Console.WriteLine("|  (𝟙) 𝔹𝕒𝕤𝕚𝕔   |   |  (𝟚) 𝕊𝕡𝕖𝕔𝕚𝕒𝕝   |");
            Console.WriteLine("| (𝟛) 𝕌𝕝𝕥𝕚𝕞𝕒𝕥𝕖 |   | (𝟜) 𝔻𝕖𝕗𝕖𝕟𝕤𝕖   |");
            lec = int.TryParse(Console.ReadLine(), out lectura);
            if (lectura == 2 & pjPeleador.Cargas < 1)
            {
                Console.WriteLine("𝖄𝖔𝖚 𝖓𝖊𝖊𝖉 1 𝖈𝖍𝖆𝖗𝖌𝖊 𝖋𝖔𝖗 𝖙𝖍𝖎𝖘");
                Thread.Sleep(1500);
                lec = false;
            }
            if (lectura == 3 & pjPeleador.Cargas < 3)
            {
                Console.WriteLine("𝖄𝖔𝖚 𝖓𝖊𝖊𝖉 3 𝖈𝖍𝖆𝖗𝖌𝖊𝖘 𝖋𝖔𝖗 𝖙𝖍𝖎𝖘");
                Thread.Sleep(1500);
                lec = false;
            }
        } while (!lec & lectura <= 4);
        switch (lectura)
        {
            case 1:
                daño = proce.Daño(enemigo, pjPeleador, turno);
                Console.WriteLine("Damage: " + daño);
                if (pjPeleador.Cargas < 3)
                {
                    pjPeleador.Cargas++;
                }
                break;
            case 2:
                daño = proce.Daño(enemigo, pjPeleador, turno) * (3/2);
                Console.WriteLine("Damage: " + daño);
                pjPeleador.Cargas--;
                break;
            case 3:
                daño = proce.Daño(enemigo, pjPeleador, turno) * 5;
                Console.WriteLine("Damage: " + daño);
                pjPeleador.Cargas -= 3;
                break;
            case 4:
                pjPeleador.Armor += 10;
                Console.WriteLine("Armor +10");
                break;
        }
        enemigo.Vida -= daño;
        Console.WriteLine("Enemie health: " + enemigo.Vida);
        if (enemigo.Vida > 0)
        {
            turno = 2;
            daño = proce.Daño(enemigo, pjPeleador, turno);
            Console.WriteLine("Damage taken: " + daño);
        }
        pjPeleador.Vida -= daño;
        if (lectura == 4)
        {
            pjPeleador.Armor -= 10;
        }
        Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
        Console.ReadKey();
    } while (pjPeleador.Vida > 0 & enemigo.Vida > 0);
    if (enemigo.Vida <= 0)
    {
        n++;
        pjPeleador.Vida = 100;
        pjPeleador.Nivel += rand.Next(1,4);
        var randomActivity = await boredApiService.GetRandomActivityAsync();
        Console.WriteLine("𝕴❜𝖒 𝖏𝖚𝖘𝖙 𝖆 𝖈𝖍𝖆𝖗𝖌𝖎𝖓𝖌 𝖘𝖈𝖗𝖊𝖊𝖓...");
        Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
        Console.WriteLine($"Something you can do if u want: {randomActivity}");
        Console.ReadKey();
        encontrar = rand.Next(1,3);
        if (encontrar == 1)
        {
            Console.WriteLine("𝖄𝖔𝖚 𝖋𝖔𝖚𝖓𝖉 𝖘𝖔𝖒𝖊𝖙𝖍𝖎𝖓𝖌...");
            arma.MejoraArm(pjPeleador);
            Console.WriteLine("𝕻𝖗𝖊𝖘𝖘 𝖆𝖓𝖞 𝖐𝖊𝖞 𝖙𝖔 𝖈𝖔𝖓𝖙𝖎𝖓𝖚𝖊...");
            Console.ReadKey();
        }
    }
} while (pjPeleador.Vida > 0 & n != 10);
Console.Clear();
if (pjPeleador.Vida > 0)
{
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░█▄");
    Console.WriteLine("░▄▄▄▄▄▄░░░░░░░░░░░░░▄▄▄▄▄░░█▄");
    Console.WriteLine("░▀▀▀▀▀███▄░░░░░░░▄███▀▀▀▀░░░█▄");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
    Console.WriteLine("░▄▀▀▀▀▀▄░░░░░░░░░░▄▀▀▀▀▀▄░░░░█");
    Console.WriteLine("█▄████▄░▀▄░░░░░░▄█░▄████▄▀▄░░█▄");
    Console.WriteLine("████▀▀██░▀▄░░░░▄▀▄██▀█▄▄█░█▄░░█");
    Console.WriteLine("██▀██████░█░░░░█░████▀█▀██░█░░█");
    Console.WriteLine("████▀▄▀█▀░█░░░░█░█████▄██▀▄▀░░█");
    Console.WriteLine("███████▀░█░░░░░░█░█████▀░▄▀░░░█");
    Console.WriteLine("░▀▄▄▄▄▄▀▀░░░░░░░░▀▀▄▄▄▄▀▀░░░░░█");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
    Console.WriteLine("░░▓▓▓▓▓▓▓░░░░░░░░░░▓▓▓▓▓▓▓░░░░█");
    Console.WriteLine("░░░▓▓▓▓▓░░░░░░░░░░░░▓▓▓▓▓░░░░░█");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█▀");
    Console.WriteLine("░░░░░░░░░▄▄███████▄▄░░░░░░░░░█");
    Console.WriteLine("░░░░░░░░█████████████░░░░░░░█▀");
    Console.WriteLine("░░░░░░░░░▀█████████▀░░░░░░░█▀");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░█▀");
    Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░█▀");    
    Console.WriteLine("█▄─█─▄█─▄▄─█▄─██─▄███─▄─▄─█─▄▄─██▀▄─██─▄▄▄▄█─▄─▄─███─▄─▄─█─█─█▄─▄▄─███▄─▄▄▀█─▄▄─██▀▄─██▄─▄▄▀█");
    Console.WriteLine("██▄─▄██─██─██─██─██████─███─██─██─▀─██▄▄▄▄─███─███████─███─▄─██─▄█▀████─▄─▄█─██─██─▀─███─██─█");
    Console.WriteLine("▀▀▄▄▄▀▀▄▄▄▄▀▀▄▄▄▄▀▀▀▀▀▄▄▄▀▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▀▀▄▄▄▀▀▄▀▄▀▄▄▄▄▄▀▀▀▄▄▀▄▄▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▀▀");
} else
{   
    Console.WriteLine("工丂 讠〸 セ卄🝗 🝗𝓝ᗪ?...");
    Thread.Sleep(2000);
    Console.Clear();
    Console.WriteLine("█▬█ ▞▚ █▬█ ▞▚  ▚▘ ██ ▙▟  ▜▛ 🆁 ▞▚ ▟▛ █▬█ ");
}