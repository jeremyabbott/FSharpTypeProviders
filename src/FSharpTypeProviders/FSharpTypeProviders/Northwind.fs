module Northwind
open System.Data
open Microsoft.FSharp.Data.TypeProviders
open System.Data.Linq
open System.Linq

type NorthwindDb = SqlDataConnection<"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true;">
let db = NorthwindDb.GetDataContext()
type category = { name:string; id:int; }
// Enable the logging of database activity to the console.
db.DataContext.Log <- System.Console.Out

let getCategories () =
    let categories = query {
            for row in db.Categories do
            select row
//            select {name = row.CategoryName; id = row.CategoryID }
          }
    categories
    

    

let printCategories (categories:IQueryable<NorthwindDb.ServiceTypes.Categories>) =
    categories |> Seq.iter(fun row -> printfn "%s" row.Description)