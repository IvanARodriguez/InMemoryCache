namespace CachingApiServer

#nowarn "20"
open System
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Data

module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =


        let builder = WebApplication.CreateBuilder(args)

        builder.Services.AddControllers()
        

        let app = builder.Build()

        app.UseHttpsRedirection()

        app.UseAuthorization()
        app.MapControllers()

        app.Run()

        exitCode
