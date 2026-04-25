class DepthFirstIterator : IIterator
{
    private Stack<LightNode> stack = new Stack<LightNode>();

    public DepthFirstIterator(LightNode root)
    {
        stack.Push(root);
    }

    public bool HasNext() => stack.Count > 0;

    public LightNode Next()
    {
        var node = stack.Pop();

        if (node is LightElementNode element)
        {
            foreach (var child in element.Children)
            {
                stack.Push(child);
            }
        }

        return node;
    }
}