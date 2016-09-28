using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HackerRank.Algorithms.Warmup
{
    class Compare_the_Triplets
    {
        private TextReader _in;
        private TextWriter _out;

        public Compare_the_Triplets(TextReader IN, TextWriter OUT)
        {
            _out = OUT;
            _in = IN;
        }

        public void Resolve()
        {
            var tokenList = Enumerable.Range(0, 2)
                .Select(i => _in.ReadLine().Split(' ').Select(int.Parse).ToList()).ToList();

            var nbItems = tokenList[0].Count();

            var bobScore = 0;
            var aliceScore = 0;

            Enumerable.Range(0, nbItems).Select(i =>
            {
                var r = tokenList[0].ToList()[i] - tokenList[1].ToList()[i];

                if (r > 0)
                    aliceScore++;
                else if (r < 0)
                    bobScore++;

                return i;
            }).ToList();

            _out.Write($"{aliceScore} {bobScore}");
        }
    }

    [TestFixture]
    public class Compare_the_Triplets_Test
    {
        [Test]
        public void GetSimpleSumArray()
        {
            var input = @"5 6 7
3 6 10";

            var output = new StringWriter();

            new Compare_the_Triplets(new StringReader(input), output).Resolve();

            Assert.AreEqual("1 1", output.GetStringBuilder().ToString());
        }
    }
}
