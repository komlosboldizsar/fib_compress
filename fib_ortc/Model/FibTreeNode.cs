using System;
using System.Collections.Generic;
using System.Text;

namespace fib_ortc.Model
{

    public class FibTreeNode
    {

        public FibTreeLabel Label { get; private set; }

        public string LabelText => Label?.Text;

        public FibTreeNode Child0 { get; private set; }

        public FibTreeNode Child1 { get; private set; }

        public FibTreeNode(FibTreeNode child0, FibTreeNode child1)
        {
            Child0 = child0;
            Child1 = child1;
        }

    }

}
