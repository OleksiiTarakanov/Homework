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

            var firstCall = StartCall(call1);
            firstCall.ContinueWith((Task) => StartCall(call2));
            var thirdCall = StartCall(call3);
            var fourthCall = StartCall(call4);

            Console.ReadKey();
        }

        public static async Task StartCall(Call call)
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            var token = cancellationToken.Token;

            Console.WriteLine($"start calling {call.Number} call ID = {call.Id}");
            call.Status = Statuses.Active;
            Console.WriteLine($"status call {call.Id} = {call.Status}");
            await Task.Delay(call.Duration);
            if ( call.Duration > 8000 )
            {
                cancellationToken.Cancel();
                call.Status = Statuses.Canceled;
                Console.WriteLine($"call {call.Id} finished with status: {call.Status}");
            } else
            {
                call.Status = Statuses.Finished;
                Console.WriteLine($"call {call.Id} finished with status: {call.Status}. Duration {call.Duration} ms");
            }
            
            
        }
    }
}
