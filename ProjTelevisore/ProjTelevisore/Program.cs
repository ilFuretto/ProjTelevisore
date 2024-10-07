using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjTelevisore;

namespace ProjTelevisore
{
    class Televisore
    {
        private string Marca;
        private string Modello;
        private int Consumo;
        private int Dimensione;
        private int Prezzo;
        private bool Stato;
        private int CanaleCorrente;
        private int VolumeCorrente;

        public Televisore(string marca, string modello, int consumo, int dimensione, int prezzo)
        {
            Marca = marca;
            Modello = modello;
            Consumo = consumo;
            Dimensione = dimensione;
            Prezzo = prezzo;
            Stato = false;
            CanaleCorrente = 1;
            VolumeCorrente = 0;
        }

        public void Accendi()
        {
            Stato = true;
            Console.WriteLine("Televisore acceso.");
        }

        public void Spegni()
        {
            Stato = false;
            Console.WriteLine("Televisore spento.");
        }

        public void CambiaCanale(int nuovoCanale)
        {
            if (Stato)
            {
                CanaleCorrente = nuovoCanale;
                Console.WriteLine("Canale cambiato a " + CanaleCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void AumentaDiminuisciCanale(int incremento)
        {
            if (Stato)
            {
                CanaleCorrente += incremento;
                Console.WriteLine("Canale cambiato a " + CanaleCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void AlzaAbbassaVolume(int incremento)
        {
            if (Stato)
            {
                VolumeCorrente += incremento;
                Console.WriteLine("Volume cambiato a " + VolumeCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void CambiaVolume(int nuovoVolume)
        {
            if (Stato)
            {
                VolumeCorrente = nuovoVolume;
                Console.WriteLine("Volume cambiato a " + VolumeCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }
        public int GetCanaleCorrente()
        {
            return CanaleCorrente;
        }

        public int GetVolumeCorrente()
        {
            return VolumeCorrente;
        }

        public bool GetAcceso()
        {
            return Stato;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Televisore s1 = new Televisore("Marca1", "Modello1", 100, 37, 300);
            Televisore s2 = new Televisore("Marca2", "Modello2", 120, 51, 500);

            Console.WriteLine("Tv s1:");
            s1.Accendi();
            s1.CambiaCanale(5);
            s1.CambiaVolume(3);

            Console.WriteLine("Tv s2:");
            s2.Accendi();
            s2.CambiaCanale(10);
            s2.CambiaVolume(10);

            Console.WriteLine("Televisore s1: Canale " + s1.GetCanaleCorrente() + ", Volume " + s1.GetVolumeCorrente());
            Console.WriteLine("Televisore s2: Canale " + s2.GetCanaleCorrente() + ", Volume " + s2.GetVolumeCorrente());

            Console.ReadLine();
        }
    }
}