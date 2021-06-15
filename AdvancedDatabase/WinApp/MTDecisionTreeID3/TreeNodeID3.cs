using System;
using System.Collections;

namespace MTDecisionTreeID3
{
    public class TreeNodeID3
    {
        private TreeNodeID3 mParentNode = null;
        private ArrayList mChilds = null;
        private AttributeID3 mAttribute;
        private Guid mNodeId = Guid.Empty;

        public TreeNodeID3(AttributeID3 attribute)
        {
            if (attribute != null && attribute.Values != null)
            {
                mChilds = new ArrayList(attribute.Values.Length);
                for (int i = 0; i < attribute.Values.Length; i++)
                    mChilds.Add(null);
            }
            else
            {
                mChilds = new ArrayList(1);
                mChilds.Add(null);
            }
            mAttribute = attribute;
        }

        public void AddTreeNode(TreeNodeID3 treeNode, string value)
        {
            int index = mAttribute.IndexValue(value);
            treeNode.NodeId = Guid.NewGuid();
            mNodeId = treeNode.NodeId;
            mChilds[index] = treeNode;
        }

        public TreeNodeID3 ParentNode
        {
            get
            {
                return mParentNode;
            }
            set
            {
                 mParentNode = value;
            }
        }

        public Guid NodeId
        {
            get
            {
                return mNodeId;
            }
            set
            {
                mNodeId = value;
            }
        }

        public AttributeID3 Attribute
        {
            get
            {
                return mAttribute;
            }
        }

        public TreeNodeID3 GetChildByBranchName(string branchName)
        {
            int index = mAttribute.IndexValue(branchName);
            return mChilds[index] as TreeNodeID3;
        }
    }
}
