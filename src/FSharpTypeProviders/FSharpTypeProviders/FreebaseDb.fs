module FreebaseDb

open FSharp.Data

[<Literal>] // causes value to be compiled as a CLI constant
let FreebaseApiKey = "AIzaSyDMkWdNiGolFAPDXWcmbztE_m83gCpnsnE"
type FreebaseDataWithKey = FreebaseDataProvider<Key=FreebaseApiKey>

let data = FreebaseDataWithKey.GetDataContext()
// Suddenly I can explore data available in Freebase by type "data."

let getBassists ()  =
    let items = data.``Arts and Entertainment``.Music.Bassists
    items

let printBassist bassist =
    printfn "%A" bassist