using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas.Config
{
    public class Difficulty
    {
        // Fields
        public string Name { get; }     // Name (Easy|Medium|Hard|Custom)
        public int Rows { get; }        // Number of rows
        public int Columns { get; }     // Number of columns
        public int Mines { get; }       // Number of mines

        // Builders
        public Difficulty(string name, int rows, int columns, int mines)
        {
            this.Name = name;
            this.Rows = rows;
            this.Columns = columns;
            this.Mines = mines;
        }

        // Methods
        public string getDescription()
        {
            return "";
        }
    }
}
