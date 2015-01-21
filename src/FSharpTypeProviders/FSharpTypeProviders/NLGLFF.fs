module NLGLFF

open FSharp.Data;

type Sponsors = JsonProvider<"http://nlglff-dev.azurewebsites.net/api/sponsors">

let getSponsorsFor year=
    let sponsors = query {  for sponsor in Sponsors.GetSamples() do 
                            where (sponsor.Year = year)
                            select sponsor }
//                            select (sponsor.DisplayName, sponsor.Year, sponsor.LevelNumericValue)  }
    
//    for sponsor in sponsors do
//        printfn "%s" sponsor.DisplayName
    sponsors

let printSponsors (sponsors:seq<Sponsors.Root>) =
//    for sponsor in sponsors do
//        let name, year, amount = sponsor
//        printfn "Year %d - Name %s - Amount %d" year name amount

    for sponsor in sponsors do
        printfn "%s" sponsor.DisplayName

    ignore
