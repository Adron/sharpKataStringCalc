module sharpKataStringCalc.Tests

open System
open sharpKataStringCalc
open NUnit.Framework

[<TestFixture>]
type CalculatorTests() =
  [<Test>]
  member x.add_empty_string() =
    let calculator = Calculator()
    let result = calculator.Add ""
    Assert.That(result, Is.EqualTo 0)
