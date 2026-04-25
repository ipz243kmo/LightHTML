class VisibleState : IState
{
    public string Handle(LightElementNode node)
    {
        return node.InnerHTML;
    }
}

class HiddenState : IState
{
    public string Handle(LightElementNode node)
    {
        return "";
    }
}