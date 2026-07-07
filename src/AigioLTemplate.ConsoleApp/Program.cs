namespace AigioLTemplate;

static partial class Program
{
    //[STAThread]
    static int Main(string[] args)
    {
        try
        {
            Console.WriteLine("Hello, World!");
            return 0;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.ToString());
            return 500;
        }
        finally
        {
            Console.WriteLine("输入回车以退出...");
            Console.ReadLine();
        }
    }
}