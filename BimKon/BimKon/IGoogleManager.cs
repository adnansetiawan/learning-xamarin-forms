using System;
using BimKon.Core.Models;

namespace BimKon.Core
{
    public interface IGoogleManager
    {
        void Login(Action<GoogleUser, string> OnLoginComplete);

        void Logout();
    }
}
