using Asp.Versioning;
using Asp.Versioning.Conventions;
// keep usings minimal

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 0);
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new QueryStringApiVersionReader("api-version"),
        new HeaderApiVersionReader("x-api-version"),
        new MediaTypeApiVersionReader("api-version")
        );
}).AddMvc(options =>
{
    options.Conventions.Add(new VersionByNamespaceConvention());
});
// Configure static Swagger/OpenAPI documents for supported versions
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo { Title = "Employee Management API", Version = "v1" });
    options.SwaggerDoc("v2", new Microsoft.OpenApi.OpenApiInfo { Title = "Employee Management API", Version = "v2" });
    options.SwaggerDoc("v3", new Microsoft.OpenApi.OpenApiInfo { Title = "Employee Management API", Version = "v3" });

    options.DocInclusionPredicate((docName, apiDesc) =>
    {
        var groupName = apiDesc.GroupName;
        if (groupName == null)
            return docName == "v1"; // fallback to v1 if not specified
        return groupName == docName;
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// In Development, try to pre-generate Swagger documents so any generation errors are logged at startup
if (app.Environment.IsDevelopment())
{
    // No pre-generation step for static docs
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Show detailed exceptions in Development to help diagnose swagger generation errors
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
        options.SwaggerEndpoint("/swagger/v3/swagger.json", "v3");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
