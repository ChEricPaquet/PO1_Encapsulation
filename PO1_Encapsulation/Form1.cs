namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;
        public Form1()
        {
            InitializeComponent();
            joueur = new Personnage();
            joueur.PointDeVieMaximal = 10;
            joueur.PointDeVie = 10;
            joueur.PuissanceAttaque = 1;
            
            
            monstre = new Personnage();
            monstre.PointDeVieMaximal = 30;
            monstre.PointDeVie = 30;
            monstre.PuissanceAttaque = 3;
           

            lbl_pointsVieJoueur.Text = "Point de vie " + joueur.PointDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque " + joueur.PuissanceAttaque;
            lbl_pointsVieDragon.Text = "Point de vie " + monstre.PointDeVie;
            lbl_puissanceAttaqueDragon.Text = "Puissance d'attaque " + monstre.PuissanceAttaque;
            actualiserAffichage();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.PuissanceAttaque;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceAttaque;

            actualiserAffichage();
            if (joueur.EstMort)
            {
                MessageBox.Show("Vous êtes mort");
            }
            if (monstre.EstMort)
            {
                MessageBox.Show("Vous avez gagner");
            }
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }
        private void actualiserAffichage()
        {
            lbl_pointsVieJoueur.Text = "Point de vie " + joueur.PointDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Puissance d'attaque " + joueur.PuissanceAttaque;
            lbl_pointsVieDragon.Text = "Point de vie " + monstre.PointDeVie;

        }
    }
}