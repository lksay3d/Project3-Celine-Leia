namespace TexasHoldem_Celine_Leia
{
    public partial class Form1 : Form
    {
        
        public HoldemHand game;
        public Form1()
        {
            InitializeComponent();
            
            game= new HoldemHand();
        }

        private void betBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

        }

        private void foldBtn_Click(object sender, EventArgs e)
        {

        }

        private void callBtn_Click(object sender, EventArgs e)
        {

        }

        //ignore this method, mistakenly generated
        private void table_Card4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player1_C1.Text = game.player1.player1hand[0].ToString();
            player1_C2.Text = game.player1.player1hand[1].ToString();

            player2_C1.Text = game.player2.player2hand[0].ToString();
            player2_C2.Text = game.player2.player2hand[1].ToString();

        }
    }
}