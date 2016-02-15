namespace SqlFluent
{
    public interface ISelect
    {
        /// <summary>
        /// columns name for table  
        /// </summary>
        /// <param name="values">columns name for table ex:value1,value2,value3</param>
        /// <returns></returns>
        IFrom Select(string values);
    }
}
