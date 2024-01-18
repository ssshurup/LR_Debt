namespace LR_SHPALITOV
{
    public class Geometry
    {
        public int RectArea(int a, int b)
        {
            return a * b;
        }

        public int SquareArea(int a)
        {
            return a * a;
        }
        public int TriangleArea(int a, int h)
        {
            return Convert.ToInt32(a * h / 2);
        }
        public int RhombArea(int d1, int d2)
        {
            return Convert.ToInt32((d1 * d2) / 2);
        }
        public int CircleArea(int r)
        {
            return Convert.ToInt32((Math.Pow(r,2)*Math.PI));
        }
        public int CubeArea(int a)
        {
            return 6 * a * a;
        }
        public int SphereArea(int r)
        {
            return Convert.ToInt32(4*Math.PI*Math.Pow(r,2));
        }
        public int PrizmArea(int w, int h, int l)
        {
            return 2 * (w * l + w * h + h * l);
        }

        public int TrapezoidArea(int a, int b, int h)
        {
            return Convert.ToInt32((a+b)*h/2);
        }
        public int ParallelogramArea(int a, int h)
        {
            return a * h;
        }
    }
}
