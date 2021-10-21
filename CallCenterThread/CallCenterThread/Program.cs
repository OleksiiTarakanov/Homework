using System;
using System.Threading;

namespace CallCenterThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Call call1 = new Call(0123456789, 1, 5000) { };
            Call call2 = new Call(0876543210, 2, 3000) { };
            Call call3 = new Call(554554455, 3, 7000) { };
            Call call4 = new Call(123, 4, 4000) { };

            Thread firstCallThread = new Thread(() => StartCall(call1));
            firstCallThread.Start();

            Thread secondCallThread = new Thread(() => StartCall(call2));
            secondCallThread.Start();

            StartCall(call3);
            StartCall(call4);
        }

        public static void StartCall(Call call)
        {
            Console.WriteLine($"start calling {call.Number} call ID = {call.Id}");
            Thread.Sleep(1500);
            call.Status = Statuses.Active;
            Console.WriteLine($"status call {call.Id} = {call.Status}");
            Thread.Sleep(call.Duration);
            call.Status = Statuses.Finished;
            Console.WriteLine($"call {call.Number} finished with status: {call.Status}. Duration {call.Duration} ms");
        }
    }
}
