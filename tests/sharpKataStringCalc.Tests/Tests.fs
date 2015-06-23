module sharpKataStringCalc.Tests

open System
open sharpKataStringCalc
open NUnit.Framework

let calculator = Calculator()

[<TestFixture>]
type CalculatorTests() =
  [<Test>]
  member x.add_empty_string() =
    let result = calculator.Add ""
    Assert.That(result, Is.EqualTo 0)

  [<TestCase("1", Result = 1)>]
  [<TestCase("2", Result = 2)>]
  [<TestCase("1 2", Result = 3)>]
  [<TestCase("2 3", Result = 5)>]
  member x.Add_single_number_returns_that_number expression =
    calculator.Add expression
