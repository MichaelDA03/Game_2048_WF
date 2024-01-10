using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2048_WF
{
    public partial class Form1 : Form
    {
        static Random random = new Random();

        //grid of 4x4 labels
        Label[,] label = new Label[4, 4];

        //game grid
        int[,] grid = new int[4, 4];

        //Buffer grid
        int[,] bufferGrid = new int[4, 4];

        //game score
        int score = 0;

        bool isWin = false;



        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            //*
            //We print the base panel for the score
            this.PnlScore = new Panel();
            PnlScore.Bounds = new Rectangle(370, 35, 100, 50);
            PnlScore.BackColor = Color.FromArgb(115, 92, 72);
            this.Controls.Add(PnlScore);

            //We print the label that mentions "Votre score"
            this.lblScore = new Label();
            lblScore.Text = "Votre score:";
            lblScore.Bounds = new Rectangle(6, 5, 90, 15);
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.Font = new Font("Arial", 11);
            PnlScore.Controls.Add(lblScore);

            //We print the label that will mention the user's actual score
            this.lblScoreVal = new Label();
            lblScoreVal.Text = "0";
            lblScoreVal.Bounds = new Rectangle(6, 25, 90, 15);
            lblScoreVal.TextAlign = ContentAlignment.MiddleCenter;
            lblScoreVal.Font = new Font("Arial", 11);
            PnlScore.Controls.Add(lblScoreVal);
            //*/

            //We print the base square where all the tiles will fit
            Panel backgroundPanel = new Panel();
            backgroundPanel.Bounds = new Rectangle(50, 95, 425, 425);
            backgroundPanel.BackColor = Color.FromArgb(115, 92, 72);
            this.Controls.Add(backgroundPanel);

            //Loop to create the labels in the background square
            for (int line = 0; line < 4; line++)
            {
                for(int column = 0; column < 4; column++)
                {
                    label[line, column] = new Label();

                    // the 5 + 105 * colonne determines where the first label will be on the X axis (inside the background square)
                    // the 5 + 105 * ligne determines where the first label will be on the Y axis (inside the background square)
                    // the 100, 100 is the label's size
                    label[line, column].Bounds = new Rectangle(5 + 105 * column, 5 + 105 * line, 100, 100);

                    //we place the text in the middle of the label
                    label[line, column].TextAlign = ContentAlignment.MiddleCenter;
                    label[line, column].Font = new Font("Arial", 20);

                    //We add the labels to the background panel
                    backgroundPanel.Controls.Add(label[line, column]);
                }
            }

            //We generate the 2 random numbers without checking if the game is over
            for(int i = 0; i < 2; i++)
            {
                newTile();
                Print();
            }
        }

        private void Print()
        {
            //Prints all of the grid with the colors according to the tile's values
            for(int line = 0; line < 4; line++)
            {
                for(int column = 0;column < 4; column++)
                {
                    label[line, column].Text = grid[line, column].ToString();

                    labelColor(label[line,column]);

                    if (label[line,column].Text == "0")
                    {
                        label[line, column].Text = "";
                    }
                }
            }
        }

        private void newTile()
        {
            //We create a list with the coordinates of the empty tiles on the grid
            List<Tuple<int, int>> emptyTiles = new List<Tuple<int, int>>();

            for(int li=0; li < 4; li++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (grid[li, col] == 0)
                    {
                        emptyTiles.Add(Tuple.Create(li, col));
                    }
                }
            }

            //If there are empty tiles, we generate either a 2 or a 4 and place it in a random tile
            if(emptyTiles.Count > 0)
            {
                int randomIndex = random.Next(emptyTiles.Count);
                Tuple<int,int> randomEmptyTile = emptyTiles[randomIndex];
                int newValue = (random.Next(10) == 0) ? 4 : 2;
                grid[randomEmptyTile.Item1, randomEmptyTile.Item2] = newValue;
            }
        }

        //We use this method to change the order and merge the tiles in the grid when we move
        private int[] changeOrder(int nb0, int nb1, int nb2, int nb3)
        {
            //This is to change the order
            if (nb2 == 0 && nb3 > 0)
            {
                nb2 = nb3;
                nb3 = 0;
            }

            if (nb1 == 0 && nb2 > 0)
            {
                nb1 = nb2;
                nb2 = nb3;
                nb3 = 0;
            }

            if (nb0 == 0 && nb1 > 0)
            {
                nb0 = nb1;
                nb1 = nb2;
                nb2 = nb3;
                nb3 = 0;
            }

            //This is to merge the tiles
            if (nb0 == nb1)
            {
                nb0 += nb1;
                nb1 = nb2;
                nb2 = nb3;
                nb3 = 0;
                score += nb0;
                
            }

            if (nb1 == nb2)
            {
                nb1 += nb2;
                nb2 = nb3;
                nb3 = 0;
                score += nb1;
            }

            if (nb2 == nb3)
            {
                nb2 += nb3;
                nb3 = 0;
                score += nb2;
            }
            this.lblScoreVal.Text = score.ToString();
            int[] ordre = { nb0, nb1, nb2, nb3 };
            return ordre;
        }

        //We use this method to move and merge the tiles depending on what key was pressed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                //If we go UP
                case Keys.Up:
                    for(int y = 0; y < grid.GetLength(0); y++)
                    {
                        int[] column = changeOrder(grid[0, y], grid[1, y], grid[2, y], grid[3, y]);

                        for(int i = column.Length - 1; i >= 0; i--)
                        {
                            bufferGrid[i, y] = column[i];
                        }
                    }
                    Array.Copy(bufferGrid, grid, grid.Length);
                    break;

                //If we go DOWN
                case Keys.Down:
                    for(int y = 0;y < grid.GetLength(0); y++)
                    {
                        int[] column = changeOrder(grid[3, y], grid[2, y], grid[1, y], grid[0, y]);
                        int index = 0;

                        for(int i = column.Length - 1; i >= 0; i--)
                        {
                            bufferGrid[i, y] = column[index];
                            index++;
                        }
                    }
                    Array.Copy (bufferGrid, grid, grid.Length);
                    break;

                //If we move LEFT
                case Keys.Left:
                    for (int x = 0; x < grid.GetLength(0); x++)
                    {
                        int[] line = changeOrder(grid[x, 0], grid[x, 1], grid[x, 2], grid[x, 3]);

                        for(int i = 0; i < line.Length; i++)
                        {
                            bufferGrid[x, i] = line[i];
                        }
                    }
                    Array.Copy(bufferGrid, grid, grid.Length);
                    break;

                //If we move RIGHT
                case Keys.Right:
                    for(int x = 0; x < grid.GetLength(0); x++)
                    {
                        int[] line = changeOrder(grid[x, 3], grid[x, 2], grid[x, 1], grid[x, 0]);
                        int index = 0;

                        for(int i = line.Length - 1; i >= 0; i--)
                        {
                            bufferGrid[x, i] = line[index];
                            index ++;
                        }
                    }
                    Array.Copy(bufferGrid, grid, grid.Length);
                    break;
            }
            newTile();
            Print();
            weDidIt();
        }

        //We use this method to give the tiles colors depending on what their value is
        private void labelColor(Label label)
        {
            switch (label.Text)
            {
                case "2":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#448C23");
                    break;

                case "4":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#3A7320");
                    break;

                case "8":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#005C53");
                    break;

                case "16":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#13678A");
                    break;

                case "32":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#45C4B0");
                    break;

                case "64":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#9AEBA3");
                    break;

                case "128":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#DAFDBA");
                    break;

                case "256":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#F2CB05");
                    break;

                case "512":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#F29F05");
                    break;

                case "1024":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#F28705");
                    break;

                case "2048":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#F23030");
                    break;

                default:
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#A69485");
                    break;
            }
        }

        private void weDidIt()
        {
            foreach(int var in grid)
            {
                if(var >= 2048 && isWin == false)
                {
                    isWin = true;
                    MessageBox.Show("Vous avez gagné!\nVous pouvez continuer à jouer.");
                }
            }
        }

        private void canMove()
        {

        }


    }
}
