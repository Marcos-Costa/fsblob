module api.Program

open System
open Falco
open Falco.Routing
open Falco.HostBuilder
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http

// ------------
// Exception Handler
// ------------
let exceptionHandler : HttpHandler =
    Response.withStatusCode 500 
    >> Response.ofPlainText "Server error"
let single : HttpHandler =
    let formBinder (f: FormCollectionReader) : IFormFile option =
        f.TryGetFormFile "image"
        
    let upload (image: IFormFile option) : HttpHandler =
        let name =
            image
            |> Option.bind (fun i -> Some i.Name)
            |> Option.defaultValue "NoImage"
        
        Response.ofPlainText name
    
    Request.mapFormStream formBinder upload
    
[<EntryPoint>]
let main args =   
    webHost args {
        use_if    FalcoExtensions.IsDevelopment DeveloperExceptionPageExtensions.UseDeveloperExceptionPage
        use_ifnot FalcoExtensions.IsDevelopment (FalcoExtensions.UseFalcoExceptionHandler exceptionHandler)
        
        endpoints [            
            get "/" single
        ]
    }
    0