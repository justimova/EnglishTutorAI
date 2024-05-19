using AiServices;
using DomainServices;
using DomainServices.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UnitOfWork;
using UnitOfWork.Interfaces;

namespace BootstrapModule;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddAutoMapper(this IServiceCollection source) {
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
		//source.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>();
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

	public static IServiceCollection AddAiServices(this IServiceCollection source, IConfiguration configuration) {
		string number = configuration?.GetSection("AISettings")["NumberOfWordsForReadingText"];
		int.TryParse(number, out int numberOfWordsForReadingText);
		string? createWritingTextSystemMessage = configuration?.GetSection("AISettings")["CreateWritingTextSystemMessage"];
		string? createWritingTextUserMessage = configuration?.GetSection("AISettings")["CreateWritingTextUserMessage"];
		string? getRecommendationWritingTextSystemMessage = 
			configuration?.GetSection("AISettings")["GetRecommendationWritingTextSystemMessage"];
		string? getTopicSystemMessage = configuration?.GetSection("AISettings")["GetTopicSystemMessage"];
		string? getTopicUserMessage = configuration?.GetSection("AISettings")["GetTopicUserMessage"];
		string? createReadingTextSystemMessage = configuration?.GetSection("AISettings")["CreateReadingTextSystemMessage"];
		string? createReadingTextUserMessage = configuration?.GetSection("AISettings")["CreateReadingTextUserMessage"];
		source.AddSingleton<IAiSettings>(service => {
			return new AiSettings {
				NumberOfWordsForReadingText = numberOfWordsForReadingText,
				CreateWritingTextSystemMessage = createWritingTextSystemMessage ?? string.Empty,
				CreateWritingTextUserMessage = createWritingTextUserMessage ?? string.Empty,
				GetRecommendationWritingTextSystemMessage = getRecommendationWritingTextSystemMessage ?? string.Empty,
				GetTopicSystemMessage = getTopicSystemMessage ?? string.Empty,
				GetTopicUserMessage = getTopicUserMessage ?? string.Empty,
				CreateReadingTextSystemMessage = createReadingTextSystemMessage ?? string.Empty,
				CreateReadingTextUserMessage = createReadingTextUserMessage ?? string.Empty
			};
		});
		source.AddScoped<IAiService, AiService>();
		return source;
	}

}
