using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex17
    {
        public static int exercitiu(int suma)
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = suma;
            Console.WriteLine("Elementele listei:");
            foreach (var x in lista)
            {
                Console.Write(x);
                Console.Write(" ");
                sum += x;
            }
            return sum;
        }

    }
    public class Test
    {
        [Fact]
        public void testExercitiu()
        {
            //Arange
            int input = 0;
            int expected = 45;

            //Act
            int result = Ex17.exercitiu(input);

            //Asert
            Assert.Equal(expected, result);
        }
            
    }
}
