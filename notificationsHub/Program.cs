using AutoMapper;
using CrossCutting.Mappings;
using Microsoft.OpenApi.Models;
using CrossCutting.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

ConfigureService.ConfigureDependenciesService(builder.Services);
ConfigureRepository.ConfigureDependenciesRepository(builder.Services);

var config = new MapperConfiguration(cfg =>
{
    AutoMapperConfiguration.ConfigureProfiles(cfg);
});

IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);

//var signingConfigurations = new SigningConfigurations();
//builder.Services.AddSingleton(signingConfigurations);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "notificationsHub", Version = "v1" });
});

//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "notificationsHub API V1");
});

app.Run();