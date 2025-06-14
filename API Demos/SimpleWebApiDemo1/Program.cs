
using Microsoft.EntityFrameworkCore;
using SimpleWebApiDemo1.contexts;
using SimpleWebApiDemo1.Repositories;

namespace SimpleWebApiDemo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<IStudentService,StudentService>();
            builder.Services.AddScoped<ICourseSevice, CourseService>();
            builder.Services.AddDbContext<ApplicationContext>(options => options.
            UseSqlServer(builder.Configuration.GetConnectionString("myconnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
