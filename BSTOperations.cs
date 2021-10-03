using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    //Generic class
    public class BSTOperations<T> where T : IComparable
    {
        int count = 0;
        public T data;
        public BSTOperations<T> left = null, right = null;
        private bool result;

        public BSTOperations(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }


        //Insert Node in BST
        public void InsertData(T data)
        {

            T current = this.data;
            if (current.CompareTo(data) > 0)
            {
                count++;
                if (this.left == null)
                {

                    this.left = new BSTOperations<T>(data);
                    Console.WriteLine("Node-" + count + " " + this.left.data + "->" + this.data + "  (Left Insertion)");

                }
                else
                {

                    Console.WriteLine("\nNode-" + count + " " + this.left.data + "->" + this.data + " Go to Left");

                    this.left.InsertData(data);
                }
            }
            else
            {
                count++;
                if (this.right == null)
                {

                    this.right = new BSTOperations<T>(data);
                    Console.WriteLine("Node-" + count + " " + this.data + "<-" + this.right.data + "  (Right Insertion)");

                }
                else
                {

                    Console.WriteLine("\nNode-" + count + " " + this.data + "<-" + this.right.data + " Go to Right");

                    this.right.InsertData(data);
                }

            }
        }
        public void Size()
        {
            Console.WriteLine("\nSize of Binary Search Tree is {0}: ", (count + 1));
        }
        //Search a particular Node
        public bool Search(T data)
        {
            T current = this.data;
           

            if (current.Equals(data))
            {
                Console.WriteLine("Found " + current + " in BST!");
                result = true;
                return result;
            }
            if (data.CompareTo(current) < 0 && this.left != null)
            {
                result = this.left.Search(data);
            }
            if (data.CompareTo(current) > 0 && this.right != null)
            {
                result = this.right.Search(data);
            }
            if (this.left == null && this.right == null)
            {
                result = false;
            }
            return result;
        }


    }
}
