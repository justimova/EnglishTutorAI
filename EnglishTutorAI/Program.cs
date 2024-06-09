using Microsoft.AspNetCore.SpaServices.AngularCli;
using BootstrapModule;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper2();
builder.Services.AddUnitOfWork(builder.Configuration);
builder.Services.AddControllers();
builder.Services.AddAuthorization();
builder.Services.AddUserIdentity();
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
	endpoints.MapControllers();
});
if (builder.Environment.IsProduction()) {
	app.UseSpaStaticFiles();
}
app.UseSpa(spa => {
	spa.Options.SourcePath = "ClientApp";
	if (builder.Environment.IsDevelopment()) {
		spa.UseAngularCliServer(npmScript: "start");
	}
});
app.Run();
