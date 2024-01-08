using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_2048_WF
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        Label[,] label = new Label[4, 4]; //grid of 4x4 labels
        int[,] grid = new int[4, 4]; //game grid
        Color[] color = { Color.Snow, Color.Beige, Color.MistyRose, Color.SandyBrown, Color.Orange, Color.Tomato, };

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            //Loop to create the labels
            for (int line = 0; line < 4; line++)
            {
                for(int column = 0; column < 4; column++)
                {
                    label[line, column] = new Label();

                    // the 20 + 100 * colonne determines where the first label will be on the X axis
                    // the 20 + 100 * ligne determines where the first label will be on the Y axis
                    // the 100, 100 is the label's size
                    label[line, column].Bounds = new Rectangle(57 + 100 * column, 100 + 100 * line, 95, 95);

                    //we place te test in the middle of the label
                    label[line, column].TextAlign = ContentAlignment.MiddleCenter;
                    label[line, column].Font = new Font("Arial", 20);

                    //We make visible on the page
                    Controls.Add(label[line, column]);
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
                    if (grid[line, column] > 0)
                    {
                        label[line, column].Text = grid[line, column].ToString();
                    }
                    else
                    {
                        label[line, column].Text = "";
                    }
                    
                    label[line, column].BackColor = color[grid[line, column]];
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


        /*
        private void newEmpty()
        {
            //we generate a grid of empty cases and we give them a number form 1 to 16
            List<int> listEmpty = new List<int>();
            for(int line = 0; line < 4; line++)
            {
                for(int column = 0; column < 4; column++)
                {
                    if (grid[line, column] == 0)
                    {
                        //We stock the case's number (4*line*column)
                        listEmpty.Add(4 * line + column);
                    }
                }
            }

            //we randomly take one the cases
            for(listEmpty.Count > 0)
            {
                Random aleatoire = new Random();
                int nalea = aleatoire.Next(listEmpty.Count);
                grid[line,column]
            }
        }*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
