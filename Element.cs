using ConsoleUI;

namespace ConsoleUI
{

    public class Element : Base
    {
        public bool Visible { get; set; } = true;

        public Location Location { get; set; }

        public bool AutoCenter { get; set; } = true;


        public Element(string name, Location location)
        {
            Name = name;
            Location = location;
            ID = Guid.NewGuid();
        }


        public virtual void GoToLocation()
        {
            Location.GetLocationOnLocations();
            for (int line = 1; line < Location.Line; line++)
            {
                Console.WriteLine();
            }
            for (int space = 1; space < Location.Space; space++)
            {
                Console.Write(" ");
            }
        }

        public override void ShowInfo() => Console.Write($"Name: {Name} ~~ CID: {CID} ~~ Location(line,space): {Location.Line}*{Location.Space}");
    }

}