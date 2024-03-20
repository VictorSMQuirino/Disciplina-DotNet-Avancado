
var task1 = DoWorkAsync("Task 1", 10, 1000);
var task2 = DoWorkAsync("Task 2", 5, 2500);

await Task.WhenAll(task1, task2);

Console.WriteLine("Todas as taks foram concluídas.");

static async Task DoWorkAsync(string name, int iterations, int delay)
{
    for (var i = 1; i <= iterations; i++)
    {
        Console.WriteLine($"{name} - Iteração: {i}");
        await Task.Delay(delay);
    }
    Console.WriteLine($"Task {name} concluída.");
}