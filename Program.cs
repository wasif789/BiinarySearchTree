using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Searh Tree Program!\n");
            BSTOperations<int> obj = new BSTOperations<int>(56);
            obj.InsertData(30);
            obj.InsertData(70);
            obj.InsertData(22);
            obj.InsertData(40);
            obj.InsertData(11);
            obj.InsertData(3);
            obj.InsertData(16);
            obj.InsertData(60);
            obj.InsertData(95);
            obj.InsertData(65);
            obj.InsertData(63);
            obj.InsertData(67);

            //Print size of Tree to check if all elements have been inserted
            obj.Size();

            //Search a Particular Node using Recursion
            bool flag = obj.Search(63);
            if (!flag)
            {
                Console.WriteLine("Could not find Data in BST!");
            }
        }
    }
}
