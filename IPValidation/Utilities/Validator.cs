using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPValidation.Utilities
{
    public class Validator
    {

        /// <summary>
        /// Validate IP Address
        ///     - Leading zeros (e.g. 01.02.03.04) are considered invalid
        ///     - four octets -> values between 0 and 255
        /// </summary>
        /// <param name="ip">192.168.123.100</param>
        /// <returns>bool</returns>
        public static bool IsValidIP(string? ip)
        {
            if (string.IsNullOrEmpty(ip) || !ip.Contains('.'))
            {                
                return false;
            }

            //IPs should be considered valid if they consist of four octets
            var octets = ip.Split('.');
            if (octets.Length != 4)
            {
                return false;
            }            

            //Leading zeros (e.g. 01.02.03.04) are considered invalid
            foreach(var octet in octets)
            {
                var length = octet.Length;
                if (length > 3)
                {
                    return false;
                }

                if (octet.StartsWith("0") && length > 1)
                {
                    return false;
                }

                var sucess = int.TryParse(octet, out int value);

                if (!sucess)
                {
                    return false;
                }
                if(value > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
