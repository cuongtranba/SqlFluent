namespace SqlFluent
{
    public interface IBaseStatement:IFrom,ISelect,IWhere,IOperator
    {
        string ToString();
    }
}
