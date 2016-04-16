namespace Rubix_Cube.Pieces
{
    public class Side
    {
        private Position _position;

        public enum Position
        {
            Top, Front, Right, Bottom, Back, Left
        }

        public Position SidePosition
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        private Color _color;

        public Color SideColor
        {
            get
            {
                return _color;
            }
        }

        public enum Color
        {
            White, Red, Blue, Yellow, Orange, Green
        }

        public Side(int i)
        {
            _position = (Position)i;
            _color = (Color)i;
        }

        public Side(Side side)
        {
            _position = side._position;
            _color = side._color;
        }
    }
}
