// See https://aka.ms/new-console-template for more information

using TestEntityFramework;

Console.WriteLine("Hello, World!");

var db = new MyDbContext();
var jobs = db.Jobs.Select(p => new { p.Position, p.Salary }).ToList();
Console.WriteLine($"Found {jobs.Count} items.");

foreach (var job in jobs)
    Console.WriteLine($"-- {job.Position} -- {job.Salary}.");

Console.ReadLine();