﻿using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    [Ignore("Not using these tests yet")]
    public class CounterTests
    {
        private Counter _sut;

        //[SetUp]
        //public void SetUp()
        //{
        //    _sut = new Counter(6);
        //}

        // Using SetUp is considered bad practise as it is always called before a Test
        // Creating your own method is considered lighter on the system.

        public void CreateNewCounter()
        {
            _sut = new Counter(6);
        }

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            CreateNewCounter();

            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }

        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            CreateNewCounter();

            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }
    }
}
