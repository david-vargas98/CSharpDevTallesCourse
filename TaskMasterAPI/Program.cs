var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
// adding swagger UI
builder.Services.AddEndpointsApiExplorer(); // necessary for Swagger to detect controllers and API actions
builder.Services.AddSwaggerGen();           //generates the OpenAPI specification document
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();   // it serves the Json specification file
    app.UseSwaggerUI(); // enables the UI for the browser
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
