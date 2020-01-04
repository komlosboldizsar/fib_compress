using System;
using System.Collections.Generic;
using System.Text;

namespace fib_compress.Model
{

    public class FibTreeNode
    {

        public FibTreeLabel Label { get; set; }

        public string LabelText => Label?.Text;

        public FibTreeNode Parent { get; private set; }

        public Dictionary<string, FibTreeNode> Children { get; private set; } = new Dictionary<string, FibTreeNode>();

        public FibTreeNode(FibTreeNode parent)
        {
            Parent = parent;
        }

        public FibTreeNode(FibTreeNode parent, FibTreeNode child0, FibTreeNode child1)
        {
            Parent = parent;
            Children.Add("0", child0);
            Children.Add("1", child1);
        }

        public FibTreeNode GetChild(string edgeLabel)
        {
            if (!Children.TryGetValue(edgeLabel, out FibTreeNode child))
                return null;
            return child;
        }

        public FibTreeNode GetChild(int edgeLabel)
        {
            if ((edgeLabel == 0) || (edgeLabel == 1))
                return GetChild(string.Format("{0}", edgeLabel));
            return null;
        }

        public FibTreeNode AddChild(string edgeLabel, FibTreeLabel nodeLabel = null)
        {
            if (Children.ContainsKey(edgeLabel))
                throw new Exception("This node already contains a child with this edge label!");
            FibTreeNode newNode = new FibTreeNode(this);
            newNode.Label = nodeLabel;
            Children.Add(edgeLabel, newNode);
            return newNode;
        }

        public FibTreeNode AddChild(int edgeLabel, FibTreeLabel nodeLabel = null)
        {
            if ((edgeLabel == 0) || (edgeLabel == 1))
                return AddChild(string.Format("{0}", edgeLabel), nodeLabel);
            throw new Exception("Invalid integer edge label, only 0 and 1 are supported!");
        }

        public void ClearChildren()
        {
            Children.Clear();
        }

    }

}
