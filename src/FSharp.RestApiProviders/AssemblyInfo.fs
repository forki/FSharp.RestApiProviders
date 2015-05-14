namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharp.RestApiProviders")>]
[<assembly: AssemblyProductAttribute("FSharp.RestApiProviders")>]
[<assembly: AssemblyDescriptionAttribute("Type providers for RESTful APIs")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
