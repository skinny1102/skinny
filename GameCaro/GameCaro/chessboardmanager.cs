using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GameCaro
{
    public class chessboardmanager
    {
        #region Properties
        private Panel ChessBoard;
        public Panel ChessBoard1 { get => ChessBoard; set => ChessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox Playermark { get => playermark; set => playermark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playermark;
        private List<List<Button>> matrix;
        private event EventHandler playerMarked;
        public event EventHandler PlayerMarked
        {
            add
            {
                playerMarked += value;

            }
            remove
            {
                playerMarked -= value;
            }
        }
        private event EventHandler endedGame;
        public event EventHandler EndeGame
        {
            add
            {
                endedGame += value;

            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion
        #region Initialize
        public chessboardmanager(Panel chessBoard, TextBox playerName , PictureBox mark)
        {
            this.ChessBoard1 = chessBoard;
            this.PlayerName = playerName;
            this.Playermark = mark;
            this.Player = new List<Player>()
            {
                new Player("TGod" , Image.FromFile(Application.StartupPath + "\\Resources\\000.jpg")),
                new Player("TGod_Bot", Image.FromFile(Application.StartupPath + "\\Resources\\x.png"))
            };
            CurrentPlayer = 0;
            ChangePlayer();
        
        }
     

          
      
        #endregion
        #region Methods
        public void DrawChessBoard()
        {
            MessageBox.Show("Vào chơi đi các con giời ");
            ChessBoard.Enabled = true;
            Matrix = new List<List<Button>>();

            Button oldbtn = new Button();
            oldbtn.Location = new Point(0, 0);
            oldbtn.Width = 0;
            for (int i = 0; i < Cons.CHESS_BOARD_WIDHT; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHESS_BOARD_HIEGHT; j++)
                {
                    Button btn = new Button();
                    btn.Width = Cons.CHESS_WITDTH;
                    btn.Height = Cons.CHESS_HIEUGHT;
                    btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);
                    btn.BackgroundImageLayout = ImageLayout.Stretch ;
                    btn.Tag = i.ToString();
                    ChessBoard1.Controls.Add(btn);
                    
                    oldbtn = btn;
                    btn.Click += Btn_Click;
                    Matrix[i].Add(btn);


                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.CHESS_HIEUGHT);
                oldbtn.Width = 0;
                oldbtn.Height = 0;

            }
        }
       
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.BackgroundImage != null)
            {
                return;
            }
            Mark(btn);
            ChangePlayer();
            //Point point = GetChesspoint(btn);

            //MessageBox.Show(point.Y.ToString());
            if (playerMarked != null)
                playerMarked(this, new EventArgs());
            if (isEndGame(btn))
            {
                EndGame();
            }
       
        }
       public void EndGame()
        {
            if (endedGame != null)
                endedGame(this, new EventArgs());
            //MessageBox.Show("Kết Thúc Game");
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn)|| isEndPrimary(btn) || isEndVertical(btn) || isEndSub(btn)   ;
        }
        private Point GetChesspoint(Button btn) // lấy tọa độ
        {
           
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);
            Point point = new Point( vertical,horizontal);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {

            Point point = GetChesspoint(btn);
            int countLeft = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.Y + 1; i < Cons.CHESS_BOARD_WIDHT; i++)
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else

                    break;
            }
            return countLeft + countRight == 5;
        }
        private bool isEndPrimary(Button btn)
        {

            Point point = GetChesspoint(btn);
            int countTop = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = point.X + 1; i < Cons.CHESS_BOARD_HIEGHT; i++)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else

                    break;
            }
            return countTop + countBottom == 5;
       
        }
        private bool isEndVertical(Button btn)
        {

            Point point = GetChesspoint(btn);
            int countTop = 0;
            for (int i =0; i <= point.Y; i++)
            {
                if (point.Y - i < 0 || point.X - i < 0)
                    break;
                    if (Matrix[point.X-i][point.Y-i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i =  1; i <= Cons.CHESS_BOARD_WIDHT-point.X; i++)
            {   if (point.X + i >= Cons.CHESS_BOARD_WIDHT || point.Y + i >= Cons.CHESS_BOARD_WIDHT)
                    break;
                if (Matrix[point.X+i][point.Y+i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else

                    break;
            }
            return countTop + countBottom == 5;
        }

        private bool isEndSub(Button btn)
        {

            Point point = GetChesspoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.Y; i++)
            {
                if (point.Y+i > Cons.CHESS_BOARD_WIDHT || point.X - i < 0)
                    break;
                if (Matrix[point.X - i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }
            int countBottom = 0;
            for (int i = 1; i <= Cons.CHESS_BOARD_WIDHT - point.Y; i++)
            {
                if (point.X + i >= Cons.CHESS_BOARD_HIEGHT || point.Y - i < 0)
                    break;
                if (Matrix[point.X + i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else

                    break;
            }
            return countTop + countBottom == 5;
        }



        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1; // nếu bằng 1 chuyển thành bằng 0 nếu bằng khoogn chuyển thành bằng 1


        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            Playermark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion


    }
}
