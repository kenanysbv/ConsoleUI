using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI;

namespace ConsoleUI
{


    public class Location
    {
        public enum Locations { Top, TopRight, TopLeft, Center, Left, Right, Bottom, BottomLeft, BottomRight }
        public enum LocationCase { Empty = -1 }
        public Location(int line, int space)
        {
            Line = line;
            Space = space;
        }

        public Location(Locations locationDefault)
        {
            LocationDefault = locationDefault;
        }

        public Locations LocationDefault { get; set; }
        public int Line { get; set; } = (int)LocationCase.Empty;
        public int Space { get; set; } = (int)LocationCase.Empty;

    }
}
