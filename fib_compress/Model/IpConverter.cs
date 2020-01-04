using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_compress.Model
{
    public static class IpConverter
    {

        public static string IpToBinary(string ip, string octetSeparator = "")
        {
            
            string[] octets = ip.Split('.');
            if (octets.Length != 4)
                throw new Exception("Format of IP address is invalid: must contain 4 octets.");

            string binaryForm = "";
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(octets[i], out int octetInt))
                    throw new Exception("Format of IP address is invalid: one of the octets is not an integer.");
                if ((octetInt < 0) || (octetInt > 255))
                    throw new Exception("Format of IP address is invalid: octets must be integers between 0 and 255.");
                binaryForm = binaryForm + Convert.ToString(octetInt, 2).PadLeft(8, '0');
                if (i != 3)
                    binaryForm += octetSeparator;
            }

            return binaryForm;

        }

    }

}
