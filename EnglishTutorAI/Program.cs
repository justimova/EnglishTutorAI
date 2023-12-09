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
	// �������� ������������ �� id
	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
	if (user == null)
		return Results.NotFound(new { message = "������������ �� ������" });

	// ���� ������������ ������, ���������� ���
	return Results.Json(user);
});

app.MapDelete("/api/users/{id:string}", async (string id, ApplicationContext db) => {
	// �������� ������������ �� id
	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
	if (user == null)
		return Results.NotFound(new { message = "������������ �� ������" });

	// ���� ������������ ������, ������� ���
	db.Users.Remove(user);
	await db.SaveChangesAsync();
	return Results.Json(user);
});

app.MapPost("/api/users", async (User user, ApplicationContext db) => {
	// ��������� ������������ � ������
	await db.Users.AddAsync(user);
	await db.SaveChangesAsync();
	return user;
});

app.MapPut("/api/users", async (User userData, ApplicationContext db) => {
	// �������� ������������ �� id
	var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userData.Id);

	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
	if (user == null)
		return Results.NotFound(new { message = "������������ �� ������" });

	// ���� ������������ ������, �������� ��� ������ � ���������� ������� �������
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
