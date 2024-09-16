using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        Task task1 = DownloadFileAsync("File1.txt", 2000);
        Task task2 = DownloadFileAsync("File2.txt", 3000);
        Task task3 = DownloadFileAsync("File3.txt", 1000);

        await Task.WhenAll(task1, task2, task3);

        stopwatch.Stop();

        Console.WriteLine($"Total time taken: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task DownloadFileAsync(string fileName, int delayInMilliseconds)
    {
        await Task.Delay(delayInMilliseconds);
        Console.WriteLine($"Downloaded {fileName}");
    }
}