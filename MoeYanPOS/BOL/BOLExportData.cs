using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 amespace MoeYanPOS.BOL
{
    class BOLExportData
    {

        private DateTime dtpfromdate;
        private DateTime dtptodate;

        public DateTime DtpFromDate
        {
            get { return dtpfromdate; }
            set { dtpfromdate = value; }
        }

        public DateTime DtpToDate
        {
            get { return dtptodate; }
            set { dtptodate = value; }
        }
    }
}
