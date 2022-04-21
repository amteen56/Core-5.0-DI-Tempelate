using Core.Delegates;
using Core.DTOs;
using Core.Entities;
using Core.Interface.Service;
using Core.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infra.Services
{
    public class AuthService : IAuthService
    {
        IAppLogger oLogger;
        public AuthService( IAppLogger logger)
        {
            oLogger = logger;
        }
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }
        public async Task<Response<AuthenticationResponse>> Login(AuthenicationParam oReq, GenrateTokenDelgate tokenGenrator)
        {
            AuthenticationResponse response = new AuthenticationResponse();
            //response.UserId = null;
            //    Regex ValidEmailRegex = CreateValidEmailRegex();
            //    bool isValid = ValidEmailRegex.IsMatch(oReq.UserID);
            //    if (isValid)
            //    {
            //        var a = dbContext.UserSetups.Where(a => a.EMAIL.Equals(oReq.UserID)).FirstOrDefault();
            //        if (a != null)
            //            oReq.UserID = a.USER_ID;
            //        else
            //        {
            //            response.ErrorMsg = $"No Accounts Registered with {oReq.UserID}.";
            //            return new Response<AuthenticationResponse>(response, $"error");
            //        }
            //    }
            //    if (oReq.UserID == null)
            //    {
            //        response.ErrorMsg = $"No Accounts Registered with {oReq.UserID}.";
            //        return new Response<AuthenticationResponse>(response, $"error");
            //    }

            //    AES aes = new AES();
            //    var user = await dbContext.UserSetups.FindAsync(oReq.UserID);
            //    if (user == null)
            //    {
            //        response.ErrorMsg = $"No Accounts Registered with {oReq.UserID}.";
            //        return new Response<AuthenticationResponse>(response, $"error");
            //    }
            //    try
            //    {
            //        if (aes.DecryptString(user.USER_PASSWORD, oReq.UserID) != aes.DecryptString(oReq.Password, oReq.UserID))
            //        {
            //            response.ErrorMsg = $"Invalid Password for {oReq.UserID}.";
            //            return new Response<AuthenticationResponse>(response, $"error");
            //        }
            //    }
            //    catch (Exception ee)
            //    {
            //        response.ErrorMsg = $"Invalid Password for {oReq.UserID}.";
            //        return new Response<AuthenticationResponse>(response, $"error");
            //    }

            //    string jwtToken = tokenGenrator(user);
            //    response.UserId = user.USER_ID;
            //    response.JWToken = jwtToken;
            //    response.UserName = user.USER_NAME;
            //    response.IsVerified = true;
            //    var activeDevices = GetActiveDeviceIDs(oReq.UserID);
            //    if (activeDevices.Count() != 0)
            //    {
            //        foreach (var a in GetActiveDeviceIDs(oReq.UserID))
            //        {
            //            if (a.DEVICE_ID != oReq.DeviceID)
            //            {
            //                user.FIREBASE_TOKEN = null;
            //                var statusupdate = dbContext.DEVICE_STATE.Where(o => o.USER_ID == oReq.UserID && o.STATUS == "Y").ToList();
            //                statusupdate.ForEach(a => a.STATUS = "N");
            //                dbContext.SaveChangesAsync();
            //                break;
            //            }
            //        }

            //    }
            //    var updateCurrentStatus = dbContext.DEVICE_STATE.Where(o => o.DEVICE_ID == oReq.DeviceID && o.USER_ID == oReq.UserID).ToList();
            //    if (updateCurrentStatus.Count == 0)
            //    {
            //        APP_DEVICE_STATE obj = new APP_DEVICE_STATE();
            //        user.FIREBASE_TOKEN = null;
            //        obj.USER_ID = oReq.UserID;
            //        obj.STATUS = "Y";
            //        obj.DEVICE_ID = oReq.DeviceID;
            //        dbContext.DEVICE_STATE.Add(obj);
            //        dbContext.SaveChangesAsync();
            //    }
            //    else
            //    {
            //        updateCurrentStatus.FirstOrDefault().STATUS = "Y";
            //        dbContext.SaveChangesAsync();
            //    }


            //    response.FirebaseToken = null;
            //    if (string.IsNullOrWhiteSpace(user.TOKEN) || (user.TOKEN_EXPIRY != null && DateTime.UtcNow > user.TOKEN_EXPIRY))
            //    {
            //        var oNewToken = GenerateRefreshToken();
            //        user.TOKEN = oNewToken.JWToken;
            //        user.TOKEN_EXPIRY = oNewToken.Expires;
            //        user.TOKEN_CREATED_ON = oNewToken.Created;
            //        dbContext.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //        dbContext.SaveChanges();
            //    }
            //    response.RefreshToken = user.TOKEN;
            //    //var wwwroot = _environment.WebRootPath;
            //    //var favicon = Path.Combine(wwwroot, "favicon.ico");
            //    //var favicon2 = Path.Combine(wwwroot, "favicon2.ico");

            //    // true
            //    //var exists = System.IO.File.Exists(favicon)
            //    //if (user.PROFILE_IMAGE == )
            //    response.Image = user.PROFILE_IMAGE;

            USERSETUP user = new USERSETUP();
            user.USER_ID = "AM";
            user.USER_NAME = "Abdul";
            string jwtToken = tokenGenrator(user);
            return new Response<AuthenticationResponse>(response, $"Authenticated    {jwtToken}");
        }
        
    }
}
