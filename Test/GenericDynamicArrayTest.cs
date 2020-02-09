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

        [Test]
        public void Insert()
        {
            array.Add("a");
            array.Add("b");
            array.Add("c");

            array.Insert(1, "d");
            Assert.AreEqual(array.Get(0), "a");
            Assert.AreEqual(array.Get(1), "d");
            Assert.AreEqual(array.Get(2), "b");
            Assert.AreEqual(array.Get(3), "c");
        }

        [Test]
        public void Delete()
        {
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Add("d");
            array.Add("e");
            array.Add("f");

            array.Delete(0);
            array.Delete(5);
            Assert.AreEqual(array.Get(0), "b");
            Assert.AreEqual(array.Get(1), "c");
            Assert.AreEqual(array.GetSize(), 4);
        }

        [Test]
        public void IsEmpty()
        {
            Assert.AreEqual(array.IsEmpty(), true);
        }

        [Test]
        public void Contains()
        {
            array.Add("a");
            array.Add("b");
            array.Add("c");
            array.Add("d");
            array.Add("e");
            array.Add("f");

            Assert.AreEqual(array.Contains("f"), true);
            Assert.AreEqual(array.Contains("t"), false);
        }
    }
}