using System.Collections.Concurrent;

namespace Project_9
{
    internal class BonusAccount
    {
        private int _balance = 0;
        public int Balance => _balance;

        private static readonly SemaphoreSlim semaphore = new SemaphoreSlim(3);

        private static BlockingCollection<string> transaction = new BlockingCollection<string>(new ConcurrentQueue<string>());
        public BlockingCollection<string> Transactions => transaction;

        public async Task Add(string api)
        {
            await semaphore.WaitAsync();
            try
            {
                int threadId = Thread.CurrentThread.ManagedThreadId;
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Thread {threadId} >> {api}");

                for (int i =0; i<1000; i++)
                {
                    Interlocked.Increment(ref _balance);
                }

                await Task.Delay(2000);

                transaction.Add($"[{DateTime.Now:HH:mm:ss}] Thread {threadId} added 1000 points via {api}");
                
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Thread {threadId} << {api} - Balance: {Balance}");
            }
            finally
            {
                semaphore.Release();
            } 
        }
    }
}





