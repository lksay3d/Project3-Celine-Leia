namespace TexasHoldem_Celine_Leia
{
    public partial class Form1 : Form
    {
        public bool betBtn_Clicked = false;
        public bool checkBtn_Clicked = false;
        public bool foldBtn_Clicked = false;
        public bool callBtn_Clicked = false;
        public int winner = 0;
        public HoldemHand game;
        public Deck CardDeck = new Deck();
        public int player1winnerscore = -1;
        public int player2winnerscore= -1;
        public int gameround = 0;
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
        }
        
        public Form1()
        {
            InitializeComponent();
            
            game = new HoldemHand(CardDeck);
        }

        private void betBtn_Click(object sender, EventArgs e)
        {
            betBtn_Clicked = true;
            checkBtn_Clicked= false;
            foldBtn_Clicked= false;
            callBtn_Clicked= false;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            checkBtn_Clicked= true;
            betBtn_Clicked= false;
            foldBtn_Clicked= false;
            callBtn_Clicked= false;
        }

        private void foldBtn_Click(object sender, EventArgs e)
        {
            foldBtn_Clicked= true;
            betBtn_Clicked= false;
            checkBtn_Clicked= false;
            callBtn_Clicked= false;
        }

        private void callBtn_Click(object sender, EventArgs e)
        {
            callBtn_Clicked= true;
            betBtn_Clicked= false;
            foldBtn_Clicked= false;
            checkBtn_Clicked= false;
        }
        public int CalulatePlayerWinner()
        {
            if (Turn() == 5)
            {
                winner = player1Hand.hand1.CompareTo(player2Hand.hand2);
            }
            if (winner == player1winnerScore)
            {
                winningPlayer_label.Text = "Player 1 Wins";
            }
            if (winner == player2winnerScore)
            {
                winningPlayer_label.Text = "Player 2 Wins";
            }
            if (winner == 0)
            {
                winningPlayer_label.Text = "No one wins";
            }
            return winner;
        }
        public int Turn()
        {
            if (game.communityCard.Count < 5)
            {
                gameround++;
                game.communityCards(CardDeck, gameround);

            }


            return gameround;

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

        private void betBtn_P1_Click(object sender, EventArgs e)
        {
            betBtn_Clicked = true;
            checkBtn_Clicked = false;
            foldBtn_Clicked = false;
            callBtn_Clicked = false;
        }

        private void checkBtn_P1_Click(object sender, EventArgs e)
        {
            checkBtn_Clicked = true;
            betBtn_Clicked = false;
            foldBtn_Clicked = false;
            callBtn_Clicked = false;
        }

        private void foldBtn_P1_Click(object sender, EventArgs e)
        {
            foldBtn_Clicked = true;
            betBtn_Clicked = false;
            checkBtn_Clicked = false;
            callBtn_Clicked = false;
        }

        private void callBtn_P1_Click(object sender, EventArgs e)
        {
            callBtn_Clicked = true;
            betBtn_Clicked = false;
            foldBtn_Clicked = false;
            checkBtn_Clicked = false;
        }
    }
}