public class TreeNode<T>
{
    public T Data { get; set; }
    public List<TreeNode<T>> Children { get; set; }

    public TreeNode(T data)
    {
        Data = data;
        Children = new List<TreeNode<T>>();
    }

    public void AddChild(TreeNode<T> child)
    {
        Children.Add(child);
    }
}

public class Tree<T>
{
    public TreeNode<T> Root { get; set; }

    public Tree(T data)
    {
        Root = new TreeNode<T>(data);
    }
}

class Program
{
    static void Main()
    {
        Tree<string> tree = new Tree<string>("A");

        TreeNode<string> nodeB = new TreeNode<string>("B");
        TreeNode<string> nodeC = new TreeNode<string>("C");
        TreeNode<string> nodeD = new TreeNode<string>("D");

        TreeNode<string> nodeE = new TreeNode<string>("E");
        TreeNode<string> nodeF = new TreeNode<string>("F");

        tree.Root.AddChild(nodeB);
        tree.Root.AddChild(nodeC);
        tree.Root.AddChild(nodeD);

        nodeB.AddChild(nodeE);
        nodeB.AddChild(nodeF);

        TraverseTree(tree.Root);
        // Output: A B E F C D
    }

    static void TraverseTree(TreeNode<string> node)
    {
        Console.Write(node.Data + " ");

        foreach (var child in node.Children)
        {
            TraverseTree(child);
        }
    }
}