/*
 * 判断树是否是另一个树的一部分
 */

namespace ForOffer
{
    public class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
    }

    public class HasSubTree
    {
        public static bool HasSubTreeFunc(BinaryTreeNode Root1, BinaryTreeNode Root2)
        {
            bool result = false;

            if (Root1.Value == Root2.Value)
            {
                result = DoesTree1haveTree2(Root1, Root2);
            }
            if (!result)
            {
                HasSubTreeFunc(Root1.Left, Root2);
            }
            if (!result)
            {
                HasSubTreeFunc(Root1.Right, Root2);
            }

            return result;
        }

        private static bool DoesTree1haveTree2(BinaryTreeNode Root1, BinaryTreeNode Root2)
        {
            if (Root2 == null)
            {
                return true;
            }

            if (Root1 == null)
            {
                return false;
            }

            if (Root1.Value != Root2.Value)
            {
                return false;
            }

            return DoesTree1haveTree2(Root1.Left, Root2.Left) && DoesTree1haveTree2(Root1.Right, Root2.Right);
        }
    }
}