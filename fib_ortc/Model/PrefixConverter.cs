using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_ortc.Model
{
    public static class PrefixConverter
    {

        public static string IpToBinary(string ipForm)
        {
            
            string[] parts = ipForm.Split('/');
            if (parts.Length != 2)
                throw new Exception();

            string[] octets = parts[0].Split('.');
            if (parts.Length != 4)
                throw new Exception();

            if (!int.TryParse(parts[1], out int prefixLength))
                throw new Exception();

            if ((prefixLength < 0) || (prefixLength > 32))
                throw new Exception();

            string binaryForm = "";
            for (int i = 0; i < 3; i++)
            {
                if (!int.TryParse(octets[i], out int octetInt))
                    throw new Exception();
                if ((octetInt < 0) || (octetInt > 32))
                    throw new Exception();
                binaryForm = binaryForm + Convert.ToString(octetInt, 2).PadLeft(8, '0');
            }

            return binaryForm.Substring(0, prefixLength);

        }

        public static string BinaryToIp(string binaryForm)
        {
            if (!IsValidBinaryForm(binaryForm))
                throw new Exception();
            string binaryForm32Length = binaryForm.PadRight(32, '0');
            string[] octets = new string[4];
            for (int i = 0; i < 3; i++)
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
