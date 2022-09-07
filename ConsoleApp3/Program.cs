

for (int i = 0; i < 10; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine("a" + i);
}
Console.WriteLine("read");
//var task = wait();
await wait();
Console.WriteLine("ok");
for (int i = 0; i < 10; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine("b" + i);
}

//await task;



async Task wait()
{
    for (int i = 0; i < 10; i++)
    {
        Thread.Sleep(1000);
        Console.WriteLine("c"+i);
    }
}

/*
Console.WriteLine(await print());
async Task<int> print()
{
    
    
    Thread.Sleep(1000);
    var task = num();
    Console.WriteLine("this=" + task);
    
    int rt = await task;

    
    return rt;
}

async Task<int> num()
{
    var task = Task.Delay(1000);
    await task;
    return 100;
}*/