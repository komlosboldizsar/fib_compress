using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_compress.Model
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
            entries.Clear();
            addTreeNodeAndChildren(tree.Root);
            CollectionChanged?.Invoke();
        }

        private void addTreeNodeAndChildren(FibTreeNode node, string binaryPath = "")
        {

            if (node.Label != null)
            {
                FibEntry newEntry = new FibEntry(binaryPath, node.Label.NextHop);
                entries.Add(newEntry);
            }

            if (node.Child0 != null)
                addTreeNodeAndChildren(node.Child0, binaryPath + "0");
            if (node.Child1 != null)
                addTreeNodeAndChildren(node.Child1, binaryPath + "1");

        }

    }
}
