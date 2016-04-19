using Rubix_Cube.Enums;

namespace Rubix_Cube
{
    public static class LastMove
    {
        public static Axes.Axis Axis { get; set; }

        public static int Layer { get; set; }

        public static Directions.Direction Direction { get; set; }
    }
}
