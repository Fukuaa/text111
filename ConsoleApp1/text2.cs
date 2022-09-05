namespace ConsoleApp1;

public class text2
{
    public async void text()
    {
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(1000);
            print(i);
        }
    }

    public int print(int i)
    {
        //Console.WriteLine(i);
        return i;
    }
}