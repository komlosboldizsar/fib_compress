using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib_compress.Model
{

    public static class FibTablePersister
    {

        public static void ReadFromFile(this FibTable table, string file)
        {
            table.ClearEntries();
            string[] lines = File.ReadAllLines(file);
            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        string prefix = parts[0].Replace("\"", "");
                        string nextHop = parts[1].Replace("\"", "");
                        table.AddEntry(new FibEntry(prefix, nextHop, null));
                    }
                }
            }
        }

        public static void WriteToFile(this FibTable table, string file)
        {
            List<string> lines = new List<string>();
            foreach (FibEntry fibEntry in table)
                lines.Add(string.Format("{0},{1}", fibEntry.IpForm, fibEntry.NextHop));
            File.WriteAllLines(file, lines.ToArray());
        }

    }

}
