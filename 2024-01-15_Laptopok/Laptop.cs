using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_01_15_Laptopok
{
    internal class Laptop
    {
        long laptopid;
        string marka;
        string model;
        string szin;
        string processzor;
        string felbontas;
        int memoria;
        int kepernyomeret;
        int merevlemezkapacitas;
        int ar;

        public long Laptopid { get => laptopid; set => laptopid = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public string Szin { get => szin; set => szin = value; }
        public string Processzor { get => processzor; set => processzor = value; }
        public string Felbontas { get => felbontas; set => felbontas = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public int Kepernyomeret { get => kepernyomeret; set => kepernyomeret = value; }
        public int Merevlemezkapacitas { get => merevlemezkapacitas; set => merevlemezkapacitas = value; }
        public int Ar { get => ar; set => ar = value; }

        public Laptop(long laptopid, string marka, string model, string szin, string processzor, string felbontas, int memoria, int kepernyomeret, int merevlemezkapacitas, int ar)
        {
            Laptopid = laptopid;
            Marka = marka;
            Model = model;
            Szin = szin;
            Processzor = processzor;
            Felbontas = felbontas;
            Memoria = memoria;
            Kepernyomeret = kepernyomeret;
            Merevlemezkapacitas = merevlemezkapacitas;
            Ar = ar;
        }

        public Laptop()
        {
        }

        public override string ToString()
        {
            return $"{this.marka} {this.Model} ({this.ar})";
        }
    }
}
