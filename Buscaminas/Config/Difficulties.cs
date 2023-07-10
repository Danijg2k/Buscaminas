using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas.Config
{
    public static class Data
    {
        // Data for different modes
        public static readonly ModeConfig _easy;
        public static readonly ModeConfig _medium;
        public static readonly ModeConfig _hard;

        static Data()
        {
            _easy = new ModeConfig("Easy (20x20)", 8, 10, 10);
            _medium = new ModeConfig("Medium (25x25)", 14, 18, 40);
            _hard = new ModeConfig("Hard (30x30)", 20, 24, 99);
        }
    }
}
