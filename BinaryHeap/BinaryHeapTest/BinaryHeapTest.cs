using BinaryHeap;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BinaryHeapTest
{
    
    
    /// <summary>
    ///This is a test class for BinaryHeapTest and is intended
    ///to contain all BinaryHeapTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BinaryHeapTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for BinaryHeap`2 Constructor
        ///</summary>
        public void BinaryHeapConstructorTestHelper<TPriority, TValue>()
        {
            int capacity = 0; // TODO: Initialize to an appropriate value
            Func<TPriority, TPriority, int> priorityComparison = null; // TODO: Initialize to an appropriate value
            BinaryHeap<TPriority, TValue> target = new BinaryHeap<TPriority, TValue>(capacity, priorityComparison);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void BinaryHeapConstructorTest()
        {
            BinaryHeapConstructorTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Minimum
        ///</summary>
        public void MinimumTestHelper<TPriority, TValue>()
        {
            BinaryHeap<TPriority, TValue> target = new BinaryHeap<TPriority, TValue>(); // TODO: Initialize to an appropriate value
            KeyValuePair<TPriority, TValue> expected = new KeyValuePair<TPriority, TValue>(); // TODO: Initialize to an appropriate value
            KeyValuePair<TPriority, TValue> actual;
            actual = target.Minimum();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void MinimumTest()
        {
            MinimumTestHelper<GenericParameterHelper, GenericParameterHelper>();
        }

        [TestMethod()]
        public void sameValue()
        {
            BinaryHeap<int, int> target = new BinaryHeap<int, int>();

            target.Add(0, 1);
            target.Add(0, 1);
            
            //Assert.IsTrue(target. == 2);

        }

        [TestMethod()]
        public void updateTest()
        {
            BinaryHeap<int, int> target = new BinaryHeap<int, int>();

            target.Add(0, 0);
            target.Update(1, 0);
            Assert.IsTrue(target.IndexOf(1) == 0);

            //target.Update(1, 1);
        }

        [TestMethod()]
        public void ordering()
        {
            BinaryHeap<int, int> target = new BinaryHeap<int, int>();

            target.Add(0, 1);
            target.Add(1, 2);
            target.Add(1, 3);
            Assert.IsTrue(target.IndexOf(3) == 2);

        }

        [TestMethod()]
        public void removeAtTest()
        {
            BinaryHeap<int, int> target = new BinaryHeap<int, int>();
            target.Add(1, 3);
            target.Add(1, 2);
            Assert.IsTrue(target.IndexOf(2) == 0);

            target.Add(0, 1);

            Assert.IsTrue(target.Minimum().Key == 0 );
            Assert.IsTrue(target.RemoveAt(2).Value == 2 );
            Assert.IsTrue(target.RemoveAt(0).Value == 1);
            


        }

        [TestMethod()]
        public void minimunTest()
        {
            BinaryHeap<int, int> target = new BinaryHeap<int, int>();
            target.Add(0, 3);
            
            target.Add(0, 2);
            Assert.IsTrue(target.Minimum().Value == 2);
            
            target.Add(0, 1);

            Assert.IsTrue(target.Minimum().Value == 1);
            

        }

    }
}
