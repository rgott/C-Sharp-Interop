namespace RGott.FSharp

type Program() =
    member this.Run(message) =
        printfn "%s -From F#" message
        "F#"

