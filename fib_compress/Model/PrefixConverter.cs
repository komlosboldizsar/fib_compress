using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_compress.Model
{
    public static class PrefixConverter
    {

        public static string IpToBinary(string ipForm)
        {
            
            string[] parts = ipForm.Split('/');
            if (parts.Length != 2)
                throw new Exception("Format of prefix is invalid: must contain a network address and a prefix length.");

            string[] octets = parts[0].Split('.');
            if (octets.Length != 4)
                throw new Exception("Format of prefix is invalid: network address must contain 4 octets.");

            if (!int.TryParse(parts[1], out int prefixLength))
                throw new Exception("Format of prefix is invalid: invalid format of prefix length.");

            if ((prefixLength < 0) || (prefixLength > 32))
                throw new Exception("Format of prefix is invalid: prefix length must be an integer between 0 and 32.");

            string binaryForm = "";
            for (int i = 0; i < 4; i++)
            {
                if (!int.TryParse(octets[i], out int octetInt))
                    throw new Exception("Format of prefix is invalid: one of the octets is not an integer.");
                if ((octetInt < 0) || (octetInt > 255))
                    throw new Exception("Format of prefix is invalid: octets must be integers between 0 and 255.");
                binaryForm = binaryForm + Convert.ToString(octetInt, 2).PadLeft(8, '0');
            }

            return binaryForm.Substring(0, prefixLength);

        }

        public static string BinaryToIp(string binaryForm)
        {
            if (!IsValidBinaryForm(binaryForm))
                throw new Exception("Format of prefix is not a valid binary form.");
            string binaryForm32Length = binaryForm.PadRight(32, '0');
            string[] octets = new string[4];
            for (int i = 0; i < 4; i++)
                octets[i] = Convert.ToInt32(binaryForm32Length.Substring(i * 8, 8), 2).ToString();
            return string.Format("{0}/{1}", string.Join(".", octets), binaryForm.Length);
        }

        public static bool IsValidBinaryForm(string prefix)
        {
            if (prefix.Length > 32)
                return false;
            for (int i = 0; i < prefix.Length; i++)
                if (!((prefix[i] == '0') || (prefix[i] == '1')))
                    return false;
            return true;
        }

        public static bool IsValidIpForm(string prefix)
        {
            try
            {
                IpToBinary(prefix);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }

}
