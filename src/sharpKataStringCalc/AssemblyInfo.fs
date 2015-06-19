namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("sharpKataStringCalc")>]
[<assembly: AssemblyProductAttribute("sharpKataStringCalc")>]
[<assembly: AssemblyDescriptionAttribute("A string calculator code kata.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
