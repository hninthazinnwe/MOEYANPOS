using System;
using System.Collections.Generic;
using System.Linq;
using System. xt;

namespace MoeYanPOS.Function
{
    class MoeYanConfiguration
    {
        public static string GetConnection()
        {
            string conn = "";
            try
            {
                conn = MoeYanPOS.Properties.Settings.Default.MoeYanConStr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
