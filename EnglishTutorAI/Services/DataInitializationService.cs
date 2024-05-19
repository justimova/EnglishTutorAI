using DomainServices.Interfaces;
using UnitOfWork.Interfaces;

namespace EnglishTutorAI.Services;

public class DataInitializationService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;

    public DataInitializationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        using (var scope = _serviceProvider.CreateScope())
        {
            var grammarTopicService = scope.ServiceProvider.GetRequiredService<IGrammarTopicService>();
            var db = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
            await grammarTopicService.UpdateGrammarTopicsIfNeededAsync(stoppingToken);
        }
    }

    public override Task StopAsync(CancellationToken cancellationToken)
    {
        return base.StopAsync(cancellationToken);
    }

}
