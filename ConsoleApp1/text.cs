namespace ConsoleApp1;

public class text
{
    public async Task run(string s)
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                //Console.WriteLine("run:"+i);
                Console.WriteLine("name:"+s+ "线程id："+Thread.CurrentThread.ManagedThreadId.ToString()+"线程池："+ThreadPool.ThreadCount);
            }
        });
    }
    public void I()
    {
        
    }
}