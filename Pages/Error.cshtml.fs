namespace RazorPagesFSharp.Pages

open System
open System.Diagnostics
open Microsoft.AspNetCore.Mvc.RazorPages


type ErrorModel () =
    inherit PageModel()
    member val RequestId : string = null with get, set

    member val ShowRequestId : bool = true with get, set

    member this.OnGet() =
        do this.RequestId <- 
            if Activity.Current |> isNull then
                this.HttpContext.TraceIdentifier
            else 
                Activity.Current.Id