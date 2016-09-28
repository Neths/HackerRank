namespace HackerRank_FS.Algorithms.Warmup
//Sample Input
//6
//1 2 3 4 10 11

//Sample Output
//31

open NUnit.Framework
open FsUnit
open System
open System.IO

type SimpleArraySum(IN:TextReader, OUT:TextWriter) = 
    member this.Sum = 
        let nb = IN.ReadLine() |> int
        OUT.Write (IN.ReadLine().Split [|' '|] |> Seq.map int |> Seq.sum)


[<TestFixture>]
type `` Given a simple array sum ``() =
    let out = new StringWriter()

    [<Test>]
    member x.``When try sample use case ``() =
        let simpleArraySum = new SimpleArraySum(new StringReader(@"6
1 2 3 4 10 11"),out)
        simpleArraySum.Sum
        Assert.AreEqual("31",out.GetStringBuilder().ToString())
