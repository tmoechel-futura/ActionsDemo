namespace FS.Common.DataAccess.Repositories.Abstract;

public interface IConnectionStringSetter
{
    void SetConnectionString(string connectionString);
}

public abstract class ConnectionStringSetter : IConnectionStringSetter
{
    protected string ConnectionString = "";

    public void SetConnectionString(string connectionString)
        => ConnectionString = connectionString;
}
