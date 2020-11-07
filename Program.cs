using System;
namespace Programming_Language_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
          DiagonalExample();
          TriangularizelExample();
            FlattenExample();
        }
        private static void DiagonalExample()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUnit.Diagonal(array);

            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }
        private static void TriangularizelExample()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUnit.Triangularize(array);

            for (var row = 0; row < result.GetLength(0); row++)
            {
                for (var col = 0; col < result.GetLength(1); col++)
                    Console.Write(result[row,col]);

                Console.WriteLine(); 
            }
        }

        private static void FlattenExample()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var result = ArrayUnit.Flatten(array);

            foreach (var element in result)
            {
                Console.Write(element + " ");
            }

        }
    }
}
