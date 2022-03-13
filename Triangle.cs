﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Triangle : BaseFigure
    {
        private int x1,y1; 
        private int x2, y2;
        private int x3, y3;

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public override string FigureName() { return "трегуольник"; }
        public override void ShowFigure()
        {
            Console.WriteLine(
                $"Это {FigureName()} с координатами({x1},{y1}),({x2},{y2}),({x3},{y3}) \n");
            Console.WriteLine();
        }
    }
}

