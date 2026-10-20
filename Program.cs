using Microsoft.EntityFrameworkCore;
using PokeCardCollection.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<CardContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CardContext")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

// Create the local database and add sample cards the first time the app runs.
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<CardContext>();
    db.Database.EnsureCreated();
    CardSeedData.AddSampleCards(db);
}

app.Run();
