﻿using System;

namespace AccountService.Core.Exceptions
{
    public class AccountException : Exception
    {
        public AccountException() { }

        public AccountException(string message) : base(message) { }

        public AccountException(string message, Exception ex) : base(message, ex) { }
    }
}
