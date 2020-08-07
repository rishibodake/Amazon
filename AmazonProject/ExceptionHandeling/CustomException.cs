
using System;

namespace AmazonProject.ExceptionHandeling
{
    public class CustomException : Exception
    {
        public TypeOfException typeOfException;
        public string message;

        public CustomException(TypeOfException typeOfException, string message)
        {
            this.typeOfException = typeOfException;
            this.message = message;
        }

        public enum TypeOfException
        {
            NO_SUCH_ELEMENT_FOUND
        }
    }
}
