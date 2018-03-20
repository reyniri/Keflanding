/// Mohamed Ali NOUIRA
/// http://www.sweetmit.com
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using Keflanding.Models;
using System.Threading.Tasks;

namespace Keflanding.IServices
{
    public interface IUserServices
    {
        Task<bool> SignIn(User user);
        Task<bool> SignUp(User user);
        Task<bool> ForgotPassword(String Email);
    }
}
