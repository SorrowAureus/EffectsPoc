﻿// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
namespace Program
open System
open EffectsPoc
module Main =
// Define a function to construct a message to print
    let from whom =
        sprintf "from %s" whom

    [<EntryPoint>]
    let main argv =
        let message = from "F#" // Call the function
        
        let a = env {
            
            let! e =  PersistenceService.persist 1
            let! b = LoggingService.log ""
            return e
        }
        
        printfn "Hello world %s" message
        0 // return an inte ger exit code