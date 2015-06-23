module sharpKataStringCalc.Tests

open System
open sharpKataStringCalc
open NUnit.Framework

let calculator = Calculator()

[<TestFixture>]
type CalculatorTests() =
  [<Test>]
  member x.``should return zero if no string value is passed in.``() =
    let result = calculator.Add ""
    Assert.That(result, Is.EqualTo 0)

  [<TestCase("1", Result = 1)>]
  [<TestCase("2", Result = 2)>]
  member x.``take one number and return that number`` expression =
    calculator.Add expression

  [<TestCase("1 2", Result = 3)>]
  [<TestCase("2 3", Result = 5)>]
  member x.``add single number to single number and return sum`` expression =
    calculator.Add expression
