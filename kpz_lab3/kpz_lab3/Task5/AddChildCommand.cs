class AddChildCommand : ICommand
{
    private LightElementNode parent;
    private LightNode child;

    public AddChildCommand(LightElementNode parent, LightNode child)
    {
        this.parent = parent;
        this.child = child;
    }

    public void Execute()
    {
        parent.AddChild(child);
    }
}