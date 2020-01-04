using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fib_compress.Model
{

    public class FibTree
    {

        public FibTreeNode Root { get; private set; }

        public LabelCollection Labels { get; private set; } = new LabelCollection();

        public void CreateFromFibTable(FibTable table)
        {

            Root = new FibTreeNode(null);
            Labels.Clear();

            foreach (FibEntry entry in table)
            {

                FibTreeNode node = Root;
                for (int i = 0; i < entry.BinaryForm.Length; i++)
                {
                    int edgeLabel = entry.BinaryForm[i] - (int)'0';
                    if (node.GetChild(edgeLabel) == null)
                        node.AddChild(edgeLabel);
                    node = node.GetChild(edgeLabel);
                }

                FibTreeLabel label = Labels.GetLabelByNextHop(entry.NextHop);
                if (label == null)
                    label = Labels.AddLabelForNextHop(entry.NextHop);
                node.Label = label;

            }

            TreeChanged?.Invoke();

        }

        public void CreateFromFibTreeAndNormalize(FibTree tree)
        {
            Root = new FibTreeNode(null);
            Labels.Clear();
            copyNodeAndChildrens(Root, tree.Root);
            normalize();
            TreeChanged?.Invoke();
        }

        private void normalize()
        {
            normalize_CreateLeaves(Root, null);
            normalize_RemoveInteriorLabels(Root);
            normalize_Reduce(Root);
        }

        private void normalize_CreateLeaves(FibTreeNode node, FibTreeLabel nearestLabel)
        {

            if (node.Children.Count == 0)
                return;
            
            if (node.Label != null)
                nearestLabel = node.Label;

            if (node.Children.Count == 1)
            {
                string notExistingEdgeLabel = string.Format("{0}", (int)'1' - (int)node.Children.ToList()[0].Key[0]);
                node.AddChild(notExistingEdgeLabel, nearestLabel);    
            }

            normalize_CreateLeaves(node.GetChild(0), nearestLabel);
            normalize_CreateLeaves(node.GetChild(1), nearestLabel);

        }

        private void normalize_RemoveInteriorLabels(FibTreeNode node)
        {
            if (node.Children.Count == 0)
                return;
            foreach (FibTreeNode child in node.Children.Values)
                normalize_RemoveInteriorLabels(child);
            node.Label = null;
        }

        private void normalize_Reduce(FibTreeNode node)
        {

            if (node.Children.Count == 0)
                return;

            List<FibTreeLabel> usedLabels = new List<FibTreeLabel>();
            foreach (FibTreeNode child in node.Children.Values)
            {
                normalize_Reduce(child);
                if (!usedLabels.Contains(child.Label))
                    usedLabels.Add(child.Label);
            }

            if (usedLabels.Count == 1)
            {
                node.ClearChildren();
                node.Label = usedLabels[0];
            }

        }

        public void CreateFromNormalizedFibTreeAndCompress(FibTree tree)
        {

            // TODO: this just copies the tree
            Root = new FibTreeNode(null);
            Labels.Clear();

            copyNodeAndChildrens(Root, tree.Root);

            TreeChanged?.Invoke();

        }

        private void copyNodeAndChildrens(FibTreeNode to, FibTreeNode from)
        {

            foreach (KeyValuePair<string, FibTreeNode> child in from.Children)
            {
                FibTreeNode newNode = to.AddChild(child.Key);
                copyNodeAndChildrens(newNode, child.Value);
            }

            if (from.Label != null)
            {
                FibTreeLabel label = Labels.GetLabelByNextHop(from.Label.NextHop);
                if (label == null)
                    label = Labels.AddLabelForNextHop(from.Label.NextHop);
                to.Label = label;
            }

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
