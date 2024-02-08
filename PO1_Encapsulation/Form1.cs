namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new Personnage();

        public Form1()
        {
            InitializeComponent();
            joueur.PointsDeVie = 10;
            joueur.PointsDePuissance = 1;

            dragon.PointsDeVie = 30;
            dragon.PointsDePuissance = 3;



            //Personnage bowser = new Personnage();
            //bowser.PointsDePuissance = -100;
            //if (bowser.EstEnVie) MessageBox.Show("Toujours vivant");
        }

        private void ActualiserLesLabels()
        {
            lbl_pointsVieDragon.Text = "Vie du joueur : " + dragon.PointsDeVie.ToString();
            // etc pour les autres stats

        }
        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            ActualiserLesLabels();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            ActualiserLesLabels();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            ActualiserLesLabels();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLesLabels();
        }
    }
}