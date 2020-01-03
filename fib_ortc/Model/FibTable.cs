using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_ortc.Model
{
    public class FibTable : IObservableCollection<FibEntry>
    {

        public event CollectionChangedDelegate CollectionChanged;

        private List<FibEntry> entries = new List<FibEntry>();

        public void AddEntry(FibEntry entry)
        {
            if (entries.FirstOrDefault(e => (e.BinaryForm == entry.BinaryForm)) != null)
                throw new Exception("This prefix is already in the FIB table.");
            entries.Add(entry);
            CollectionChanged?.Invoke();
        }

        public void RemoveEntry(FibEntry entry)
        {
            entries.Remove(entry);
            CollectionChanged?.Invoke();
        }

        public void ClearEntries()
        {
            entries.Clear();
            CollectionChanged?.Invoke();
        }
        public IEnumerator<FibEntry> GetEnumerator()
            => entries.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => entries.GetEnumerator();

        public void CreateFromFibTree(FibTree tree)
        {
            throw new NotImplementedException();
        }

    }
}
