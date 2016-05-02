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
            seed.Scramble(100);
            Insert(seed);
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
                            Insert(copy);
                        }
                    }
                }
                //Sort();
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
            Console.WriteLine($"D. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
            return cube;
        }

        private void Insert(Cube cube)
        {
            if (HasBeenProccessed(cube))
            {
                Console.WriteLine($"I. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
                return;
            }

            if (_cubes.Count == 0)
            {
                _cubes.Add(cube);
                Console.WriteLine($"A. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
                return;
            }

            var comparer = new CubePiecesEqualityComparer();
            foreach (var waitingCube in _cubes)
            {
                if (!comparer.Equals(cube, waitingCube)) continue;

                if (cube.Score >= waitingCube.Score)
                {
                    Console.WriteLine($"I. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
                    return;
                }

                _cubes.Remove(waitingCube);
                _cubes.Add(cube);
                Console.WriteLine($"R. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
                return;
            }

            BinaryInsert(cube, 0, _cubes.Count - 1);
            Console.WriteLine($"A. Score {cube.Score}. Moves {cube.MovesMade}. Distance {cube.GetDistanceFromSolved()}.");
        }

        private void BinaryInsert(Cube cube, int start, int end)
        {
            if (end < start || (end == start && cube.CompareTo(_cubes[start]) < 1))
            {
                _cubes.Insert(start, cube);
                return;
            }

            if (end == start)
            {
                _cubes.Insert(start+1, cube);
                return;
            }

            var mid = (start + end)/2;
            var midCube = _cubes[mid];
            if (cube.CompareTo(midCube) == 0)
            {
                _cubes.Insert(mid, cube);
                return;
            }

            if (cube.CompareTo(midCube) == -1)
            {
                BinaryInsert(cube, start, mid-1);
                return;
            }
            BinaryInsert(cube, mid + 1, end);
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
