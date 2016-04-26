using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rubix_Cube.Enums;

namespace Rubix_Cube
{
    public class Step
    {
        private Axes.Axis _axis;

        private int _layer;

        private Directions.Direction _direction;

        public Step(Axes.Axis axis, int layer, Directions.Direction direction)
        {
            _axis = axis;
            _layer = layer;
            _direction = direction;
        }

        public Step(Step step)
        {
            _axis = step._axis;
            _layer = step._layer;
            _direction = step._direction;
        }

        public override string ToString()
        {
            return $"Moved the {_layer} on the {_axis.ToString()} axis {_direction.ToString()}.";
        }
    }
}
