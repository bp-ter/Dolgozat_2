using ClassLibrary.Data;
using ClassLibrary.Models;


EmberContext _context = new EmberContext();

var sorok = File.ReadAllLines(@"C:\Users\Laptop\Desktop\Suli\Datas\3.csv").Skip(1);

if (!_context.Emberek.Any())
{
    foreach (var item in sorok)
    {
        Ember ember = new Ember(item);
        _context.Emberek.Add(ember);
    }
    _context.SaveChanges();
}

foreach (var item in _context.Emberek)
{
    Console.WriteLine(item);
    Console.WriteLine();
}