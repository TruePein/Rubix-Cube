using System.Collections.Generic;
using System.Linq;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube
{
    public class ProccessedCubes
    {
        private readonly List<Cube> _proccessed;

        public ProccessedCubes()
        {
            _proccessed = new List<Cube>();
        }

        public void Add(Cube cube)
        {
            if (!HasBeenProccessed(cube))
            {
                _proccessed.Add(cube);
            }
        }

        public bool HasBeenProccessed(Cube cube)
        {
            var comparer = new CubePiecesEqualityComparer();
            return _proccessed.Any(proccessedCube => comparer.Equals(cube, proccessedCube));
        }
    }
}
