namespace ConsoleUI
{

    public class Screen
    {
        public List<Element> elements { get; set; }

        public string Name { get; set; }

        public Screen() { }

        public Screen(List<Element> elements, string name)
        {
            this.elements = elements;
            Name = name;
        }
        public Screen(string name) => Name = name;

        public void AddElement(Element element)
        {
            if (!elements.Contains(element))
                elements.Add(element);
        }
        public void RemoveElement(Element element) => elements.Remove(element);

        public void ShowElementList()
        {
            foreach (Element element in elements)
                System.Console.WriteLine(element);
        }


    }

}