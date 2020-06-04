using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Runtime;


[assembly: AllowPartiallyTrustedCallers]


    public sealed class ReportUtils
    {
        public static string ReportFooter()
        {
            return "Printed " +
                DateTime.Now.ToString("dd-MMM-yyyy HH:mm") +
                " by " + Environment.UserName;
        }
    }