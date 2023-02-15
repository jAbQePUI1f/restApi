using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityObjects;

namespace restApi.config
{
    internal class LogoApplication
    {
        private static UnityApplication unityApplication { get; set; }

        public static UnityApplication getApplication()
        {
            if (unityApplication == null)
                unityApplication = new UnityApplication();
            return unityApplication;
        }
    }
}