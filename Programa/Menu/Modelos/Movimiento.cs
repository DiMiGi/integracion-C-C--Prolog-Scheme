using System;


namespace Menu.Modelos
{
    public class Movimiento
    {
        private Vector2 vector;

        public Vector2 Vector
        {
            get { return vector; }
            set { vector = value; }
        }
        private int tipoDeMovimiento;

        public int TipoDeMovimiento
        {
            get { return tipoDeMovimiento; }
            set { tipoDeMovimiento = value; }
        }

        public Movimiento()
        {
            this.Vector = new Vector2();
            this.TipoDeMovimiento = -1;
        }

        public Movimiento(int x, int y)
        {
            this.Vector = new Vector2(x,y);
        }

        public Movimiento(int x, int y, int tipoDeMovimiento)
        {
            this.Vector = new Vector2(x,y);
            this.TipoDeMovimiento = tipoDeMovimiento;
        }
    }
}
