using Buscaminas.Layout;
using Buscaminas.GameConfig;

namespace Buscaminas
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // When play button is clicked
        private void play_Click(object sender, EventArgs e)
        {
            Board board;
            // Easy mode
            if (easy.Checked)
            {
                board = new Board(Data._easy);
            }
            // Medium mode
            else if (medium.Checked)
            {
                board = new Board(Data._medium);
            }
            // Hard mode
            else if (hard.Checked)
            {
                board = new Board(Data._hard);
            }
            // Custom mode
            //else if (custom.Checked)
            //{
            //    Console.WriteLine("");
            //}
            // None checked (shouldn't be possible)
            else
            {
                return;
            }
            // Show the board
            board.Show();
        }
    }
}