using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class FiguresList
    {
        private List<BaseFigure> figItems;
        public BaseFigure this[int index]
        {
            get { return figItems[index]; }
            set { figItems.Add(value); }
        }
        public FiguresList()
        {
            figItems = new List<BaseFigure>();
        }

    }
}
