using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VitaFlow.Data;
using projeto_carlos.Models.Entities;

var services = new ServiceCollection();
services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite("Data Source=vitaFlow.db"));
var serviceProvider = services.BuildServiceProvider();
using var scope = serviceProvider.CreateScope();
var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

var all = await context.Psychologists.ToListAsync();
Console.WriteLine($"Total Psychologists: {all.Count}");

foreach (var p in all)
{
    Console.WriteLine($"Try find ID: {p.Id}");
    var found = await context.Psychologists.FirstOrDefaultAsync(x => x.Id == p.Id);
    Console.WriteLine($"Found by same ID? {found != null}");
    
    var lowerIdStr = p.Id.ToString().ToLower();
    var upperIdStr = p.Id.ToString().ToUpper();
    var foundLower = await context.Psychologists.FirstOrDefaultAsync(x => x.Id.ToString() == lowerIdStr);
    var foundUpper = await context.Psychologists.FirstOrDefaultAsync(x => x.Id.ToString() == upperIdStr);
    
    Console.WriteLine($"Found by Lowercase String? {foundLower != null}");
    Console.WriteLine($"Found by Uppercase String? {foundUpper != null}");
}
