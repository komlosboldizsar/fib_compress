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

        public void SortEntries()
        {
            entries.Sort((x, y) => {
                string bx = x.BinaryForm;
                string by = y.BinaryForm;
                if (bx.Length != by.Length)
                    return bx.Length.CompareTo(by.Length);
                return bx.CompareTo(by);
            });
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

            foreach (KeyValuePair<string, FibTreeNode> child in node.Children)
                addTreeNodeAndChildren(child.Value, binaryPath + child.Key);

        }

    }
}
