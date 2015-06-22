// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#load "Calculator.fs"
open sharpKataStringCalc

let num = Calculator.hello 42
printfn "%i" num
