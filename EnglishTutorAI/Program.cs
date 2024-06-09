using Microsoft.AspNetCore.SpaServices.AngularCli;
using BootstrapModule;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddHostedService<DataInitializationService>();

builder.Services.AddAutoMapper2();

builder.Services.AddUnitOfWork(builder.Configuration);

//string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers();
builder.Services.AddAuthorization();

builder.Services.AddUserIdentity();

//  онфигураци€ аутентификации с использованием JWT
builder.Services.AddAuthentication(options => {
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options => {
	options.TokenValidationParameters = new TokenValidationParameters {
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = builder.Configuration["AuthSettings:Issuer"],
		ValidAudience = builder.Configuration["AuthSettings:Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["AuthSettings:Key"]))
	};
});
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
//	.AddEntityFrameworkStores<ApplicationContext>();

//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//	.AddCookie(options => {
//		options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
//		options.SlidingExpiration = true;
//		options.AccessDeniedPath = "/Forbidden/";
//	});
builder.Services.AddSpaStaticFiles(configuration => {
	configuration.RootPath = "ClientApp/dist";
});

builder.Services.AddHttpContextAccessor();
builder.Services.AddInfrastrucureServices(builder.Configuration);
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
	endpoints.MapControllers(); // подключаем маршрутизацию на контроллеры
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
//	// получаем пользовател€ по id
//	ApplicationUser? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

//	// если не найден, отправл€ем статусный код и сообщение об ошибке
//	if (user == null)
//		return Results.NotFound(new { message = "ѕользователь не найден" });

//	// если пользователь найден, отправл€ем его
//	return Results.Json(user);
//});

//app.MapDelete("/api/users/{id:string}", async (string id, ApplicationContext db) => {
//	// получаем пользовател€ по id
//	ApplicationUser? user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);

//	// если не найден, отправл€ем статусный код и сообщение об ошибке
//	if (user == null)
//		return Results.NotFound(new { message = "ѕользователь не найден" });

//	// если пользователь найден, удал€ем его
//	db.Users.Remove(user);
//	await db.SaveChangesAsync();
//	return Results.Json(user);
//});

//app.MapPost("/api/users", async (ApplicationUser user, ApplicationContext db) => {
//	// добавл€ем пользовател€ в массив
//	await db.Users.AddAsync(user);
//	await db.SaveChangesAsync();
//	return user;
//});

//app.MapPut("/api/users", async (ApplicationUser userData, ApplicationContext db) => {
//	// получаем пользовател€ по id
//	var user = await db.Users.FirstOrDefaultAsync(u => u.Id == userData.Id);

//	// если не найден, отправл€ем статусный код и сообщение об ошибке
//	if (user == null)
//		return Results.NotFound(new { message = "ѕользователь не найден" });

//	// если пользователь найден, измен€ем его данные и отправл€ем обратно клиенту
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
//	endpoints.MapControllers(); // подключаем маршрутизацию на контроллеры
//});
app.Run();
