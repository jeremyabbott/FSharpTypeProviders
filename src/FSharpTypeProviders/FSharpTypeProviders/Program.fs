// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open FreebaseDb
open NLGLFF
open Northwind

//let add1 x = x + 1
//let times2 x = x * 2
//let add1Times2 = add1 >> times2


[<EntryPoint>]
let main argv = 
    
//    printfn "%d" (add1Times2 5)

//    FreebaseDb.getBassists ()
    NLGLFF.getSponsorsFor 2014 |> NLGLFF.printSponsors |> ignore
      
    let categories = Northwind.getCategories ()
    printfn "%A" categories

    0 // return an integer exit code
