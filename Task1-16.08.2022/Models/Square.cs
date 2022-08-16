using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_16._08._2022.Models
{
    class Square:Figure
    {
        private float _side;
        public float Side 
        {
            get
            {
                return _side;
            }
            set 
            {
                if (value > 0) _side = value;
            } 
        }

        public Square(float Side)
        {
            this.Side = Side;

        }
        public override float CalcArea()
        {
            return Side * Side;
        }
    }
}
