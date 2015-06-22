module sharpKataStringCalc.Tests

open sharpKataStringCalc
open NUnit.Framework

[<Test>]
let ``hello returns 42`` () =
  let result = Calculator.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)
