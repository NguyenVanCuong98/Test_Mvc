using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mvc_Demo.Models.Process
{
    public class stringProcess
    {
        public string GenerateKey(string id)
        {
            string strKey = "";
            string numPart = "", strPart = "";
            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;

            int intPart = (Convert.ToInt32(numPart) + 1);
            for (int i = 0; i < numPart.Length - intPart.ToString().Length; i++)
            {
                strPart += "0";
            }
            strKey = strPart + intPart;
            return strKey;
        }
    }
}
