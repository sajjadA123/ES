using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading;


namespace ES.Core.Module
{

    public static class CustomClaim
    {
        public const string DepCode = "DepCode";
        public const string DepMasterCode = "DepMasterCode";
        public const string PersonneliCode = "PersonneliCode";
        public const string Role = "Role";
    }
    public class CurrentUser
    {


        private IHttpContextAccessor _httpContextAccessor;
        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            Initialize();
        }
        public void Initialize()
        {
            if (this._httpContextAccessor.HttpContext?.User != null)
            {
                var user = this._httpContextAccessor.HttpContext.User;
                IsAuthenticated = user.Identity.IsAuthenticated;
                if (IsAuthenticated)
                {
                    _username = user.Identity.Name;
                    _claims = user.Claims.ToList();
                    _id = Convert.ToInt32(_claims.Single(x => x.Type == ClaimTypes.NameIdentifier).Value);
                    _name = _claims.SingleOrDefault(x => x.Type == ClaimTypes.GivenName)?.Value;
                    _depCode = _claims.SingleOrDefault(x => x.Type == CustomClaim.DepCode)?.Value ?? "0";
                    _depMasterCode = _claims.SingleOrDefault(x => x.Type == CustomClaim.DepMasterCode)?.Value ?? "0";
                    _personneliCode = _claims.SingleOrDefault(x => x.Type == CustomClaim.PersonneliCode)?.Value ?? "0";
                    _role = _claims.SingleOrDefault(x => x.Type == CustomClaim.Role)?.Value ?? "";
                    _taskManager = new TaskManager(_id);
                }

            }

        }

        private List<Claim> _claims;
        private string _username;
        private string _name;

        private int _id;
        private string _depCode;
        private string _depMasterCode;
        private string _personneliCode;
        private string _role;
        private TaskManager _taskManager;
        public bool IsAuthenticated { get; private set; }

        public string DisplayName
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _name;

            }
        }
        public int ID
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _id;
            }
        }

        public string DepCode
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _depCode;
            }
        }

        public string PersonneliCode
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _personneliCode;
            }
        }

        public string DepMasterCode
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _depMasterCode;
            }
        }

        public string Username
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _username;
            }
        }


        public TaskManager TaskManager
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _taskManager;
            }
        }


        public string Role
        {
            get
            {
                if (!IsAuthenticated)
                    Initialize();

                return _role;
            }

        }


    }
}
