/*
 * 输入二叉树，输出其镜像版本
 */

namespace ForOffer
{
    public class MirrorBinaryTree
    {

        public static void MirrorBinaryTreeFunc(BinaryTreeNode head)
        {
            if (head == null || (head.Left == null && head.Right == null))
            {
                return;
            }

            BinaryTreeNode tmpNode = head.Left;
            head.Left = head.Right;
            head.Right = tmpNode;

            if (head.Left != null)
            {
                MirrorBinaryTreeFunc(head.Left);
            }

            if (head.Right != null)
            {
                MirrorBinaryTreeFunc(head.Right);
            }
        }
    }
}