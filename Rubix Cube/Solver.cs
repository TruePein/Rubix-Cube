using System;
using System.Collections.Generic;
using Rubix_Cube.Enums;
using Rubix_Cube.IEqualityComparers;

namespace Rubix_Cube
{
    public class Solver
    {
        private readonly List<Cube> _cubes;

        private readonly ProccessedCubes _processed;

        private bool _foundSolution;

        public Cube SolutionCube { get; private set; }

        public Solver(int size)
        {
            _cubes = new List<Cube>();
            _processed = new ProccessedCubes();
            var seed = new Cube(size);
            seed.Scramble();
            Add(seed);
            _foundSolution = false;
        }

        public void Run()
        {
            while (!_foundSolution)
            {
                var cube = Pop();

                if (cube.GetDistanceFromSolved() == 0)
                {
                    _foundSolution = true;
                    SolutionCube = cube;
                    continue;
                }

                var axes = Enum.GetValues(typeof(AxisEnum));
                foreach (AxisEnum axis in axes)
                {
                    for(var layer = 0; layer<cube.Size; layer++)
                    {
                        var directions = Enum.GetValues(typeof(DirectionEnum));
                        foreach (DirectionEnum direction in directions)
                        {
                            var copy = new Cube(cube);
                            copy.MakeMove(axis, layer, direction);
                            Add(copy);
                        }
                    }
                }
                Sort();
            }
        }

#region list methods
        private Cube Pop()
        {
            if(_cubes.Count==0)
                throw new IndexOutOfRangeException("Cannot remove from an empty list.");
            var cube = _cubes[0];
            _cubes.RemoveAt(0);
            _processed.Add(cube);
            Console.WriteLine($"Removed cube with a score of {cube.Score}, {cube.MovesMade} moves, and a distance of {cube.GetDistanceFromSolved()}.");
            return cube;
        }

        private void Add(Cube cube)
        {
            var comparer = new CubePiecesEqualityComparer();
            if (HasBeenProccessed(cube))
            {
                Console.WriteLine($"Ignored cube with a score of {cube.Score}, {cube.MovesMade} moves, and a distance of {cube.GetDistanceFromSolved()}.");
                return;
            }

            if (_cubes.Count == 0)
            {
                _cubes.Add(cube);
                Console.WriteLine($"Added cube with a score of {cube.Score}, {cube.MovesMade} moves, and a distance of {cube.GetDistanceFromSolved()}.");
                return;
            }

            foreach (var waitingCube in _cubes)
            {
                if (!comparer.Equals(cube, waitingCube)) continue;

                if (cube.Score >= waitingCube.Score) return;

                _cubes.Remove(waitingCube);
                _cubes.Add(cube);
                Console.WriteLine($"Added cube with a score of {cube.Score}, {cube.MovesMade} moves, and a distance of {cube.GetDistanceFromSolved()}.");
                return;
            }
            _cubes.Add(cube);
            Console.WriteLine($"Added cube with a score of {cube.Score}, {cube.MovesMade} moves, and a distance of {cube.GetDistanceFromSolved()}.");
        }

        private bool HasBeenProccessed(Cube cube)
        {
            return _processed.HasBeenProccessed(cube);
        }

        private void Sort()
        {
            _cubes.Sort();
        }
#endregion
    }
}
