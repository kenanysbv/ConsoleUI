using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CocsoleUI;

namespace ConsoleUI
{
    public class UI
    {
        protected int CID { get; set; }

        public bool Visible { get; set; } = true;

        public virtual void Run() { }
        public virtual void ShowInfo() { }

        public virtual void UptodateLocation() { }

        static public int FindCenterText(int space, int txtLen) => (txtLen / 2) < space ? space - (txtLen / 2) : 0;

    }
}
