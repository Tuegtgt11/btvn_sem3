using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThi1.Adapter
{
    class ApiURL
    {
        private readonly String baseURL = "";

        private static ApiURL instance;

        private ApiURL()
        {

        }
        public static ApiURL GetInstance()
        {
            if (instance == null)
            {
                instance = new ApiURL();
            }
            return instance;
        }
        public string GetApiHome()
        {
            return String.Format(baseURL + "");
        }
    }
}
