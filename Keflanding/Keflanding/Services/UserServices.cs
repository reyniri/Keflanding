﻿/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using Keflanding.Models;
using Keflanding.IServices;
using System.Threading.Tasks;

namespace Keflanding.Services
{
    public class UserServices : IUserServices
    {
        public Task<bool> SignIn(User user)
        {
            return Task.Run(() => { return true; });
        }

        public Task<bool> SignUp(User user)
        {
            return Task.Run(() => { return true; });
        }

        public Task<bool> ForgotPassword(string Email)
        {
            return Task.Run(() => { return true; });
        }
    }
}
