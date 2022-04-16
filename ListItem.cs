namespace ConsoleUI
{

    public class ListItem : Element
    {
        private List<Element> values = new List<Element>();

        public List<Element> Values
        {
            get { return values; }
            set { values = value; }
        }

        public ListItem(string name, Location location) : base(name, location) { }
        public ListItem(List<Element> values, string name, Location location) : base(name, location)
        {
            Values = values;
        }


        public void AddValue(Element element)
        {
            if (!Values.Contains(element))
                Values.Add(element);
        }
        public void RemoveValue(Element element) => Values.Remove(element);

        public void ShowValues()
        {
            foreach (Element element in Values)
                System.Console.WriteLine(element);
        }
    }

}