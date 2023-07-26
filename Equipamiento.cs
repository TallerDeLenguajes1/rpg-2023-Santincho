using Character;
namespace Equitment;

public class Equipamiento
{
    string[] Calidad = {"Comun", "Poco Comun", "Rara", "Epica", "Legendaria"};
    int Cal;
    Random rand = new Random();
    int randomizador;
    public Personaje MejoraArm(Personaje pj){
        int Error501 = rand.Next(0, 999999); 
        randomizador = rand.Next(1,101);
        if (randomizador <= 45)
        {
            Cal = 0;
        } else
        {
            if (randomizador <= 80)
            {
                Cal = 1;
            } else
            {
                if (randomizador <= 95)
                {
                    Cal = 2;
                } else
                {
                    if (randomizador <= 99)
                    {
                        Cal = 3;
                    } else
                    {
                        Cal = 4;
                    }
                }
            }
        }
        if (Error501 == 0)
        {
            Cal = 777;
        }
        if (pj.Arma < Cal)
        {
            string calidadArma = Calidad[Cal];
            if (pj.Tipo != "Mago" & pj.Tipo != "Guardabosque")
            {
                switch (pj.Arma)
                {
                    case 1:
                        pj.Fuerza -= 2;
                        break;
                    case 2:
                        pj.Fuerza -= 5;
                        break;
                    case 3:
                        pj.Fuerza -= 10;
                        break;
                    case 4:
                        pj.Fuerza -= 15;
                        pj.Destreza -= 5;
                        break;
                    case 5:
                        pj.Destreza -= 10;
                        pj.Fuerza -= 20;
                        break;
                }
                switch (calidadArma)
                {
                    case "Comun":
                        pj.Fuerza += 2;
                        pj.Arma = 1;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝔄 𝔟𝔯𝔢𝔞𝔡 𝔖𝔱𝔦𝔠𝔨\"");
                        break;
                    case "Poco Comun":
                        pj.Fuerza += 5;
                        pj.Arma = 2;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕬 𝕱𝖗𝖊𝖓𝖈𝖍 𝕭𝖗𝖊𝖆𝖉\"");
                        break;
                    case "Rara":
                        pj.Fuerza += 10;
                        pj.Arma = 3;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕬 𝕭𝖗𝖊𝖆𝖉 𝕾𝖜𝖔𝖗𝖉\"");
                        break;
                    case "Epica":
                        pj.Fuerza += 15;
                        pj.Destreza += 5;
                        pj.Arma = 4;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕿𝖍𝖊 𝕭𝖗𝖊𝖆𝖉𝖊𝖘𝖙\"");
                        break;
                    case "Legendaria":
                        pj.Destreza += 10;
                        pj.Fuerza += 20;
                        pj.Arma = 5;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕿𝖍𝖊 𝕿𝖔𝖆𝖘𝖙 𝕻𝖍𝖞𝖑𝖚𝖒\"");
                        break;
                }
            } else
            {
                switch (pj.Arma)
                {
                    case 1:
                        pj.PoderMagico -= 2;
                        break;
                    case 2:
                        pj.Fuerza -= 2;
                        pj.PoderMagico -= 5;
                        break;
                    case 3:
                        pj.Fuerza -= 5;
                        pj.PoderMagico -= 7;
                        break;
                    case 4:
                        pj.Fuerza -= 7;
                        pj.PoderMagico -= 15;
                        break;
                    case 5:
                        pj.Fuerza -= 10;
                        pj.PoderMagico -= 25;
                        break;
                }
                switch (calidadArma)
                {
                    case "Comun":
                        pj.PoderMagico += 2;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕬 𝕮𝖍𝖚𝖗𝖗𝖔\"");
                        break;
                    case "Poco Comun":
                        pj.Fuerza += 2;
                        pj.PoderMagico += 5;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕬 𝕳𝖆𝖑𝖋 𝕸𝖔𝖔𝖓\"");
                        break;
                    case "Rara":
                        pj.Fuerza += 5;
                        pj.PoderMagico += 7;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕬 𝕮𝖗𝖔𝖎𝖘𝖘𝖆𝖓𝖙\"");
                        break;
                    case "Epica":;
                        pj.Fuerza += 7;
                        pj.PoderMagico += 15;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕿𝖍𝖊 𝕮𝖗𝖔𝖎𝖘𝖘𝖆𝖓𝖙𝖊𝖘𝖙\"");
                        break;
                    case "Legendaria":
                        pj.Fuerza += 10;
                        pj.PoderMagico += 25;
                        Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 \"𝕿𝖍𝖊 𝕸𝖆𝖌𝖎𝖈 𝕿𝖔𝖆𝖘𝖙\"");
                        break;
                }
            }
            if (Cal == 777)
            {
                Console.WriteLine("????????");
                Console.WriteLine("𝔚𝔥𝔞𝔱... 𝔦𝔰 𝔱𝔥𝔦𝔰? ℌ𝔲𝔥");
                Console.WriteLine("𝔜𝔬𝔲 𝔤𝔬𝔱 ❞𝕿𝕳𝕰 𝕿𝕺𝕬𝕾𝕿𝕰𝕯❞");
                pj.Fuerza += 777;
                pj.PoderMagico += 777;
                pj.Destreza += 777;
                pj.Arma = 777;
            }
        } else
        {
            Console.WriteLine("𝕮𝖞𝖆 𝖑𝖆𝖙𝖊𝖗 𝖑𝖔𝖘𝖗, 𝖚 𝖉𝖌𝖘𝖍1𝖙 𝖜𝖊𝖆𝖕𝖔𝖓 𝕷𝕸𝕬𝕺");
        }
        return pj;
    }
}