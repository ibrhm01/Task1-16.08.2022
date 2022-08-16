using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_16._08._2022.Models
{
    class Rectangular:Figure
    {
        private float _width;
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0) _width = value;
            }
        }
        private float _length;
        public float Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0) _length = value;
            }
        }
        public Rectangular(float Width, float Length)
        {
            this.Width = Width;
            this.Length = Length;
        }

        public override float CalcArea()
        {
            return Width * Length;
        }
    }
}
