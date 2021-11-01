using System;
using System.Threading;
using System.Threading.Tasks;


namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Call call1 = new Call(0123456789, 1, 5000) { };
            Call call2 = new Call(0876543210, 2, 3000) { };
            Call call3 = new Call(554554455, 3, 7000) { };
            Call call4 = new Call(123, 4, 10000) { };

            var cancellationToken1 = new CancellationTokenSource();
            var token1 = cancellationToken1.Token;

            var cancellationToken2 = new CancellationTokenSource();
            var token2 = cancellationToken2.Token;

            var cancellationToken3 = new CancellationTokenSource();
            var token3 = cancellationToken3.Token;

            var cancellationToken4 = new CancellationTokenSource();
            var token4 = cancellationToken4.Token;

            var firstCall = StartCall(call1, token1);
            firstCall.ContinueWith((Task) => StartCall(call2, token2));
            var thirdCall = StartCall(call3, token3);
            var fourthCall = StartCall(call4, token4);

            Console.WriteLine("To stop call type 'S'");
            string str = Console.ReadLine();
            if (str == "S")
            {
                cancellationToken4.Cancel();
            }

            Console.ReadKey();
        }

        public static async Task StartCall(Call call, CancellationToken token)
        {
            try
            {
                Console.WriteLine($"start calling {call.Number} call ID = {call.Id}");
                call.Status = Statuses.Active;
                Console.WriteLine($"status call {call.Id} = {call.Status}");
                await Task.Delay(call.Duration, token);
                call.Status = Statuses.Finished;
                Console.WriteLine($"call {call.Id} finished with status: {call.Status}. Duration {call.Duration} ms");
            }
            catch (TaskCanceledException)
            {
                if (token.IsCancellationRequested)
                {
                    call.Status = Statuses.Canceled;
                    Console.WriteLine($"call {call.Id} canceled by token with status: {call.Status}");
                }
            }
        }
    }
}