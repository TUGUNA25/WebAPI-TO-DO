﻿

namespace TO_DO.Application.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() : base() { }
        public UserNotFoundException(string message) : base(message) { }
        public readonly string Code = "User History Not Found";
    }
}
