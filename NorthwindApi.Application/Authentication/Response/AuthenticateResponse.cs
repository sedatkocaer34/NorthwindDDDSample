﻿using NorthwindApi.Domain.Domain.Accounts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NorthwindApi.Application.Authentication.Response
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(Guid ıd, string name, string email, string token)
        {
            Id = ıd;
            Name = name;
            Email = email;
            Token = token;
        }
    }
}
