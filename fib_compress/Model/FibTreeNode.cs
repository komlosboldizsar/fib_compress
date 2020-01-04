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

        public int? EdgeLabelLength { get; private set; } = null;
        public int NodeCount
        {
            get
            {
                int nodeCount = 1;
                foreach (FibTreeNode child in Children.Values)
                    nodeCount += child.NodeCount;
                return nodeCount;
            }
        }

        public int EdgeCount => NodeCount - 1;

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

        public List<FibTreeNode> GetChildrenAtLevel(int level)
        {
            if (level == 0)
                return new List<FibTreeNode>() { this };
            List<FibTreeNode> childrenAtLevel = new List<FibTreeNode>();
            foreach (FibTreeNode child in Children.Values)
                childrenAtLevel.AddRange(child.GetChildrenAtLevel(level - 1));
            return childrenAtLevel;
        }

        public int GetDepth()
        {
            int depth = 0;
            foreach (FibTreeNode child in Children.Values)
            {
                int childDepth = child.GetDepth() + 1;
                if (childDepth > depth)
                    depth = childDepth;
            }
            return depth;
        }

        public string GetEdgeLabelForChild(FibTreeNode childNode)
        {
            foreach (KeyValuePair<string, FibTreeNode> childEntry in Children)
                if (childEntry.Value == childNode)
                    return childEntry.Key;
            return null;
        }
        public FibTreeNode AddChild(string edgeLabel, FibTreeLabel nodeLabel = null)
        {
            if (Children.ContainsKey(edgeLabel))
                throw new Exception("This node already contains a child with this edge label!");
            if (EdgeLabelLength == null)
                EdgeLabelLength = edgeLabel.Length;
            if (edgeLabel.Length != EdgeLabelLength)
                throw new Exception(string.Format("Edge labels in this node must be {0} character(s) long.", EdgeLabelLength));
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

        public List<FibTreeLabel> AllLabelsInSubtree()
        {
            List<FibTreeLabel> labels = new List<FibTreeLabel>();
            labels.Add(Label);
            foreach (FibTreeNode child in Children.Values)
                labels.AddRange(child.AllLabelsInSubtree());
            return labels;
        }

        public List<FibTreeLabel> AllLabelsInSubtreeUnique()
        {
            List<FibTreeLabel> allLabels = AllLabelsInSubtree();
            List<FibTreeLabel> allLabelsUnique = new List<FibTreeLabel>();
            foreach (FibTreeLabel label in allLabels)
                if (!allLabelsUnique.Contains(label))
                    allLabelsUnique.Add(label);
            return allLabelsUnique;
        }

    }

}
