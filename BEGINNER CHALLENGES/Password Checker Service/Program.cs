var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/check-password", (PasswordCheckRequest req) =>
{
    if (String.IsNullOrEmpty(req.Password))
    {
        return Results.BadRequest("A senha não pode ser vazia.");
    }

    var pontuacao = 0;
    var suggestions = new List<string>();
    switch (req.Password.Length)
    {
        case < 8:
            pontuacao += 0;
            suggestions.Add("Add more characters");
            break;
        case >= 8 and < 12:
            pontuacao += 1;
            suggestions.Add("Add more characters");
            break;
        default:
            pontuacao += 2;
            break;
    }

    var foundDigit = false;
    var foundUpper = false;
    var foundLower = false;
    var foundSymbol = false;
    for (var i = 0; i < req.Password.Length; i++)
    {
        if (char.IsDigit(req.Password[i]) && !foundDigit)
        {
            foundDigit = true;
            pontuacao += 1;
        }
        if (char.IsUpper(req.Password[i]) && !foundUpper)
        {
            foundUpper = true;
            pontuacao += 1;
        }
        if (char.IsLower(req.Password[i]) && !foundLower)
        {
            foundLower = true;
            pontuacao += 1;
        }
        if (char.IsSymbol(req.Password[i]) && !foundSymbol)
        {
            foundSymbol = true;
            pontuacao += 1;
        }
    }
    if (!foundDigit) suggestions.Add("Add more digits");
    if (!foundUpper) suggestions.Add("Add more uppercase letters");
    if (!foundLower) suggestions.Add("Add more lowercase letters");
    if (!foundSymbol) suggestions.Add("Add more symbols");

    return Results.Ok(new
    {
        password = req.Password,
        strength = pontuacao >= 5 ? "Strong" : pontuacao >= 3 ? "Medium" : "Weak",
        suggestions
    });
});

app.Run();

record PasswordCheckRequest(string Password);
