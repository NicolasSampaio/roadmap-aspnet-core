var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Back Rodando!");

app.MapPost("/echo", async (HttpRequest request) =>
{
    var streamReader = new StreamReader(request.Body);
    var stringBody = await streamReader.ReadToEndAsync();
    return stringBody;
});

app.Run();
