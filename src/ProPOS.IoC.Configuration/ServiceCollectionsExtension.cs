using System.Text;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProPOS.SharedKernel.Common;

namespace ProPOS.IoC.Configuration;

public static class ServiceCollectionsExtension
{
    public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddRepository(configuration);
        //services.AddHttpContextAccessor();
        //services.AddControllers(config =>
        //{
        //    var policy = new AuthorizationPolicyBuilder()
        //                     .RequireAuthenticatedUser()
        //                     .Build();
        //    config.Filters.Add(new AuthorizeFilter(policy));

        //}).AddNewtonsoftJson(options =>
        //{
        //    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        //    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        //    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

        //}).AddJsonOptions(options =>
        //{
        //    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        //    options.JsonSerializerOptions.WriteIndented = true;
        //    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        //});
        //services.AddOptions();
        //services.AddOptions<ApplicationSettings>(ApplicationConstants.ApplicationSettings);
        //services.AddApplicationServices(configuration);


        //var origins = configuration.GetSection("Domain").Get<Domain>();
        //if (origins.Client2.Count != 0) { origins?.Client1?.AddRange(origins.Client2); }

        //services.AddCors(options => options.AddPolicy("HRMaster", builder =>
        //{
        //    builder.WithOrigins(origins?.Client1?.ToArray())
        //    .AllowAnyMethod()
        //    .AllowAnyHeader()
        //    .AllowCredentials();
        //}));

        //services.AddResponseCaching();
        //services.AddResponseCompression();
        //services.AddDistributedMemoryCache();

        //services.AddCertificateForwarding(conf => conf.CertificateHeader = "");

        //services.AddAuthorization(options =>
        //{
        //    options.AddPolicy("CanPurge", policy => policy.RequireRole("Administrator"));
        //});

        //services.AddAuthentication(options =>
        //{
        //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;

        //}).AddJwtBearer(options =>
        //{
        //    options.TokenValidationParameters = new TokenValidationParameters
        //    {
        //        ValidateIssuer = false,
        //        ValidateAudience = false,
        //        ValidateLifetime = true,
        //        ValidateIssuerSigningKey = true,
        //        ClockSkew = TimeSpan.Zero,
        //        ValidIssuer = configuration["JwtConfig:validIssuer"],
        //        ValidAudience = configuration["JwtConfig:validAudience"],
        //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtConfig:secret"]))
        //    };
        //});
        //services.AddEndpointsApiExplorer();
        //services.AddSwaggerGen(options =>
        //{
        //    options.ResolveConflictingActions(o => o.First());
        //    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        //    {
        //        Name = "Authorization",
        //        Type = SecuritySchemeType.ApiKey,
        //        Scheme = "Bearer",
        //        BearerFormat = "JWT",
        //        In = ParameterLocation.Header,
        //        Description = "JWT Authorization header using the Bearer scheme."
        //    });

        //    options.AddSecurityRequirement(new OpenApiSecurityRequirement
        //    {
        //        {
        //            new OpenApiSecurityScheme
        //            {
        //                Reference = new OpenApiReference
        //                {
        //                    Type = ReferenceType.SecurityScheme,
        //                    Id = "Bearer"
        //                }
        //            },
        //            Array.Empty<string>()
        //        }
        //    });

        //    options.SwaggerDoc("v1", new OpenApiInfo
        //    {
        //        Title = "Tactsoft-HRMaster",
        //        Description = "An ASP.NET Core Web API for Human Resource Management System (HRMS)",
        //        Contact = new OpenApiContact
        //        {
        //            Name = "Tactsoft Limited",
        //            Url = new Uri("http://tactsoftltd.com"),
        //        },
        //        License = new OpenApiLicense
        //        {
        //            Name = "Apache License",
        //            Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.txt")
        //        }
        //    });

        //});
        return services;
    }
}