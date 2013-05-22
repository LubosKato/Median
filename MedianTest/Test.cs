using System;
using System.Collections.Generic;
using NUnit.Framework;
using Exercise;

namespace ExcerciseTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMedian()
        {
            IEnumerable<double?> findMedian = new List<double?> { 3, 5, 7, 12, 13, 14, 21, 23, 23, 23, 23, 29, 39, 40, 56 };
            double median = findMedian.ComputeMedian();
            Assert.AreEqual(23, median);
        }

        [Test]
        public void TestMedianNullable()
        {
            IEnumerable<double?> findMedian = new List<double?> { 3, 5, 7,  null, 13, 14, 21, 23, 23, 23, 23, 29, null, 40, 56 };
            double median = findMedian.ComputeMedian();
            Assert.AreEqual(23, median);
        }

        [Test]
        [ExpectedException(typeof(NotImplementedException))]     
        public void TestMedianNull()
        {
            IEnumerable<double?> findMedian = new List<double?>{};
            double median = findMedian.ComputeMedian();
            Assert.AreEqual(23, median);
        }
    }
}
