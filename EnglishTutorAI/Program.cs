using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using BootstrapModule;
using EnglishTutorAI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<DataInitializationService>();

builder.Services.AddAutoMapper();

builder.Services.AddUnitOfWork(builder.Configuration);

//string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers();
builder.Services.AddAuthorization();

builder.Services.AddUserIdentity();
//builder.Services.AddIdentity<User, IdentityRole>()
//	.AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie(options => {
		options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
		options.SlidingExpiration = true;
		options.AccessDeniedPath = "/Forbidden/";
	});
builder.Services.AddSpaStaticFiles(configuration => {
	configuration.RootPath = "ClientApp/dist";
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddDomainServices();
builder.Services.AddAiServices(builder.Configuration);


var app = builder.Build();

if (app.Environment.IsDevelopment()) {
	app.UseDeveloperExceptionPage();
} else {
	app.UseExceptionHandler("/Error");
	app.UseHsts();
}
app.UseStaticFiles();

app.UseAuthentication();
app.MapControllers();

app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints => {
	endpoints.MapControllers(); // ���������� ������������� �� �����������
});

// Run middleware when request is sent to endpoint which should be handled by Angular, so for example all except API endpoints
//var excludedPaths = new PathString[] { "/api" };
//app.UseWhen((ctx) => {
//	var path = ctx.Request.Path;
//	return !Array.Exists(excludedPaths, excluded => path.StartsWithSegments(excluded, StringComparison.OrdinalIgnoreCase));
//}, then => {
	// Use static files from Angular dist folder in production
	if (builder.Environment.IsProduction()) {
		app.UseSpaStaticFiles();
	}

	//then.UseSpa(cfg => {
	//	// While development we want to start Angular app
	//	if (builder.Environment.IsDevelopment()) {
	//		cfg.Options.SourcePath = "ClientApp";
	//		cfg.UseAngularCliServer("start");
	//	}
	//});
	app.UseSpa(spa => {
		spa.Options.SourcePath = "ClientApp";
		if (builder.Environment.IsDevelopment()) {
			spa.UseAngularCliServer(npmScript: "start");
		}
	});
//});




//app.MapGet("/", async (ApplicationContext db) => await db.Users.ToListAsync());

//app.MapGet("/api/users", async (ApplicationContext db) => await db.Users.ToListAsync());

//app.MapGet("/api/users/{id:string}", async (string id, ApplicationContext db) => {
//	// �������� ������������ �� id
//	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

//	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//	if (user == null)
//		return Results.NotFound(new { message = "������������ �� ������" });

//	// ���� ������������ ������, ���������� ���
//	return Results.Json(user);
//});

//app.MapDelete("/api/users/{id:string}", async (string id, ApplicationContext db) => {
//	// �������� ������������ �� id
//	User? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

//	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//	if (user == null)
//		return Results.NotFound(new { message = "������������ �� ������" });

//	// ���� ������������ ������, ������� ���
//	db.Users.Remove(user);
//	await db.SaveChangesAsync();
//	return Results.Json(user);
//});

//app.MapPost("/api/users", async (User user, ApplicationContext db) => {
//	// ��������� ������������ � ������
//	await db.Users.AddAsync(user);
//	await db.SaveChangesAsync();
//	return user;
//});

//app.MapPut("/api/users", async (User userData, ApplicationContext db) => {
//	// �������� ������������ �� id
//	var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userData.Id);

//	// ���� �� ������, ���������� ��������� ��� � ��������� �� ������
//	if (user == null)
//		return Results.NotFound(new { message = "������������ �� ������" });

//	// ���� ������������ ������, �������� ��� ������ � ���������� ������� �������
//	user.Email = userData.Email;
//	user.FirstName = userData.FirstName;
//	await db.SaveChangesAsync();
//	return Results.Json(user);
//});


//app.MapRazorPages();
//app.MapDefaultControllerRoute();
//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//	endpoints.MapControllers(); // ���������� ������������� �� �����������
//});
app.Run();
