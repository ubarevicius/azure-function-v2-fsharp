namespace FunctionApp

open Microsoft.Azure.WebJobs
open Microsoft.AspNetCore.Mvc
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Logging

module FunctionModule =
    [<FunctionName("Function")>]
    let Run([<HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)>]  
        req: HttpRequest, 
        log: ILogger) =
            new OkObjectResult("Hi")
