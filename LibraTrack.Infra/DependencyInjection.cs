namespace LibraTrack.Infra;

public static class DependencyInjection
{

    public static void AddInfrastructure(this IServiceCollection services,
                                         IConfiguration configuration)
    {
        AddPersistence(services, configuration);
    }

    private static void AddPersistence(IServiceCollection services,
                                       IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database") ??
                               throw new ArgumentException(null, nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<ILoanRepository, LoanRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());
    }
}