using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvCenterShow.Helpers
{
    public static class GlobalHelper
    {
        public static string setBoolToString(bool boolParam)
        {
            var result= boolParam ? "*" : "";
            return result;
        }
    }


}
