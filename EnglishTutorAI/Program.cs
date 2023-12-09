using EnglishTutorAI.Model;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddIdentity<User, IdentityRole>()
	.AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options => {
		options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
		options.SlidingExpiration = true;
		options.AccessDeniedPath = "/Forbidden/";
	});
//builder.Services.AddSpaStaticFiles(configuration => {
//	configuration.RootPath = "ClientApp/dist";
//});

builder.Services.AddHttpContextAccessor();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseDeveloperExceptionPage();
} else {
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}
app.UseStaticFiles();
if (!app.Environment.IsDevelopment()) {
	app.UseSpaStaticFiles();
}
//app.UseSpa(spa =>
//{
//	spa.Options.SourcePath = "ClientApp";

//	if (app.Environment.IsDevelopment())
//	{
//		spa.UseAngularCliServer(npmScript: "start");
//	}
//});

app.MapGet("/", async (ApplicationContext db) => await db.Users.ToListAsync());

app.MapGet("/api/users", async (ApplicationContext db) => await db.Users.ToListAsync());

app.MapGet("/api/users/{id:string}", async (string id, ApplicationContext db) => {
	// получаем пользовател€ по id
	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

	// если не найден, отправл€ем статусный код и сообщение об ошибке
	if (user == null)
		return Results.NotFound(new { message = "ѕользователь не найден" });

	// если пользователь найден, отправл€ем его
	return Results.Json(user);
});

app.MapDelete("/api/users/{id:string}", async (string id, ApplicationContext db) => {
	// получаем пользовател€ по id
	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

	// если не найден, отправл€ем статусный код и сообщение об ошибке
	if (user == null)
		return Results.NotFound(new { message = "ѕользователь не найден" });

	// если пользователь найден, удал€ем его
	db.Users.Remove(user);
	await db.SaveChangesAsync();
	return Results.Json(user);
});

app.MapPost("/api/users", async (User user, ApplicationContext db) => {
	// добавл€ем пользовател€ в массив
	await db.Users.AddAsync(user);
	await db.SaveChangesAsync();
	return user;
});

app.MapPut("/api/users", async (User userData, ApplicationContext db) => {
	// получаем пользовател€ по id
	var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userData.Id);

	// если не найден, отправл€ем статусный код и сообщение об ошибке
	if (user == null)
		return Results.NotFound(new { message = "ѕользователь не найден" });

	// если пользователь найден, измен€ем его данные и отправл€ем обратно клиенту
	user.Email = userData.Email;
	user.FirstName = userData.FirstName;
	await db.SaveChangesAsync();
	return Results.Json(user);
});


app.UseAuthentication();
//app.UseAuthorization();

//app.MapRazorPages();
//app.MapDefaultControllerRoute();

app.Run();
