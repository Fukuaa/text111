// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using ConsoleApp1;

/*text2 text2 = new text2();
text2.text();
for (int i = 0; i < 100; i++)
{
    Thread.Sleep(1000);
    Console.WriteLine("text"+i);
}*/
ThreadPool.SetMinThreads(0, 0);
ThreadPool.SetMaxThreads(3, 3);
text text = new text();
//await text.run();
//await text.run("t1");
text.run("t3");
text.run("t2");
new Thread(() =>
{
    for (int i = 0; i < 100; i++)
    {
        Thread.Sleep(100);
        Console.WriteLine("newtext线程数："+ThreadPool.ThreadCount+"线程id:"+Thread.CurrentThread.ManagedThreadId.ToString());
    }
}).Start();
new Thread(() =>                                                                                                            
{                                                                                                                           
    for (int i = 0; i < 100; i++)                                                                                           
    {                                                                                                                       
        Thread.Sleep(100);                                                                                                  
        Console.WriteLine("newt2线程数："+ThreadPool.ThreadCount+"线程id:"+Thread.CurrentThread.ManagedThreadId.ToString());    
    }                                                                                                                       
}).Start();                                                                                                                 
new Thread(() =>                                                                                                           
{                                                                                                                          
    for (int i = 0; i < 100; i++)                                                                                          
    {                                                                                                                      
        Thread.Sleep(100);                                                                                                 
        Console.WriteLine("newt3线程数："+ThreadPool.ThreadCount+"线程id:"+Thread.CurrentThread.ManagedThreadId.ToString());     
    }                                                                                                                      
}).Start();                                                                                                                
for (int i = 0; i < 100; i++)
{
    Thread.Sleep(100);
    Console.WriteLine("text线程数："+ThreadPool.ThreadCount+"线程id:"+Thread.CurrentThread.ManagedThreadId.ToString());
    //Console.WriteLine("text:"+i);
}