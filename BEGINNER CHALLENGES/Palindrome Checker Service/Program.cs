var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Funfando!");
app.MapPost("/check", (CheckRequest req) =>
{
    return req.Palindrome == new string(req.Palindrome.Reverse().ToArray());
});

app.Run();

public record CheckRequest
{
    public required string Palindrome { get; set; }
}
