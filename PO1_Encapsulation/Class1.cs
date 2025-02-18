using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    internal class Personnage
    {
        int pointDeVie;
        int puissanceAttaque;
        int pointDeVieMaximal;
    
        public int PointDeVie
        {
            get => PointDeVie1; set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > PointDeVieMaximal)
                {
                    PointDeVie1 = PointDeVieMaximal;
                }
                else
                {
                    PointDeVie1 = value;
                }

            }
        }
                
        public int PuissanceAttaque { get => PuissanceAttaque; set { PuissanceAttaque = value; } }

        public bool EstMort
        {
            get
            {
                if (PointDeVie1 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public int PointDeVie1 { get => PointDeVie2; set => PointDeVie2 = value; }
        public int PuissanceAttaque1 { get => PuissanceAttaque2; set => PuissanceAttaque2 = value; }
        public int PointDeVieMaximal { get => PointDeVieMaximal1; set => PointDeVieMaximal1 = value; }
        public int PointDeVie2 { get => pointDeVie; set => pointDeVie = value; }
        public int PuissanceAttaque2 { get => puissanceAttaque; set => puissanceAttaque = value; }
        public int PointDeVieMaximal1 { get => pointDeVieMaximal; set => pointDeVieMaximal = value; }

        public override bool Equals(object? obj)
        {
            return obj is Personnage personnage &&
                   PointDeVie2 == personnage.PointDeVie2 &&
                   PuissanceAttaque2 == personnage.PuissanceAttaque2 &&
                   PointDeVieMaximal1 == personnage.PointDeVieMaximal1;
        }
    }

}
