﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BankingPortal.Models;

namespace BankingPortal.Services
{
    public interface IAuthService
    {
        bool Login(string username, string password);
        bool Register(string firstname, string lastname, string email, long contactno, string location);
        string ForgotPassword(string username);
        bool ResetPassword(string username, string oldPassword, string newPassword);
    }
}
