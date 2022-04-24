namespace ConsoleUI
{

    public class ListItem : Element
    {
        public class Item
        {
            static public int OutOfOrder = -1;

            public int Order { get; set; } = OutOfOrder;

            public string Text { get; set; }

            public ConsoleColor Color { get; set; } = ConsoleColor.DarkGray;

            public ConsoleColor HoverColor { get; set; } = ConsoleColor.White;



            public Item(string text) => Text = text;

            public Item(string text, int order)
            {
                Text = text;
                Order = order;
            }

            public Item(string text, ConsoleColor color, ConsoleColor hoverColor)
            {
                Text = text;
                Color = color;
                HoverColor = hoverColor;
            }

            public Item(int order, string text, ConsoleColor color, ConsoleColor hoverColor)
            {
                Order = order;
                Text = text;
                Color = color;
                HoverColor = hoverColor;
            }


            public override string ToString() => $"{Text}";
        }

        private List<Item> values = new List<Item>();

        public bool Focused { get; set; } = false;

        public ConsoleColor TextColor { get; set; } = ConsoleColor.DarkGray;
        private ConsoleColor HoverColor { get; set; } = ConsoleColor.White;


        public ListItem(string name, Location location) : base(name, location) { }
        public ListItem(List<Item> values, string name, Location location) : base(name, location)
        {
            this.values = values;
        }

        public ListItem(string name, Location location, ConsoleColor textColor, ConsoleColor hoverColor) : base(name, location)
        {
            TextColor = textColor;
            HoverColor = hoverColor;
        }

        private Item FindItem(string text)
        {
            foreach (Item item in values)
            {
                if (item.Text == text)
                    return item;
            }
            throw new ArgumentException();
        }

        private Item FindItem(Item item)
        {
            foreach (Item value in values)
            {
                if (value.Text == item.Text)
                    return item;
            }
            throw new ArgumentException();
        }

        public void AddValue(string text)
        {
            try
            {
                FindItem(text);
            }
            catch (Exception)
            {
                values.Add(new Item(text));
            }
        }

        public void AddValue(Item item)
        {
            try
            {
                FindItem(item);
            }
            catch (Exception)
            {
                values.Add(item);
            }
        }

        public void RemoveValue(string text)
        {
            try
            {
                values.Remove(FindItem(text));

            }
            catch (Exception) { }
        }

        public void RemoveValue(Item item)
        {
            try
            {
                values.Remove(FindItem(item));

            }
            catch (Exception) { }
        }

        public void ShowValues()
        {
            foreach (Item item in values)
                Console.WriteLine(item);
        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($" ~~~ CountOfItem(s): {values.Count()}");
        }

        public override void Run()
        {
            Console.ForegroundColor = Focused ? HoverColor : TextColor;
            foreach (Item item in values)
            {



            }
        }
    }

}