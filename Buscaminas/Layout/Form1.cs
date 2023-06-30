using Buscaminas.Layout;

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

        // 
        private void play_Click(object sender, EventArgs e)
        {
            Board board;
            // Easy mode
            if (easy.Checked)
            {
                board = new Board(easy.Text, 8, 10, 10);
            }
            // Medium mode
            else if (medium.Checked)
            {
                board = new Board(medium.Text, 14, 18, 40);
            }
            // Hard mode
            else if (hard.Checked)
            {
                board = new Board(hard.Text, 20, 24, 99);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}