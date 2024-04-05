
var s1 = Singleton.GetInstance();
var s2 = Singleton.GetInstance();

Console.WriteLine(s1 == s2); 

public class Singleton
{
    private static Singleton? _instance;

    protected Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }

        return _instance;
    }
}