namespace ConsoleUI
{

    public class ListItem : Element
    {
        public List<Element> Values { get; set; }


        public ListItem(string name, Location location, string text, string value) : base(name, location) { }
        public ListItem(List<Element> values, string name, Location location, string text, string value) : base(name, location)
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