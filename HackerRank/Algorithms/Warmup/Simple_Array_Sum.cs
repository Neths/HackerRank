using System.IO;
using System.Linq;
using NUnit.Framework;

public class Simple_Array_Sum 
{
    private TextReader _in;
    private TextWriter _out;

    public Simple_Array_Sum(TextReader IN, TextWriter OUT)
    {
        _out = OUT;
        _in = IN;
    }

    public void Resolve()
    {
        var nb = int.Parse(_in.ReadLine());

        _out.WriteLine(_in.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Sum()
            .ToString());
    }
}

[TestFixture]
public class Test
{
    [Test]
    public void GetSimpleSumArray()
    {
        var input = @"6
1 2 3 4 10 11";

        var output = new StringWriter();

        new Simple_Array_Sum(new StringReader(input), output).Resolve();

        Assert.AreEqual("31\r\n",output.GetStringBuilder().ToString());
    }
}