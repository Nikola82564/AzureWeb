var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
<!doctype html>
<html>
<head><title>My Azure App</title></head>
<body>
  <h1>Cao Vukasine Vlajicu :)</h1>
</body>
</html>
""", "text/html"));

app.Run();