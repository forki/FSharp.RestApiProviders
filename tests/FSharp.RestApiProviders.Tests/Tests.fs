module FSharp.RestApiProviders.Tests

open FSharp.RestApiProviders
open Xunit

[<Fact>]
let ``hello returns 42`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.Equal(42,result)
