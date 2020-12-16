using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        #region Properties
        chessboardmanager Chessboard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            Chessboard = new chessboardmanager(panel1, NamePlayer, pictureBox);
            Chessboard.PlayerMarked += Chessboard_PlayerMarked;
            Chessboard.EndeGame += Chessboard_EndeGame;
            progressBarCooldown.Step = Cons.COOL_DOWN_STEP;
            progressBarCooldown.Maximum = Cons.COOL_DOWN_TIME;
            progressBarCooldown.Value = 0;
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAl;

            Chessboard.DrawChessBoard();
            tmCoolDown.Start();
        }

        private void Chessboard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            progressBarCooldown.Value = 0;


        }
       void EndGame()
        {
            tmCoolDown.Stop();
            panel1.Enabled = false;
            MessageBox.Show("Kết Thúc Game");
        }
        private void Chessboard_EndeGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {   
            progressBarCooldown.PerformStep();
            if (progressBarCooldown.Value >= progressBarCooldown.Maximum)
            {
                
                EndGame();
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
