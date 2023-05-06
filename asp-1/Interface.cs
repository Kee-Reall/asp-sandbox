namespace asp_1
{
    public interface IDatabaseConfig
    {
        string Host { get; }
        int Port { get; }  
        string Name { get; }
        string User { get; }
        string Password { get; }

    }
}
