using Rubix_Cube.Enums;

namespace Rubix_Cube
{
    public class Step
    {
        private readonly AxisEnum _axisEnum;

        private readonly int _layer;

        private readonly DirectionEnum _directionEnum;

        public Step(AxisEnum axisEnum, int layer, DirectionEnum directionEnum)
        {
            _axisEnum = axisEnum;
            _layer = layer;
            _directionEnum = directionEnum;
        }

        public Step(Step step)
        {
            _axisEnum = step._axisEnum;
            _layer = step._layer;
            _directionEnum = step._directionEnum;
        }

        public override string ToString()
        {
            return $"Moved the {_layer} on the {_axisEnum} axis {_directionEnum}.";
        }
    }
}
