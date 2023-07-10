using Buscaminas.GameConfig;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscaminas.Layout
{
    public partial class Board : Form
    {
        // Fields
        private ModeConfig modeConfig;      // Contains info about actual difficulty
        private int markedButtons;          // Current marked number of buttons
        private Boolean initialized;

        // Builders
        public Board(ModeConfig modeConfig)
        {
            InitializeComponent();

            // Save current mode configuration
            this.modeConfig = modeConfig;
            this.markedButtons = 0;
            this.initialized = false;

            // Set window text and number of mines
            this.Text = modeConfig.Text;
            this.mines.Text = $"Mines: {modeConfig.Mines}";
            
            // Draw layout

        }

        private void Board_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                // Left click (discover box)
                case MouseButtons.Left:
                    break;

                // Right click (mark box)
                case MouseButtons.Right:
                    MarkButton(sender);         // Change style of the button
                    break;

                // Any other action
                default:
                    Console.WriteLine("LMB -> Discover / RMB -> Mark");
                    break;
            }
        }


        // Changes style of buttons when right clicked
        private void MarkButton(object sender)
        {
            Button button = (Button) sender;
            // If already marked
            if (button.BackColor == Color.Green)
            {
                // Reset background color to base
                button.BackColor = DefaultBackColor;
                button.UseVisualStyleBackColor = true;
                // Unmark button
                this.markedButtons--;
            }
            // If not marked
            else
            {
                // Set background color green (mark them)
                button.BackColor = Color.Green;
                // Mark button
                this.markedButtons++;
            }
            // Update label showing marked
            marked.Text = $"Marked: {this.markedButtons}";
        }

    }
}
