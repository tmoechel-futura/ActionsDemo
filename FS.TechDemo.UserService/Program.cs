using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UserAuthorizationService.DataAccess.EntityFramework.DBContexts;
using UserAuthorizationService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddDbContext<UserDbContext>(options =>
{
    const string MigrationHistoryTableName = "__efmigrationshistory";
    const string ConnectionString = "Server=localhost;Port=3306;Database=techdemo_userservicedb;Uid=root;Pwd=w4XmQMDbZmvBuvUg";

    var serverVersion = new MySqlServerVersion(ServerVersion.AutoDetect(ConnectionString));
    options.UseMySql(ConnectionString,
        serverVersion,
        dbContextOptions => dbContextOptions.EnableRetryOnFailure(10)
            .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
            .MigrationsHistoryTable(MigrationHistoryTableName));
});

builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<UserDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<AuthorizationService>();
app.MapGet("/",
    () =>
        "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();