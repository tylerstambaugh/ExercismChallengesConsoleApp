using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismChallengesConsoleApp
{
    //https://exercism.org/tracks/csharp/exercises/error-handling/edit
    public static class ErrorHandling
    {
        public static void HandleErrorByThrowingException()
        {
            throw new Exception("throws an exception.");
        }

        public static int? HandleErrorByReturningNullableType(string input)
        {
            try
            {
                return Int32.Parse(input);
            }
            catch
            {
                return null;
            }
        }

        public static bool HandleErrorWithOutParam(string input, out int result)
        {
            try
            {
                result = Int32.Parse(input);
                return true;
            }
            catch (Exception ex)
            {
                result = 69;
                return false;
            }
        }

        public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
        {
            try
            {
                disposableObject.Dispose();
                throw new System.Exception();
            }

            catch (Exception e)
            {
                disposableObject.Dispose();
                throw new System.Exception();
            }
        }
    }
}
