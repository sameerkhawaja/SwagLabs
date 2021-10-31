using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public static class Constants
    {
        public const string WEBDRIVER = "webDriver";


        // normally these would go into appsettings or a credentials store
        // but for the sake of time I am placing credentials here
        public const string STANDARDUSERNAME = "standard_user";
        public const string STANDARDPASSWORD = "secret_sauce";

        public const string LOCKEDUSERNAME = "locked_out_user";
        public const string LOCKEDPASSWORD = "secret_sauce";

    }
}
