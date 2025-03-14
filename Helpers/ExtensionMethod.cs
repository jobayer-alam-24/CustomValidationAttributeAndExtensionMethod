using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomValidationAttributeAndExtensionMethod.Helpers
{
    public static class ExtensionMethod
    {
        public static string GetUrl(this string value)
        {
            return value.Replace(" ", "_");
        }
    }
}