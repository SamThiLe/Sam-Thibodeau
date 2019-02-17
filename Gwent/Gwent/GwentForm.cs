using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Gwent
{
    public partial class GwentForm : Form
    {
        public GwentForm()
        {
            InitializeComponent();
        }
        Board theBoard;
        #region Events
        private void GwentForm_Load(object sender, EventArgs e)
        {
            btnPass.Enabled = false;
            flpBlack.AllowDrop = true;
            flpRed.AllowDrop = true;
            flpPlayerHand.BackColor = Color.FromArgb(100, 255, 255, 255);
            flpOpponentsHand.BackColor = Color.FromArgb(100, 255, 255, 255);
            flpBlack.BackColor = Color.FromArgb(75, 0, 0, 0);
            flpRed.BackColor = Color.FromArgb(75, 255, 0, 0);
            //BackgroundImage = Image.FromFile("images\\Background.jpg");
        }
        private void btnPass_Click(object sender, EventArgs e)
        {
            theBoard.PlayerPass = true;
            while (!theBoard.OpponentPass && theBoard.OpponentHand.Count > 0)
            {
                OpponentTurn(theBoard.OpponentTurn());
            }
            theBoard.EndRound();
            NewRound();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Reset();
                PictureBox cardPic;
                lblDisplay.Text = "Your Turn";
                for (int i = 0; i < theBoard.PlayerHand.Count; i++)
                {
                    cardPic = new PictureBox();
                    flpPlayerHand.Controls.Add(cardPic);
                    cardPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    cardPic.Width = 150;
                    cardPic.Height = 245;
                    string x = "images\\" + theBoard.PlayerHand[i].CardValue.ToString() + theBoard.PlayerHand[i].CardSuit.ToString() + ".png";
                    cardPic.Image = Image.FromFile(x);
                    cardPic.Tag = theBoard.PlayerHand[i];
                    cardPic.MouseDown += PictureBox_MouseDown;
                }
                for (int i = 0; i < theBoard.OpponentHand.Count; i++)
                {
                    cardPic = new PictureBox();
                    flpOpponentsHand.Controls.Add(cardPic);
                    cardPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    cardPic.Width = 150;
                    cardPic.Height = 245;
                    string x = "images\\Back.png";
                    cardPic.Image = Image.FromFile(x);
                    cardPic.Tag = theBoard.OpponentHand[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Methods
        private void NewRound()
        {
            UpdateLives(theBoard.PlayerLives, theBoard.OpponentLives);
            if (!theBoard.GameOver)
            {
                theBoard.NewRound();
                ClearFields();
                lblDisplay.Text = "Your Turn";
                lblMyPoints.Text = "0";
                lblOPoints.Text = "0";
            }
        }
        private void OpponentTurn(int CardIndex)
        {
            if (CardIndex != -1)
            {
                lblOPoints.Text = theBoard.OpponentPoints.ToString();
                Card opcard = theBoard.OpponentHand[CardIndex];
                movingCard = (PictureBox)flpOpponentsHand.Controls[CardIndex];
                if (opcard.IsBlack())
                {
                    theBoard.BlackField.AddCard(theBoard.OpponentHand[CardIndex]);
                    movingCard.Image = Image.FromFile("images\\" + opcard.CardValue.ToString() + opcard.CardSuit.ToString() + ".png");
                    movingCard.BackColor = Color.FromArgb(150, 255, 255, 255);
                    flpBlack.Controls.Add(movingCard);
                }
                else
                {
                    theBoard.RedField.AddCard(theBoard.OpponentHand[CardIndex]);
                    movingCard.Image = Image.FromFile("images\\" + opcard.CardValue.ToString() + opcard.CardSuit.ToString() + ".png");
                    movingCard.BackColor = Color.FromArgb(150, 255, 255, 255);
                    flpRed.Controls.Add(movingCard);
                }
                theBoard.OpponentHand.RemoveCard(CardIndex);
            }
            else
            {
                theBoard.OpponentPass = true;
                lblDisplay.Text = "Opponent Passed Their Turn";
            }
        }
        private void ClearFields()
        {
            flpBlack.Controls.Clear();
            flpRed.Controls.Clear();
        }
        private void Reset()
        {
            this.Controls.Remove(endGamePic);
            btnPass.Enabled = true;
            btnStart.Enabled = false;
            theBoard = new Board();
            theBoard.TheDeck.shuffle();
            theBoard.DealHands();
            flpRed.Tag = theBoard.RedField;
            flpBlack.Tag = theBoard.BlackField;
            lblMP.Visible = true;
            lblMyPoints.Visible = true;
            lblOL.Visible = true;
            lblOP.Visible = true;
            lblOPoints.Visible = true;
            lblYP.Visible = true;
            flpBlack.Controls.Clear();
            flpRed.Controls.Clear();
            flpPlayerHand.Controls.Clear();
            flpOpponentsHand.Controls.Clear();
            UpdateLives(theBoard.PlayerLives, theBoard.OpponentLives);
            lblDisplay.Text = "Your Turn";
            lblMyPoints.Text = "0";
            lblOPoints.Text = "0";
        }
        private void UpdateLives(int myLife, int opLife)
        {
            PictureBox gemmy;
            fplMyLives.Controls.Clear();
            fplOpLives.Controls.Clear();
            for (int i = 0; i < myLife; i++)
            {
                gemmy= new PictureBox();
                gemmy.Image = Image.FromFile("images\\gem.png");
                gemmy.SizeMode = PictureBoxSizeMode.StretchImage;
                gemmy.Width = 32;
                gemmy.Height = 34;
                fplMyLives.Controls.Add(gemmy);
                gemmy.Name = "EGM";
            }
            for (int i = 0; i < opLife; i++)
            {
                gemmy = new PictureBox();
                gemmy.Image = Image.FromFile("images\\gem.png");
                gemmy.SizeMode = PictureBoxSizeMode.StretchImage;
                gemmy.Width = 32;
                gemmy.Height = 34;
                fplOpLives.Controls.Add(gemmy);
            }
            if (myLife == 0)
            {
                theBoard.GameOver = true;
                YouLose();
            }
            else if (opLife == 0)
            {
                theBoard.GameOver = true;
                YouWin();
            }
        }
        #endregion
        #region EndGame
        PictureBox endGamePic;
        private void YouLose()
        {
            endGamePic = new PictureBox();
            endGamePic.Image = Image.FromFile("images\\YouLose.png");
            endGamePic.SizeMode = PictureBoxSizeMode.StretchImage;
            endGamePic.Width = 320;
            endGamePic.Height = 340;
            endGamePic.Left = 400;
            endGamePic.Top = 300;
            this.Controls.Add(endGamePic);
            endGamePic.BringToFront();
            btnStart.Enabled = true;
            btnPass.Enabled = false;
            lblDisplay.Text = "";
            endGamePic.BackColor = Color.FromArgb(50, 255, 255, 255);
        }
        private void YouWin()
        {
            endGamePic = new PictureBox();
            endGamePic.Image = Image.FromFile("images\\YouWin.png");
            endGamePic.SizeMode = PictureBoxSizeMode.StretchImage;
            endGamePic.Width = 420;
            endGamePic.Height = 400;
            endGamePic.Left = 300;
            endGamePic.Top = 250;
            this.Controls.Add(endGamePic);
            endGamePic.BringToFront();
            btnStart.Enabled = true;
            btnPass.Enabled = false;
            lblDisplay.Text = "";
            endGamePic.BackColor = Color.FromArgb(50, 255, 255, 255);
        }
        #endregion
        #region MovingPictureBoxEvent
        PictureBox movingCard;
        FlowLayoutPanel flpMovingFrom;
        private void PictureBox_MouseDown(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                movingCard = (PictureBox)sender;
                flpMovingFrom = (FlowLayoutPanel)movingCard.Parent;
                movingCard.DoDragDrop(movingCard.Image, DragDropEffects.Move);
            }
        }
        private void flpMyHand_DragDrop(object sender, DragEventArgs e)
        {
            Card card = (Card)movingCard.Tag;
            FlowLayoutPanel flpMoveTo = (FlowLayoutPanel)sender;
            Field toField = (Field)flpMoveTo.Tag;
            int index = flpMovingFrom.Controls.IndexOf(movingCard);
            if (toField.Count < toField.CardLimit)
            {
                if ((toField.IsBlack() && card.IsBlack()))
                {
                    theBoard.IPlayCard((Card)movingCard.Tag, (Hand)flpMovingFrom.Tag, (Field)flpMoveTo.Tag);
                    flpMoveTo.Controls.Add(movingCard);
                    movingCard.BackColor = Color.FromArgb(150, 255, 255, 255);
                    lblMyPoints.Text = theBoard.PlayerPoints.ToString();
                    OpponentTurn(theBoard.OpponentTurn());
                }
                else if ((toField.IsRed() && (card.IsRed())))
                {
                    theBoard.IPlayCard((Card)movingCard.Tag, (Hand)flpMovingFrom.Tag, (Field)flpMoveTo.Tag);
                    flpMoveTo.Controls.Add(movingCard);
                    movingCard.BackColor = Color.FromArgb(150, 255, 255, 255);
                    lblMyPoints.Text = theBoard.PlayerPoints.ToString();
                    OpponentTurn(theBoard.OpponentTurn());
                }
            }
        }
        private void flpRed_DragEnter(object sender, DragEventArgs e)
        {
            Card card = (Card)movingCard.Tag;
            FlowLayoutPanel flpMoveTo = (FlowLayoutPanel)sender;
            Field toField = (Field)flpMoveTo.Tag;
            if (card.IsRed() && toField.IsRed())
                e.Effect = DragDropEffects.Move;
            if (card.IsBlack() && toField.IsBlack())
                e.Effect = DragDropEffects.Move;
        }
        #endregion
        #region Music
        private bool Sound=false;
        SoundPlayer startSoundPlayer= new System.Media.SoundPlayer("song\\bensound-epic.wav");
        private void pcbSound_Click(object sender, EventArgs e)
        {
            if (!Sound)
            {
                pcbSound.Image = Image.FromFile("images\\SoundOff.png");
                startSoundPlayer.PlayLooping();
                Sound = true;
            }
            else
            {
                pcbSound.Image = Image.FromFile("images\\SoundOn.png");
                startSoundPlayer.Stop();
                Sound = false;
            }
                
        }
        #endregion
    }
}
