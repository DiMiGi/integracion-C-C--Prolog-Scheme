using System;

namespace Menu.Modelos
{
    public class Vector2
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector2()
        {
            this.X = -1;
            this.Y = -1;
        }

        public Vector2(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
