namespace SqlFluent
{
    public interface IOperator
    {
        string And(string value);
        string Or(string value);
        string Like(string value);
        string NotLike(string value);
        string Between(string value1, string value2);
    }
}
