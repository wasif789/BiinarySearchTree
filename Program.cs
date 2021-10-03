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
        }
    }
}
