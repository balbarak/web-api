using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DateWebApi.Models
{
    public class Date
    {
        public string GregorianDate { get; set; }

        public string HijriDate { get; set; }

        public string HijriDateFull { get; set; }

        public Date()
        {
            GregorianDate = DateTime.Now.ToString("dd-MM-yyyy", new CultureInfo("en-US"));

            HijriDate = DateTime.Now.ToString("dd-MM-yyyy", new CultureInfo("ar-SA"));

            HijriDateFull = DateTime.Now.ToString("dddd, dd MMMM, yyyy هـ", new CultureInfo("ar-SA"));
            
        }
    }
}
