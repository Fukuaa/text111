t1();
Console.Read();
async Task t1()
{
    var task = t2(3,4);
    int answer = await task;
    Console.WriteLine(answer);
}
async Task<int> t2(int i,int j)
{
    var task = t3(i,j);
    int answer = await task;
    return answer;
}
async Task<int> t3(int i,int j)
{
    var task = Task.Delay(1000);
    await task;
    int answer = i * j;
    return answer;
}
