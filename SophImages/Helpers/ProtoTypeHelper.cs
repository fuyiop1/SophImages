using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SophImages.Helpers
{
    public static class ProtoTypeHelper
    {
        public static int TryToParseInt(string intString, int failValue = 0)
        {
            var result = 0;
            if (!int.TryParse(intString, out result))
            {
                result = failValue;
            }
            return result;
        }
    }
}