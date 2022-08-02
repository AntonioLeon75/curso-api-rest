public interface ISaluteService
{
    string GetSalute();
}

class SaluteService : ISaluteService
{
    public string GetSalute()
    {
        return "Hello again!!!";
    }
}