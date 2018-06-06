using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAssignment
{
    class Movie
    {
        private Dictionary<int, string> _review;

        public string Title { get; set; }
        public double Rating { get; set; }
        public double Money { get; set; }
        public string Actor { get; set; }
        public Dictionary<int, string> Review { get { return _review; } set { this._review = value; } }
    }
}
