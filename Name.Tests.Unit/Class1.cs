﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute; 


namespace Name.Tests.Unit
{
    [TestFixture]
    public class Class2
    {
        [Test]
        public void TestCase()
        {
            Assert.That(true, Is.EqualTo(true));
        }
    }
}
