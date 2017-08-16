using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercitii
{
    public class Ex16
    {
        public void exercitiu()
        {
            Console.WriteLine("Introduceti o litera:");
            string x = Console.ReadLine();
            List<string> lista = GetAccessPermissions(x);
            lista.ForEach(Console.Write);
            Console.ReadLine();
        }
        public List<string> GetAccessPermissions(string token)
        {
            // check token validity here and throw exceptions as needed.yuj
            try
            {
                if (token == "")
                    throw new MyMissingTokenException(token);
                else if (token == "a" || token == "b")
                    throw new MyInvalidTokenException(token);

                else return new List<string> { "Ai introdus o litera corecta." };
            }
            catch (MyMissingTokenException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyInvalidTokenException e)
            {
                Console.WriteLine(e.Message);
            }
            return new List<string> { "Nu ai introdus nicio litera.", " Sau ai introdus a sau b." };
        }

        public class MyMissingTokenException : ArgumentException
        {
            public MyMissingTokenException(string token)
                : base($"Could not find member: {token}.")
            {
            }
        }

        public class MyInvalidTokenException : ArgumentException
        {
            public MyInvalidTokenException(string token)
                : base($"Could not find member: {token}.")
            {
            }
        }
    }
}
