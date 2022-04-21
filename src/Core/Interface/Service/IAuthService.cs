using Core.Delegates;
using Core.DTOs;
using Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Service
{
    public interface IAuthService
    {
        Task<Response<AuthenticationResponse>> Login(AuthenicationParam oReq, GenrateTokenDelgate tokenGenrator);
    }
}
