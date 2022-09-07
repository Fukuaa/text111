// See https://aka.ms/new-console-template for more information
async Task<int> text(int i)
{
    int num = 0;
    await Task.Run(() =>
    {
        for (int j = 0; j < i; j++)
        {
            Thread.Sleep(500);
            Console.WriteLine("i:"+num+" id:"+Thread.CurrentThread.ManagedThreadId);
            num =+ j;
        }
    });
    return num;
}

text(5);
while (true)
{
    Thread.Sleep(1000);
    Console.WriteLine("_______");
}
