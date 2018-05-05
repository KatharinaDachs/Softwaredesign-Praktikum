using System;
using System.Collections.Generic;

namespace L04_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<String>();
            var root = tree.CreateNode("root");
            var child1 = tree.CreateNode("child1");
            var child2 = tree.CreateNode("child2");
            root.AppendChild(child1);
            root.AppendChild(child2);
            var grand11 = tree.CreateNode("grand11");
            var grand12 = tree.CreateNode("grand12");
            var grand13 = tree.CreateNode("grand13");
            child1.AppendChild(grand11);
            child1.AppendChild(grand12);
            child1.AppendChild(grand13);
            var grand21 = tree.CreateNode("grand21");
            child2.AppendChild(grand21);
            child1.RemoveChild(grand12);

            root.PrintTree();  

            foreach (var element in root.Found("grand111"))
            {
                Console.WriteLine(element);
}
        }
    }
    // Für genauere Erklärung : Bene fragen
    // Zusätzliche Aufgabe: Find("abc") Liste mit KNoten mit Inhalt "abc"

    public class Tree<T>
    {
        public T Data;
        public List<Tree<T>> Children = new List<Tree<T>>();

        public List<Tree<T>> FIND = new List<Tree<T>>();

        public Tree<T> CreateNode(T data)
        {
            Tree<T> newNode = new Tree<T>
            {
                Data = data
            };
            return newNode;
        }

        public void RemoveChild(Tree<T> child)
        {
            Children.Remove(child);
        }

        public void AppendChild(Tree<T> child)
        {
            Children.Add(child);
        }

        public void PrintTree(String add ="")
        {
            Console.WriteLine(add + Data);

            foreach(Tree<T> child in Children)
                child.PrintTree(add + "*");
        }

        public List<Tree<T>> Found(T search, List<Tree<T>> Nodes = null)
        {
            if (Nodes == null)
            {
                Nodes = new List<Tree<T>>();
            }
            if (Data.Equals(search))
            {
                Nodes.Add(this);
            }
            foreach (Tree<T> child in Children)
            {
                child.Found(search, Nodes);
            }
            return Nodes;
        }
        
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}