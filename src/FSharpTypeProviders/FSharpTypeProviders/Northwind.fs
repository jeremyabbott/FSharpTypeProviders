module Northwind
open System.Data
open Microsoft.FSharp.Data.TypeProviders
open System.Data.Linq
open System.Linq

type NorthwindDb = SqlDataConnection<"Data Source=(local)\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=true;">
let db = NorthwindDb.GetDataContext()
type Category = NorthwindDb.ServiceTypes.Categories

// Enable the logging of database activity to the console.
db.DataContext.Log <- System.Console.Out

let getCategories () =
    let categories = query {
            for row in db.Categories do
            select row
          }
    categories
    
 // note that the type in the type annotation is not declared anywhere.
let printCategory (category:Category) =
     printfn "ID: %d; Description: %s" category.CategoryID category.Description