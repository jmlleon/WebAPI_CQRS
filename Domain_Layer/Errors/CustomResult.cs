﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Errors
{
        public class CustomResult<T>
        {
            private readonly T? _value;
            private CustomResult(T value)
            {
                Value = value;
                IsSuccess = true;
                Error = Error.None;
            }
            private CustomResult(Error error)
            {
                if (error == Error.None)
                {
                    throw new ArgumentException("invalid error", nameof(error));
                }
                IsSuccess = false;
                Error = error;
            }
            public bool IsSuccess { get; }
            public bool IsFailure => !IsSuccess;
            public T Value
            {
                get
                {
                    if (IsFailure)
                    {
                        throw new InvalidOperationException("there is no value for failure");
                    }
                    return _value!;
                }
                private init => _value = value;
            }
            public Error Error { get; }
            public static CustomResult<T> Success(T value)
            {
                return new CustomResult<T>(value);
            }
            public static CustomResult<T> Failure(Error error)
            {
                return new CustomResult<T>(error);
            }
        
    }
}
