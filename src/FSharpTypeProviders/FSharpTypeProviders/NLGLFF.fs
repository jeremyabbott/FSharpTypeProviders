module NLGLFF

open FSharp.Data;

type Sponsors = JsonProvider<"http://nlglff-dev.azurewebsites.net/api/sponsors">
type Sponsor = Sponsors.Root

let getSponsorsFor year=
    let sponsors = query {  for sponsor in Sponsors.GetSamples() do 
                            where (sponsor.Year = year)
                            select sponsor }
    sponsors

// Note the type annotation for a type we didn't define...
let printSponsor (sponsor:Sponsor) =
    printfn "Sponsor Name: %s - Sponsor Amount: %d" sponsor.DisplayName sponsor.LevelNumericValue