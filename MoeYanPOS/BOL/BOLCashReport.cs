﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 amespace MoeYanPOS.BOL
{
    class BOLCashReport
    {
        private string header;
        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Header
        {
            get { return header; }
            set { header = value; }
        }
    }
}
