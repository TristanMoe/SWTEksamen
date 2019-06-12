using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace Name.Tests.Integration
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void Test()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
