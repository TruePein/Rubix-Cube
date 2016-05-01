using System;

namespace Rubix_Cube
{
    internal class Program
    {
	    private static void Main(string[] args)
	    {
	        var size = 2;
	        //if (args[0] != null) int.TryParse(args[0], out size);

	        var solver = new Solver(size);
            solver.Run();
            Console.WriteLine(solver.SolutionCube.MovesMade);
	        Console.ReadLine();
        }
    }
}
