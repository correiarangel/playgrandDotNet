

using explorefile.Models;

internal class Program
{
    const string path = "../files/fileTest.txt";

    private static void Main(string[] args)
    {
        ExploreModels model = new ExploreModels();
        model.LineRead(path);
        model.MethodOne ();
    }
}