﻿using System;
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
        public Board()
        {
            InitializeComponent();
        }

        public Board(String text, int rows, int columns, int mines)
        {
            this.Text = text;
        }

        private void Board_Load(object sender, EventArgs e)
        {

        }
    }
}
