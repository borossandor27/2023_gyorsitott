using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_08_Lakopark
{
    internal class Lakopark
    {
        int lakoparkId;
        int maxHazSzam;
        string nev;
        int utcakSzama;
        int[,] hazak; // [utca száma, ház száma] = emelet száma
        Image[] hazKepek=new Image[4];

        public int MaxHazSzam { get => maxHazSzam; set => maxHazSzam = value; }
        public string Nev { get => nev; set => nev = value; }
        public int UtcakSzama { get => utcakSzama; set => utcakSzama = value; }
        public int[,] Hazak { get => hazak; set => hazak = value; }
        public int LakoparkId { get => lakoparkId; set => lakoparkId = value; }

        public Lakopark(int lakoparkId, string nev, int utcakSzama, int maxHazSzam)
        {
            LakoparkId = lakoparkId;
            Nev = nev;
            UtcakSzama = utcakSzama;
            MaxHazSzam = maxHazSzam;
            Hazak = new int[utcakSzama, maxHazSzam];
            hazKepek[0] = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}kereszt.jpg");
            hazKepek[1] = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz1.jpg");
            hazKepek[2] = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz2.jpg");
            hazKepek[3] = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Haz3.jpg");

        }
        public void hazEmeletszam(int utcaSzam, int hazSzam, int emelet)
        {
            Hazak[utcaSzam - 1, hazSzam - 1] = emelet;
        }
        public Image nevadoKepe()
        {
            Image nevado = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{this.Nev}.jpg");
            return nevado;
        }

        internal Image getHazKepe(int utcaSzam, int hazSzam)
        {
            return hazKepek[Hazak[utcaSzam - 1, hazSzam - 1]];
        }
        public void hazEmeletNovel(int utcaSzam, int hazSzam)
        {
            if (Hazak[utcaSzam - 1, hazSzam - 1] < 3)
            {
                Hazak[utcaSzam - 1, hazSzam - 1]++;
            }
            else
            {
                Hazak[utcaSzam - 1, hazSzam - 1] = 0;
            }
        }
    }
}
