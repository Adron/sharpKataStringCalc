namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("sharpKataStringCalc")>]
[<assembly: AssemblyProductAttribute("sharpKataStringCalc")>]
[<assembly: AssemblyDescriptionAttribute("A string calculator code kata.")>]
[<assembly: AssemblyVersionAttribute("0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1"
