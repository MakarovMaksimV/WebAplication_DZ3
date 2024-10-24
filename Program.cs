
using WebAplication.Abstraction;
using WebAplication.Data;
using WebAplication.Graph.Mutation;
using WebAplication.Graph.Query;
using WebAplication.Mapper;
using WebAplication.Repository;
using Microsoft.EntityFrameworkCore;

namespace MWebAplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEndpointsApiExplorer();         
            builder.Services.AddDbContext<StorageContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("db")));
            builder.Services.AddScoped<IProductRepository, ProductRepository>();
            builder.Services.AddAutoMapper(typeof(MapperProfile));
            builder.Services.AddSingleton<ProductGroupRepository>().AddGraphQLServer().AddQueryType<Query>().AddMutationType<Mutation>();
            builder.Services.AddMemoryCache();
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.MapGraphQL();


            app.Run();
        }
    }
}
