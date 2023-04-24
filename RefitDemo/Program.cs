using RefitDemo.AuthApiClient.AuthApi;
using RefitDemo.AuthApiClient.AuthApi.Configuration;
using RefitDemo.AuthApiClient.ProductApi;
using RefitDemo.KeycloakApiClient;
using RefitDemo.SwapiWithoutAuth;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("connectionstrings.json", optional: false, reloadOnChange: true);

builder.Services
    .AddTaskUserConfiguration(builder.Configuration)
    .AddSwApiWithRefit()
    .AddKeycloakAuthenticationWithRefit()
    .AddRelaxdaysProductApiWithRefit()
    .AddAuthApiWithRefit();

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