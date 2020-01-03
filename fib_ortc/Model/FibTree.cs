using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_ortc.Model
{

    public class FibTree
    {

        public FibTreeNode Root { get; private set; }

        public LabelCollection Labels { get; private set; } = new LabelCollection();

        public void CreateFromFibTable(FibTable table)
        {

            Root = new FibTreeNode(null, null);
            Labels.Clear();

            foreach (FibEntry entry in table)
            {

                FibTreeNode node = Root;
                for (int i = 0; i < entry.BinaryForm.Length; i++)
                {

                    if (entry.BinaryForm[i] == '0')
                    {
                        if (node.Child0 == null)
                            node.Child0 = new FibTreeNode();
                        node = node.Child0;
                    }

                    if (entry.BinaryForm[i] == '1')
                    {
                        if (node.Child1 == null)
                            node.Child1 = new FibTreeNode();
                        node = node.Child1;
                    }

                }

                FibTreeLabel label = Labels.GetLabelByNextHop(entry.NextHop);
                if (label == null)
                    label = Labels.AddLabelForNextHop(entry.NextHop);
                node.Label = label;

            }

            TreeChanged?.Invoke();

        }

        public void CreateFromFibTreeByOrtc(FibTree tree)
        {
            throw new NotImplementedException();
        }

        public delegate void TreeChangedDelegate();
        public event TreeChangedDelegate TreeChanged;

        public class LabelCollection : IObservableCollection<FibTreeLabel>
        {

            private List<FibTreeLabel> labels = new List<FibTreeLabel>();

            public event CollectionChangedDelegate CollectionChanged;

            public FibTreeLabel GetLabelByText(string labelText)
            {
                return labels.FirstOrDefault(l => (l.Text == labelText));
            }

            public FibTreeLabel GetLabelByNextHop(string nextHop)
            {
                return labels.FirstOrDefault(l => (l.NextHop == nextHop));
            }

            public FibTreeLabel AddLabelForNextHop(string nextHop)
            {
                if (GetLabelByNextHop(nextHop) != null)
                    throw new Exception("This next hop is already in the table and has a label.");
                string newLabelText = ((char)((int)'a' + labels.Count)).ToString();
                FibTreeLabel newLabel = new FibTreeLabel(newLabelText, nextHop);
                labels.Add(newLabel);
                CollectionChanged?.Invoke();
                return newLabel;
            }

            public void Clear()
            {
                labels.Clear();
                CollectionChanged?.Invoke();
            }

            public IEnumerator<FibTreeLabel> GetEnumerator()
                => labels.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => labels.GetEnumerator();

        }

    }

}
