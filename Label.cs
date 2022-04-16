using ConsoleUI;

namespace ConsoleUI
{
    public class Label : Element
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ConsoleColor ValueColor { get; set; } = ConsoleColor.Green;

        public ConsoleColor TextColor { get; set; } = ConsoleColor.White;



        public Label(string name, Location location, string text, string value, ConsoleColor textColor, ConsoleColor valueColor) : base(name, location)
        {
            Text = text;
            Value = value;
            TextColor = textColor;
            ValueColor = valueColor;
        }

        public Label(string name, Location location, string text, string value) : base(name, location)
        {
            Text = text;
            Value = value;
        }



        public void ChangeText(string text) => Text = text;

        public void ChangeValue(string value) => Value = value;

        public override void Run()
        {
            if (AutoCenter)
                UptodateLocation();
            GoToLocation();
            Console.ForegroundColor = TextColor;
            Console.Write($"{Text} ");
            Console.ForegroundColor = ValueColor;
            Console.Write(Value);
            Console.ResetColor();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Text: {Text} \nValue: {Value}\nTextColor: {TextColor}\nValueColor: {ValueColor}");
        }

        public override void UptodateLocation()
        {
            this.Location.Space = UI.FindCenterText(Location.Space, (Text.Length + Value.Length));

        }
    }
}
