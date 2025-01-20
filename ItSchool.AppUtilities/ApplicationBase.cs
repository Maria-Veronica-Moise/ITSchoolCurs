using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSchool.AppUtilities
{
    public abstract class ApplicationBase
    {
        public static List<ApplicationBase> Applications = new List<ApplicationBase>();

        public string Cerinta;

        public abstract void Launch();

    }
}
