using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;

namespace EFWCF.WebWCF
{
    public class MyCustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            // validate arguments 

            if (string.IsNullOrEmpty(userName))

                throw new ArgumentNullException("userName");

            if (string.IsNullOrEmpty(password))

                throw new ArgumentNullException("password");



            // check if the user is not xiaozhuang 

            if (userName != "sa" || password != "sa!@#")

                throw new SecurityTokenException("用户名或者密码错误！");

        }
    }
}