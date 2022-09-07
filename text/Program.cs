t1();
Console.Read();
async Task t1()
{
    Thread.Sleep(4000);
    Console.WriteLine("t1");
    var task = t2(3,4);
    int answer = await task;
    Console.WriteLine(answer);
}
async Task<int> t2(int i,int j)
{
    Thread.Sleep(4000);
    Console.WriteLine("t2");
    var task = t3(i,j);
    int answer = await task;
    return answer;
    
}
async Task<int> t3(int i,int j)
{
    Thread.Sleep(4000);
    int answer = i * j;
    Console.WriteLine("t3");
    var task = Task.Delay(10000);
    await task;
    return answer;
}
