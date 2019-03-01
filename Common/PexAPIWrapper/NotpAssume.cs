using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Pex.Framework;

namespace PexAPIWrapper
{
    public static class NotpAssume
    {
        public static void IsTrue(bool cond)
        {
            PexAssume.IsTrue(cond);
        }
    }
}
