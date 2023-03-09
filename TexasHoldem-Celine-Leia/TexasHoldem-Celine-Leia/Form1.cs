namespace TexasHoldem_Celine_Leia
{
    public partial class Form1 : Form
    {
        public bool betBtn_Clicked = false;
        public bool checkBtn_Clicked = false;
        public bool foldBtn_Clicked = false;
        public bool callBtn_Clicked = false;

        public HoldemHand game;

        //controlling player turn
        public class Player
        {
            public Player1 player1;
            public Player2 player2;
            public int currentPlayer;

            public Player(Player1 player1, Player2 player2, int currentPlayer)
            {
                this.player1 = player1;
                this.player2 = player2;
                this.currentPlayer = 1;
            }

            if(betBtn_Clicked || )


        }
        
        public Form1()
        {
            InitializeComponent();
            
            game= new HoldemHand();
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            betBtn_Clicked = true;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            checkBtn_Clicked= false;
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