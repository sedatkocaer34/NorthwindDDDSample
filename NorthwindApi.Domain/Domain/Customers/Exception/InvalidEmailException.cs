﻿using NorthwindApi.Domain.Core.Domain;
using NorthwindApi.Domain.Core.Domain.Excepiton;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindApi.Domain.Domain.Customers.Exception
{
    public class InvalidEmailException : BaseException
    {
        public InvalidEmailException()
        {
            ExceptionType = ExcepitonTypes.InvalidaEmail;
        }
    }
}
