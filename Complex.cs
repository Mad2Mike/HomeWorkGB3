using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonGB3
{
    struct Complex
    {

        private double a, b;

        //public void SetA(double value)
        //{
        //    a = value;
        //}
        //public double GetA (){ return a; }

        //public void SetB(double value)
        //{
        //    b = value;
        //}

        //public double GetB() { return b; }


        public double B 
        {
            get {return b; }
                set { b = value; }
        }
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        static public Complex Sum(Complex x, Complex y)
        {
            return new Complex(Re: x.a + y.a,
                               Im: x.b + y.b);


        }
        static public Complex Dif(Complex x, Complex y)
        {
            return new Complex(Re: x.a - y.a,
                               Im: x.b - y.b);
                

        }
        static public Complex Mult(Complex x, Complex y)
        {
            return new Complex(Re: x.a * y.a - x.b*y.b,
                               Im: x.a*y.b + y.a*x.b);
        }
        public Complex(double Re, double Im) 
        {
          a = Re;
          b = Im;
        }

        public override string ToString()
        {
            if (b == 0) return $"{a}";
            else if (a == 0) return $"{b}i";
            else if (B == -1) return $"{a} - i";
            else if (B == 1) return $"{a} + i";
            return (b < 0) ? $"{a} - {-b}i": $"{a} +{b}i";
        }

    }
}
