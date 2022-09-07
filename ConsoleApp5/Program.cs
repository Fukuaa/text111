// See https://aka.ms/new-console-template for more information





var task = printAsync();

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine("当前数字main"+i);
}

int answer = await task;
Console.WriteLine(answer);




async Task<int> printAsync()
{
    
    var task = Task.Run(() =>
    {
        int j = 0;
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            j += i;
            Console.WriteLine("当前数字print"+i);
        }

        return j;
    });
    int answer = await task;
    return answer;
}

Console.ReadLine();