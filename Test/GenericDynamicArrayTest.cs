using System.Reflection;
using NUnit.Framework;
using Samples.DataStructures;
using System;

namespace Test
{
    public class Tests
    {
        private GenericDynamicArray<String> array;

        [SetUp]
        public void Setup()
        {
            array = new GenericDynamicArray<String>(4);
        }

        [Test]
        public void GetAndSet()
        {
            array.Set(0, "a");
            Assert.AreEqual(array.Get(0), "a");

        }
    }
}