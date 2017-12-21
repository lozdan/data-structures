/*
author: Daniel Lozano
*/

namespace MyDataStructures
{
	public class BinarySearchTree
    {
        private int value;
        private BinarySearchTree left, right;

        public int Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }

        public BinarySearchTree Left
        {
            get
            {
                return this.left;
            }

            set
            {
                this.left = value;
            }
        }

        public BinarySearchTree Right
        {
            get
            {
                return this.right;
            }

            set
            {
                this.right = value;
            }
        }

        public BinarySearchTree(int value)
        {
            this.value = value;
        }

        public void Add(int data)
        {
            if (data <= value)
            {
                if (Left == null)
                    Left = new BinarySearchTree(data);
                else
                    Left.Add(data);
            }
            else
            {
                if (Right == null)
                    Right = new BinarySearchTree(data);
                else
                    Right.Add(data);
            }  
        }
    }
}
