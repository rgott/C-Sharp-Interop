namespace RGott.FSharp

type Program() =

    static member Add(a, b) =
        a + b

    member this.Run(message) =
        printfn "%s -From F#" message
        |> ignore
