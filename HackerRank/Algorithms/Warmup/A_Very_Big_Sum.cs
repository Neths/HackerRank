using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HackerRank.Algorithms.Warmup
{
    class A_Very_Big_Sum
    {
        private readonly TextReader _in;
        private readonly TextWriter _out;

        public A_Very_Big_Sum(TextReader IN, TextWriter OUT)
        {
            _out = OUT;
            _in = IN;
        }

        public void Resolve()
        {
            var nbInput = _in.ReadLine();

            var rawInput = _in.ReadLine()
                .Split(' ')
                .Select(s => new
                {
                    Lower = int.Parse(s.Substring(s.Length - 5, 5)),
                    Upper = int.Parse(s.Substring(0, s.Length - 5))
                })
                .ToList();

            var lower = rawInput.Sum(e => e.Lower).ToString("D5");
            var offset = string.Empty;

            if (lower.Length > 5)
            {
                offset = lower.Substring(0, lower.Length - 5);
                lower = lower.Substring(offset.Length,5);
            }

            var upper = ((offset.Length > 0 ? int.Parse(offset): 0) + rawInput.Sum(e => e.Upper)).ToString();

            _out.Write($"{upper}{lower}");
        }
    }

    [TestFixture]
    public class A_Very_Big_Sum_Test
    {
        [Test]
        public void GetSimpleSum()
        {
            var input = @"5
1000000001 1000000002 1000000003 1000000004 1000000005";

            var output = new StringWriter();

            new A_Very_Big_Sum(new StringReader(input), output).Resolve();

            Assert.AreEqual("5000000015", output.GetStringBuilder().ToString());
        }

        [Test]
        public void GetSum()
        {
            var input = @"10
1001458909 1004570889 1007019111 1003302837 1002514638 1006431461 1002575010 1007514041 1007548981 1004402249";

            var output = new StringWriter();

            new A_Very_Big_Sum(new StringReader(input), output).Resolve();

            Assert.AreEqual("10047338126", output.GetStringBuilder().ToString());
        }
    }
}
