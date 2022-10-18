using NetCoreHelperLib;
using NetCoreIso8583x64Lib;

namespace NetCoreGrpc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            builder.Services.AddGrpcReflection();
            builder.Services.AddTransient<IRestService, RestService>();
            builder.Services.AddTransient<IMessage, Message>();
            builder.Services.AddTransient<IIso8583Service, Iso8583Service>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<Services.MessageService>();
            app.MapGrpcReflectionService();

            app.Run();
        }
    }
}