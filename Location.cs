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
        public enum ConsoleSize { Height = 30, Width = 118 }
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

        public void GetLocationOnLocations(Locations loc)
        {
            switch (loc)
            {
                case Locations.Top:
                    Line = 0;
                    Space = 59;
                    break;
                case Locations.TopRight:
                    Line = 0;
                    Space = 118;
                    break;
                case Locations.TopLeft:
                    Line = 0;
                    Space = 0;
                    break;
                case Locations.Center:
                    Line = (int)ConsoleSize.Height / 2;
                    Space = (int)ConsoleSize.Width / 2;
                    break;
                case Locations.Left:
                    Line = (int)ConsoleSize.Height / 2;
                    Space = (int)ConsoleSize.Width;
                    break;
                case Locations.Right:
                    Line = (int)ConsoleSize.Height / 2;
                    Space = 0;
                    break;
                case Locations.Bottom:
                    Line = (int)ConsoleSize.Height;
                    Space = (int)ConsoleSize.Width / 2;
                    break;
                case Locations.BottomLeft:
                    Line = (int)ConsoleSize.Height;
                    Space = (int)ConsoleSize.Width;
                    break;
                case Locations.BottomRight:
                    Line = (int)ConsoleSize.Height;
                    Space = 0;
                    break;
                default:
                    break;
            }
        }

    }
}
