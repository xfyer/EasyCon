namespace ECP.Ast;

public class ForStatement : Expression
{
    public override T Accept<T>(IAstVisitor<T> visitor)
    {
        return visitor.VisitForState(this);
    }
}