namespace Pizzeria.Modules.Shared.Loggers;

//Tydzień 2, Wzorzec Singleton 2
//Wzorzec kreacyjny, zapewnia że istnieje dokładnie jedna instancja danej klasy oraz udostępnia ją globalnie
public class SimpleLogger
{
    private static SimpleLogger _instance;

    private SimpleLogger() { }

    public static SimpleLogger GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SimpleLogger();
        }
        return _instance;
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
}
