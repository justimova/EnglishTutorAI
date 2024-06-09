using AiServices;
using DbModels;
using DomainServices;
using DomainServices.Interfaces;
using Infrastructure.Interfaces;
using InfrastructureService;
using InfrastructureService.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnitOfWork;
using UnitOfWork.Interfaces;

namespace BootstrapModule;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutoMapper2(this IServiceCollection source) {
		source.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
		return source;
	}

	public static IServiceCollection AddUnitOfWork(this IServiceCollection source, IConfiguration configuration) {
		var connectionString = configuration.GetConnectionString("DefaultConnection");
		source.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString), ServiceLifetime.Scoped);

		source.AddScoped<IApplicationContext, ApplicationContext>();

		source.AddScoped(typeof(IUnitOfWork), typeof(ApplicationContext));
		source.AddScoped(typeof(IRepository<>), typeof(Repository<>));
		source.AddScoped(typeof(IEssayRepository), typeof(EssayRepository));
		source.AddScoped(typeof(IStoryRepository), typeof(StoryRepository));

		return source;
	}

	public static IServiceCollection AddUserIdentity(this IServiceCollection source) {
		//source.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
		source.AddIdentity<ApplicationUser, IdentityRole>()
			.AddEntityFrameworkStores<ApplicationContext>()
			.AddDefaultTokenProviders();
		return source;
	}

	public static IServiceCollection AddDomainServices(this IServiceCollection source) {
		source.AddScoped<IEssayService, EssayService>();
		source.AddScoped<IStoryService, StoryService>();
		source.AddScoped<IDictionaryService, DictionaryService>();
		source.AddScoped<IGrammarTopicService, GrammarTopicService>();
		source.AddScoped<ILanguageLevelService, LanguageLevelService>();
		return source;
	}

	public static IServiceCollection AddInfrastrucureServices(this IServiceCollection source, IConfiguration configuration) {
		var authSettingsSection = configuration?.GetSection("AuthSettings");
		source.Configure<AuthSettings>(authSettingsSection);
		source.AddScoped<IAuthService, AuthService>();
		source.AddScoped<IUserService, UserService>();
		return source;
	}

	public static IServiceCollection AddAiServices(this IServiceCollection source, IConfiguration configuration) {
		var aiSettingsSection = configuration?.GetSection("AISettings");
		source.Configure<AiSettings>(aiSettingsSection);
		//var aiSettings = aiSettingsSection.Get<AiSettings>();
		//aiSettings.NumberOfWordsForReadingText
		//string number = aiSettingsSection["NumberOfWordsForReadingText"];
		//int.TryParse(number, out int numberOfWordsForReadingText);
		//string? createWritingTextSystemMessage = aiSettingsSection["CreateWritingTextSystemMessage"];
		//string? createWritingTextUserMessage = aiSettingsSection["CreateWritingTextUserMessage"];
		//string? getRecommendationWritingTextSystemMessage = 
		//	aiSettingsSection["GetRecommendationWritingTextSystemMessage"];
		//string? getTopicSystemMessage = aiSettingsSection["GetTopicSystemMessage"];
		//string? getTopicUserMessage = aiSettingsSection["GetTopicUserMessage"];
		//string? createReadingTextSystemMessage = aiSettingsSection["CreateReadingTextSystemMessage"];
		//string? createReadingTextUserMessage = aiSettingsSection["CreateReadingTextUserMessage"];
		//source.AddSingleton<IAiSettings>(service => aiSettingsSection.Get<AiSettings>());
		//	{
		//	return new AiSettings {
		//		NumberOfWordsForReadingText = numberOfWordsForReadingText,
		//		CreateWritingTextSystemMessage = createWritingTextSystemMessage ?? string.Empty,
		//		CreateWritingTextUserMessage = createWritingTextUserMessage ?? string.Empty,
		//		GetRecommendationWritingTextSystemMessage = getRecommendationWritingTextSystemMessage ?? string.Empty,
		//		GetTopicSystemMessage = getTopicSystemMessage ?? string.Empty,
		//		GetTopicUserMessage = getTopicUserMessage ?? string.Empty,
		//		CreateReadingTextSystemMessage = createReadingTextSystemMessage ?? string.Empty,
		//		CreateReadingTextUserMessage = createReadingTextUserMessage ?? string.Empty
		//	};
		//});
		source.AddScoped<IAiService, AiService>();
		return source;
	}

}
