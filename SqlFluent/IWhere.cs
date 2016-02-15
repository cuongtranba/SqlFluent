namespace SqlFluent
{
    public interface IWhere
    {
        IOperator Where(string value);
        IWhere OrderBy(string value);
    }
}
