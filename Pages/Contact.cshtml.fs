﻿namespace RazorPagesFSharp.Pages

open System;
open Microsoft.AspNetCore.Mvc.RazorPages

type ContactModel () = 
    inherit PageModel()

    member val Message : string = null with get, set

     member this.OnGet() =
        do this.Message <- "Hello from F#"