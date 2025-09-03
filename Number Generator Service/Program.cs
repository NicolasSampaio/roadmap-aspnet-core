var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Funcionando");
app.MapGet("/random", (int min, int max, int quantity) =>
{
    var random = new Random();
    var randomNumbersList = new List<int>();
    for (int i = 0; i < quantity; i++)
    {
        randomNumbersList.Add(random.Next(min, max));
    }
    return randomNumbersList;
});

app.Run();

