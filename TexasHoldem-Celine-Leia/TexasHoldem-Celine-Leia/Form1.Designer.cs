 namespace TexasHoldem_Celine_Leia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.betBtn_P2 = new System.Windows.Forms.Button();
            this.checkBtn_P2 = new System.Windows.Forms.Button();
            this.foldBtn_P2 = new System.Windows.Forms.Button();
            this.callBtn_P2 = new System.Windows.Forms.Button();
            this.playing_lbl = new System.Windows.Forms.Label();
            this.player2_lbl = new System.Windows.Forms.Label();
            this.player1_lbl = new System.Windows.Forms.Label();
            this.player2_holdings = new System.Windows.Forms.Label();
            this.player1_holdings = new System.Windows.Forms.Label();
            this.player2_C1 = new System.Windows.Forms.Label();
            this.player2_C2 = new System.Windows.Forms.Label();
            this.player1_C1 = new System.Windows.Forms.Label();
            this.player1_C2 = new System.Windows.Forms.Label();
            this.table_Card1 = new System.Windows.Forms.Label();
            this.table_Card2 = new System.Windows.Forms.Label();
            this.table_Card3 = new System.Windows.Forms.Label();
            this.table_Card4 = new System.Windows.Forms.Label();
            this.table_Card5 = new System.Windows.Forms.Label();
            this.potHoldings = new System.Windows.Forms.Label();
            this.cards_in_deck = new System.Windows.Forms.Label();
            this.currentPlayer = new System.Windows.Forms.Label();
            this.cardsindeck_lbl = new System.Windows.Forms.Label();
            this.pothold_lbl = new System.Windows.Forms.Label();
            this.callBtn_P1 = new System.Windows.Forms.Button();
            this.foldBtn_P1 = new System.Windows.Forms.Button();
            this.checkBtn_P1 = new System.Windows.Forms.Button();
            this.betBtn_P1 = new System.Windows.Forms.Button();
            this.winningPlayer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // betBtn_P2
            // 
            this.betBtn_P2.Location = new System.Drawing.Point(142, 675);
            this.betBtn_P2.Name = "betBtn_P2";
            this.betBtn_P2.Size = new System.Drawing.Size(94, 29);
            this.betBtn_P2.TabIndex = 0;
            this.betBtn_P2.Text = "Bet";
            this.betBtn_P2.UseVisualStyleBackColor = true;
            this.betBtn_P2.Click += new System.EventHandler(this.betBtn_Click);
            // 
            // checkBtn_P2
            // 
            this.checkBtn_P2.Location = new System.Drawing.Point(323, 675);
            this.checkBtn_P2.Name = "checkBtn_P2";
            this.checkBtn_P2.Size = new System.Drawing.Size(94, 29);
            this.checkBtn_P2.TabIndex = 1;
            this.checkBtn_P2.Text = "Check";
            this.checkBtn_P2.UseVisualStyleBackColor = true;
            this.checkBtn_P2.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // foldBtn_P2
            // 
            this.foldBtn_P2.Location = new System.Drawing.Point(509, 675);
            this.foldBtn_P2.Name = "foldBtn_P2";
            this.foldBtn_P2.Size = new System.Drawing.Size(94, 29);
            this.foldBtn_P2.TabIndex = 2;
            this.foldBtn_P2.Text = "Fold";
            this.foldBtn_P2.UseVisualStyleBackColor = true;
            this.foldBtn_P2.Click += new System.EventHandler(this.foldBtn_Click);
            // 
            // callBtn_P2
            // 
            this.callBtn_P2.Location = new System.Drawing.Point(692, 675);
            this.callBtn_P2.Name = "callBtn_P2";
            this.callBtn_P2.Size = new System.Drawing.Size(94, 29);
            this.callBtn_P2.TabIndex = 3;
            this.callBtn_P2.Text = "Call";
            this.callBtn_P2.UseVisualStyleBackColor = true;
            this.callBtn_P2.Click += new System.EventHandler(this.callBtn_Click);
            // 
            // playing_lbl
            // 
            this.playing_lbl.AutoSize = true;
            this.playing_lbl.Location = new System.Drawing.Point(63, 191);
            this.playing_lbl.Name = "playing_lbl";
            this.playing_lbl.Size = new System.Drawing.Size(60, 20);
            this.playing_lbl.TabIndex = 4;
            this.playing_lbl.Text = "Playing:";
            // 
            // player2_lbl
            // 
            this.player2_lbl.AutoSize = true;
            this.player2_lbl.Location = new System.Drawing.Point(431, 574);
            this.player2_lbl.Name = "player2_lbl";
            this.player2_lbl.Size = new System.Drawing.Size(80, 20);
            this.player2_lbl.TabIndex = 5;
            this.player2_lbl.Text = "Player Two";
            // 
            // player1_lbl
            // 
            this.player1_lbl.AutoSize = true;
            this.player1_lbl.Location = new System.Drawing.Point(431, 80);
            this.player1_lbl.Name = "player1_lbl";
            this.player1_lbl.Size = new System.Drawing.Size(80, 20);
            this.player1_lbl.TabIndex = 6;
            this.player1_lbl.Text = "Player One";
            // 
            // player2_holdings
            // 
            this.player2_holdings.AutoSize = true;
            this.player2_holdings.Location = new System.Drawing.Point(451, 458);
            this.player2_holdings.Name = "player2_holdings";
            this.player2_holdings.Size = new System.Drawing.Size(41, 20);
            this.player2_holdings.TabIndex = 7;
            this.player2_holdings.Text = "$100";
            // 
            // player1_holdings
            // 
            this.player1_holdings.AutoSize = true;
            this.player1_holdings.Location = new System.Drawing.Point(451, 191);
            this.player1_holdings.Name = "player1_holdings";
            this.player1_holdings.Size = new System.Drawing.Size(41, 20);
            this.player1_holdings.TabIndex = 8;
            this.player1_holdings.Text = "$100";
            // 
            // player2_C1
            // 
            this.player2_C1.AutoSize = true;
            this.player2_C1.Location = new System.Drawing.Point(380, 516);
            this.player2_C1.Name = "player2_C1";
            this.player2_C1.Size = new System.Drawing.Size(27, 20);
            this.player2_C1.TabIndex = 9;
            this.player2_C1.Text = "___";
            // 
            // player2_C2
            // 
            this.player2_C2.AutoSize = true;
            this.player2_C2.Location = new System.Drawing.Point(522, 516);
            this.player2_C2.Name = "player2_C2";
            this.player2_C2.Size = new System.Drawing.Size(27, 20);
            this.player2_C2.TabIndex = 10;
            this.player2_C2.Text = "___";
            // 
            // player1_C1
            // 
            this.player1_C1.AutoSize = true;
            this.player1_C1.Location = new System.Drawing.Point(380, 135);
            this.player1_C1.Name = "player1_C1";
            this.player1_C1.Size = new System.Drawing.Size(27, 20);
            this.player1_C1.TabIndex = 11;
            this.player1_C1.Text = "___";
            // 
            // player1_C2
            // 
            this.player1_C2.AutoSize = true;
            this.player1_C2.Location = new System.Drawing.Point(522, 135);
            this.player1_C2.Name = "player1_C2";
            this.player1_C2.Size = new System.Drawing.Size(27, 20);
            this.player1_C2.TabIndex = 12;
            this.player1_C2.Text = "___";
            // 
            // table_Card1
            // 
            this.table_Card1.AutoSize = true;
            this.table_Card1.Location = new System.Drawing.Point(274, 322);
            this.table_Card1.Name = "table_Card1";
            this.table_Card1.Size = new System.Drawing.Size(57, 20);
            this.table_Card1.TabIndex = 13;
            this.table_Card1.Text = "________";
            // 
            // table_Card2
            // 
            this.table_Card2.AutoSize = true;
            this.table_Card2.Location = new System.Drawing.Point(374, 322);
            this.table_Card2.Name = "table_Card2";
            this.table_Card2.Size = new System.Drawing.Size(57, 20);
            this.table_Card2.TabIndex = 14;
            this.table_Card2.Text = "________";
            // 
            // table_Card3
            // 
            this.table_Card3.AutoSize = true;
            this.table_Card3.Location = new System.Drawing.Point(459, 322);
            this.table_Card3.Name = "table_Card3";
            this.table_Card3.Size = new System.Drawing.Size(57, 20);
            this.table_Card3.TabIndex = 15;
            this.table_Card3.Text = "________";
            // 
            // table_Card4
            // 
            this.table_Card4.AutoSize = true;
            this.table_Card4.Location = new System.Drawing.Point(546, 322);
            this.table_Card4.Name = "table_Card4";
            this.table_Card4.Size = new System.Drawing.Size(57, 20);
            this.table_Card4.TabIndex = 16;
            this.table_Card4.Text = "________";
            this.table_Card4.Click += new System.EventHandler(this.table_Card4_Click);
            // 
            // table_Card5
            // 
            this.table_Card5.AutoSize = true;
            this.table_Card5.Location = new System.Drawing.Point(638, 322);
            this.table_Card5.Name = "table_Card5";
            this.table_Card5.Size = new System.Drawing.Size(57, 20);
            this.table_Card5.TabIndex = 17;
            this.table_Card5.Text = "________";
            // 
            // potHoldings
            // 
            this.potHoldings.AutoSize = true;
            this.potHoldings.Location = new System.Drawing.Point(160, 322);
            this.potHoldings.Name = "potHoldings";
            this.potHoldings.Size = new System.Drawing.Size(47, 20);
            this.potHoldings.TabIndex = 18;
            this.potHoldings.Text = "$_____";
            // 
            // cards_in_deck
            // 
            this.cards_in_deck.AutoSize = true;
            this.cards_in_deck.Location = new System.Drawing.Point(799, 322);
            this.cards_in_deck.Name = "cards_in_deck";
            this.cards_in_deck.Size = new System.Drawing.Size(80, 20);
            this.cards_in_deck.TabIndex = 19;
            this.cards_in_deck.Text = "_____ Cards";
            // 
            // currentPlayer
            // 
            this.currentPlayer.AutoSize = true;
            this.currentPlayer.Location = new System.Drawing.Point(129, 191);
            this.currentPlayer.Name = "currentPlayer";
            this.currentPlayer.Size = new System.Drawing.Size(69, 20);
            this.currentPlayer.TabIndex = 20;
            this.currentPlayer.Text = "__________";
            // 
            // cardsindeck_lbl
            // 
            this.cardsindeck_lbl.AutoSize = true;
            this.cardsindeck_lbl.Location = new System.Drawing.Point(787, 262);
            this.cardsindeck_lbl.Name = "cardsindeck_lbl";
            this.cardsindeck_lbl.Size = new System.Drawing.Size(102, 20);
            this.cardsindeck_lbl.TabIndex = 21;
            this.cardsindeck_lbl.Text = "Cards in Deck:";
            // 
            // pothold_lbl
            // 
            this.pothold_lbl.AutoSize = true;
            this.pothold_lbl.Location = new System.Drawing.Point(63, 322);
            this.pothold_lbl.Name = "pothold_lbl";
            this.pothold_lbl.Size = new System.Drawing.Size(91, 20);
            this.pothold_lbl.TabIndex = 22;
            this.pothold_lbl.Text = "Pot Holding:";
            // 
            // callBtn_P1
            // 
            this.callBtn_P1.Location = new System.Drawing.Point(692, 25);
            this.callBtn_P1.Name = "callBtn_P1";
            this.callBtn_P1.Size = new System.Drawing.Size(94, 29);
            this.callBtn_P1.TabIndex = 26;
            this.callBtn_P1.Text = "Call";
            this.callBtn_P1.UseVisualStyleBackColor = true;
            this.callBtn_P1.Click += new System.EventHandler(this.callBtn_P1_Click);
            // 
            // foldBtn_P1
            // 
            this.foldBtn_P1.Location = new System.Drawing.Point(509, 25);
            this.foldBtn_P1.Name = "foldBtn_P1";
            this.foldBtn_P1.Size = new System.Drawing.Size(94, 29);
            this.foldBtn_P1.TabIndex = 25;
            this.foldBtn_P1.Text = "Fold";
            this.foldBtn_P1.UseVisualStyleBackColor = true;
            this.foldBtn_P1.Click += new System.EventHandler(this.foldBtn_P1_Click);
            // 
            // checkBtn_P1
            // 
            this.checkBtn_P1.Location = new System.Drawing.Point(323, 25);
            this.checkBtn_P1.Name = "checkBtn_P1";
            this.checkBtn_P1.Size = new System.Drawing.Size(94, 29);
            this.checkBtn_P1.TabIndex = 24;
            this.checkBtn_P1.Text = "Check";
            this.checkBtn_P1.UseVisualStyleBackColor = true;
            this.checkBtn_P1.Click += new System.EventHandler(this.checkBtn_P1_Click);
            // 
            // betBtn_P1
            // 
            this.betBtn_P1.Location = new System.Drawing.Point(142, 25);
            this.betBtn_P1.Name = "betBtn_P1";
            this.betBtn_P1.Size = new System.Drawing.Size(94, 29);
            this.betBtn_P1.TabIndex = 23;
            this.betBtn_P1.Text = "Bet";
            this.betBtn_P1.UseVisualStyleBackColor = true;
            this.betBtn_P1.Click += new System.EventHandler(this.betBtn_P1_Click);
            // 
            // winningPlayer_label
            // 
            this.winningPlayer_label.AutoSize = true;
            this.winningPlayer_label.Location = new System.Drawing.Point(431, 379);
            this.winningPlayer_label.Name = "winningPlayer_label";
            this.winningPlayer_label.Size = new System.Drawing.Size(81, 20);
            this.winningPlayer_label.TabIndex = 27;
            this.winningPlayer_label.Text = "____________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 751);
            this.Controls.Add(this.winningPlayer_label);
            this.Controls.Add(this.callBtn_P1);
            this.Controls.Add(this.foldBtn_P1);
            this.Controls.Add(this.checkBtn_P1);
            this.Controls.Add(this.betBtn_P1);
            this.Controls.Add(this.pothold_lbl);
            this.Controls.Add(this.cardsindeck_lbl);
            this.Controls.Add(this.currentPlayer);
            this.Controls.Add(this.cards_in_deck);
            this.Controls.Add(this.potHoldings);
            this.Controls.Add(this.table_Card5);
            this.Controls.Add(this.table_Card4);
            this.Controls.Add(this.table_Card3);
            this.Controls.Add(this.table_Card2);
            this.Controls.Add(this.table_Card1);
            this.Controls.Add(this.player1_C2);
            this.Controls.Add(this.player1_C1);
            this.Controls.Add(this.player2_C2);
            this.Controls.Add(this.player2_C1);
            this.Controls.Add(this.player1_holdings);
            this.Controls.Add(this.player2_holdings);
            this.Controls.Add(this.player1_lbl);
            this.Controls.Add(this.player2_lbl);
            this.Controls.Add(this.playing_lbl);
            this.Controls.Add(this.callBtn_P2);
            this.Controls.Add(this.foldBtn_P2);
            this.Controls.Add(this.checkBtn_P2);
            this.Controls.Add(this.betBtn_P2);
            this.Name = "Form1";
            this.Text = "Texas Hold\'em";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button betBtn_P2;
        private Button checkBtn_P2;
        private Button foldBtn_P2;
        private Button callBtn_P2;
        private Label playing_lbl;
        private Label player2_lbl;
        private Label player1_lbl;
        private Label player2_holdings;
        private Label player1_holdings;
        private Label player2_C1;
        private Label player2_C2;
        private Label player1_C1;
        private Label player1_C2;
        private Label table_Card1;
        private Label table_Card2;
        private Label table_Card3;
        private Label table_Card4;
        private Label table_Card5;
        private Label potHoldings;
        private Label cards_in_deck;
        private Label currentPlayer;
        private Label cardsindeck_lbl;
        private Label pothold_lbl;
        private Button callBtn_P1;
        private Button foldBtn_P1;
        private Button checkBtn_P1;
        private Button betBtn_P1;
        private Label winningPlayer_label;
    }
}