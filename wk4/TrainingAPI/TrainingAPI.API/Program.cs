using TrainingAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Connection Strings and environment variables
// Argument, Hardcoded, File-read, User Secrets, Environment Variabels are all
// options to retrieve a secret (like a connection string).

// the order of Environmental Arguments/ Values is Environment variable first (if there is one), then User Secret, then appsettings.json


// string connectionString = await File.ReadAllTextAsync("C:/Revature/ConnectionStrings/220705-DB.txt");
string connectionString = builder.Configuration.GetConnectionString("connectionString");

builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IRepository>(sp => new SQLRepository(connectionString, sp.GetRequiredService<ILogger<SQLRepository>>()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
