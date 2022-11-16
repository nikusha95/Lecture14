// See https://aka.ms/new-console-template for more information


Thread t1 = new Thread(Work1);
Thread t2 = new Thread(Work2);
Task tk1 = new Task(Work1);
Task tk2 = new Task(Work2);

tk1.Start();
tk2.Start();
// t1.Start();
// t2.Start();
// Work1();
// Work2();

static void Work1()
{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine("Work 1 is called " + i);
    }
}

static void Work2()

{
    for (int i = 1; i <= 100; i++)
    {
        Console.WriteLine("Work 2 is called " + i);
    }
}