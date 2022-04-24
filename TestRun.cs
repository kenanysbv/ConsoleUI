using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class TestRun
    {

        public static void Main(string[] args)
        {
            #region Test Label

            /* With Location Manual */

            //Label l = new Label("Test Lbl", new Location(3,23), "Test Tex", "Test Value");
            //l.Run();
            //Console.WriteLine();
            //l.ShowInfo();


            /* With Location Enum*/

            //Label l = new Label("Test Lbl", new Location(Location.Locations.Bottom), "Test Tex", "Test Vasdsasdasdasdadasdasdasdsaaaaaaaaaaaaaaaaaaaasdasdasdadasdasdasdaalue");
            //l.AutoCenter = true;
            //l.Run();
            //Console.WriteLine();
            //l.ShowInfo();


            #endregion

            #region Test Button

            //Button btn = new Button("TestBtn-1", new Location(Location.Locations.Center), "OKKKKK");
            //btn.Run();
            //Console.WriteLine();
            //btn.Clicked = true;
            //btn.ShowInfo();
            //Console.Clear();
            //btn.Run();


            #endregion

            #region Test Input

            //Input inpt = new Input("TestInput-1", "WriteTestData: ", new Location(Location.Locations.TopRight), ConsoleColor.DarkCyan);
            //inpt.Selected = true;
            //inpt.Run();
            //inpt.ShowInfo();

            #endregion



            #region Test ListItem Progrecs

            //Label l = new Label("LBL-2", new Location(Location.Locations.Left), "HelloWold!", "14");
            //ListItem listItem = new ListItem("TestName", new Location(Location.Locations.TopRight));
            //listItem.AddValue(new Label("LBL", new Location(Location.Locations.Left), "C#", "6"));
            //listItem.AddValue(l);
            //listItem.AddValue(l);
            //listItem.AddValue(new Label("LBL-3", new Location(Location.Locations.Left), "Hakuna", "19"));
            //listItem.ShowValues();
            //listItem.RemoveValue(l);
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~\n\n");
            //listItem.ShowValues();

            ListItem listItem = new("ListItemTest-1", new Location(Location.Locations.BottomRight));
            listItem.AddValue("TestItem-1");
            listItem.AddValue("TestItem-2");
            listItem.AddValue("TestItem-3");
            listItem.AddValue("TestItem-4");
            listItem.AddValue("TestItem-1");
            listItem.ShowValues();

            #endregion

        }
    }
}
