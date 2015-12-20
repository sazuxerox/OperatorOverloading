namespace OperatorOverloading
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double getVolume()
        {
            return length*breadth*height;
        }

        public void setLength(double l)
        {
            length = l;
        }

        public void setBreadth(double b)
        {
            breadth = b;
        }

        public void setheight(double h)
        {
            height = h;
        }

        public static Box operator+(Box b, Box c)
        {
            var box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
}
