class CountVisitor : IVisitor
{
    public int Count = 0;

    public void VisitText(LightTextNode text)
    {
        Count++;
    }

    public void VisitElement(LightElementNode element)
    {
        Count++;
    }
}