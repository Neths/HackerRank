namespace HackerRank_FS.Algorithms.Warmup

open NUnit.Framework
open FsUnit

type Class1() = 
    member this.X = "F#"


[<TestFixture>]
type TestClass =
 
 [<Test>]
 let ``When ``() =
    Assert.AreEqual(1,1)
