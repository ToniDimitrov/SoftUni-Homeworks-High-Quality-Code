using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTests
{
    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> dynamicList;

        [TestInitialize]
        public void InitializeList()
        {
            dynamicList = new DynamicList<int>();
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIndexerGetter_NegativeValue_ShouldThrowException()
        {
            int testElement = dynamicList[-9];
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIndexerGetter_OutsideOfRangeOfList_ShouldThrowException()
        {
            int testCount = dynamicList.Count + 1;
            int testElement = dynamicList[testCount];
        }

        [TestMethod]
        public void TestIndexerGetter_TestWithCorrectInput()
        {
            dynamicList.Add(5);

            int expectedElement = 5;

            Assert.AreEqual(expectedElement, dynamicList[0]);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIntexerSetter_NegativeValue_ShouldThrowException()
        {
            dynamicList[-1] = 5;
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIntexerSetter_OutsideOfRangeOfList_ShouldThrowException()
        {
            int testCount = dynamicList.Count + 1;
            dynamicList[testCount] = 5;
        }

        [TestMethod]
        public void TestIndexerSetter_TestWithCorrectInput()
        {
            dynamicList.Add(10);

            dynamicList[0] = 19;
            int expectedElement = 19;

            Assert.AreEqual(expectedElement, dynamicList[0]);
        }

        [TestMethod]
        public void TestAdd_EmptyList()
        {
            dynamicList.Add(22);

            int expectedElement = 22;

            Assert.AreEqual(expectedElement, dynamicList[dynamicList.Count - 1]);
        }

        [TestMethod]
        public void TestAdd_NonEmptyList()
        {
            dynamicList.Add(22);
            dynamicList.Add(44);
            dynamicList.Add(88);

            int expectedElement = 88;

            Assert.AreEqual(expectedElement, dynamicList[dynamicList.Count - 1]);
        }

        [TestMethod]
        public void TestCountIncrementation_Add()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, dynamicList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_NegativeIndex_ShouldThrowException()
        {
            dynamicList.RemoveAt(-5);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_IndexOutsideOfRange_ShouldThrowException()
        {
            dynamicList.RemoveAt(dynamicList.Count + 1);
        }

        [TestMethod]
        public void TestRemoveAt_CorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            int expectedElement = 33;

            Assert.AreEqual(expectedElement, dynamicList.RemoveAt(1));
        }

        [TestMethod]
        public void TestCountDecrementation_RemoveAt()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            dynamicList.RemoveAt(1);

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, dynamicList.Count);
        }

        [TestMethod]
        public void TestIfElementRemoved_RemoveAt()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            dynamicList.RemoveAt(1);

            int elementToBeRemoved = 33;

            bool isElementRemoved = true;
            for (int i = 0; i < dynamicList.Count; i++)
            {
                if (dynamicList[i].Equals(elementToBeRemoved))
                {
                    isElementRemoved = false;
                }
            }

            Assert.IsTrue(isElementRemoved);
        }

        [TestMethod]
        public void TestRemove_CorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            int expectedIndex = 1;

            Assert.AreEqual(expectedIndex, dynamicList.Remove(33));
        }

        [TestMethod]
        public void TestRemove_IncorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            int excpetedResult = -1;

            Assert.AreEqual(excpetedResult, dynamicList.Remove(55));
        }

        [TestMethod]
        public void TestCountDecrementation_Remove()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            dynamicList.Remove(33);

            int expectedCount = 2;

            Assert.AreEqual(expectedCount, dynamicList.Count);
        }

        [TestMethod]
        public void TestIndexOf_CorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            int expectedIndex = 1;

            Assert.AreEqual(expectedIndex, dynamicList.IndexOf(33));
        }

        [TestMethod]
        public void TestIndexOf_IncorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            int expectedResult = -1;

            Assert.AreEqual(expectedResult, dynamicList.IndexOf(55));
        }

        [TestMethod]
        public void TestContains_CorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            bool expectedResult = true;

            Assert.AreEqual(expectedResult, dynamicList.Contains(22));
        }

        [TestMethod]
        public void TestContains_IncorrectInput()
        {
            dynamicList.Add(22);
            dynamicList.Add(33);
            dynamicList.Add(44);

            bool expectedResult = false;

            Assert.AreEqual(expectedResult,dynamicList.Contains(55));
        }
    }
}
