interface IVisitor
{
    void VisitText(LightTextNode text);
    void VisitElement(LightElementNode element);
}