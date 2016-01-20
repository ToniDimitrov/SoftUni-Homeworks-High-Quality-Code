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
        private DynamicList<object> dynamicList;

        [TestInitialize]
        public void InitializeList()
        {
            this.dynamicList = new DynamicList<object>();
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIndexerGetter_NegativeIndex_ShouldThrowException()
        {
            var testElement = this.dynamicList[-9];
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIndexerGetter_IndexLargerThanElementsCount_ShouldThrowException()
        {
            var testCount = this.dynamicList.Count + 1;
            var testElement = this.dynamicList[testCount];
        }

        [TestMethod]
        public void TestIndexerGetter_CorrectInput()
        {
            this.dynamicList.Add(5.1334);

            ValueType expectedElement = 5.1334;

            Assert.AreEqual(expectedElement, this.dynamicList[0], "The indexer getter doesn't return the right value");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIntexerSetter_NegativeIndex_ShouldThrowException()
        {
            this.dynamicList[-1] = 5;
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestIntexerSetter_IndexLargerThanElementsCount_ShouldThrowException()
        {
            var testCount = this.dynamicList.Count + 1;
            this.dynamicList[testCount] = 5;
        }

        [TestMethod]
        public void TestIndexerSetter_CorrectInput()
        {
            this.dynamicList.Add(10);

            this.dynamicList[0] = 17777777777965465440;
            var expectedElement = 17777777777965465440;

            Assert.AreEqual(expectedElement, this.dynamicList[0], "The indexer setter doesn't set the right value");
        }

        [TestMethod]
        public void TestAdd_EmptyList()
        {
            this.dynamicList.Add(22);

            var expectedElement = 22;

            Assert.AreEqual(expectedElement, this.dynamicList[this.dynamicList.Count - 1],
                "The add method doesn't add the right element in an empty list");
        }

        [TestMethod]
        public void TestAdd_NonEmptyList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(44);
            this.dynamicList.Add(88);

            var expectedElement = 88;

            Assert.AreEqual(expectedElement, this.dynamicList[this.dynamicList.Count - 1],
                "The add method doesn't add the right element in a non-empty list");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestAdd_EmptyList_NullValue_ShouldThrowException()
        {
            this.dynamicList.Add(null);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestAdd_NonEmptyList_NullValue_ShouldThrowException()
        {
            this.dynamicList.Add(33);
            this.dynamicList.Add(null);
        }

        [TestMethod]
        public void TestCountIncrementation_Add()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(32);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicList.Count,
                "The add method doesn't increment the elements count when adding new element");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_NegativeIndex_ShouldThrowException()
        {
            this.dynamicList.RemoveAt(-5);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_IndexLargerThanElementsCount_ShouldThrowException()
        {
            this.dynamicList.RemoveAt(this.dynamicList.Count + 1);
        }

        [TestMethod]
        public void TestRemoveAt_ValueContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var expectedElement = 33;

            Assert.AreEqual(expectedElement, this.dynamicList.RemoveAt(1),
                "The RemoveAt method doesn't return the right element");
        }

        [TestMethod]
        public void TestCountDecrementation_RemoveAt()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            this.dynamicList.RemoveAt(1);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicList.Count,
                "The RemoveAt method doesn't decrement the elements count when removing an element");
        }

        [TestMethod]
        public void TestIfElementRemoved_RemoveAt()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var elementToBeRemoved = this.dynamicList.RemoveAt(1);
            ;

            bool isElementRemoved = true;
            for (var i = 0; i < this.dynamicList.Count; i++)
            {
                if (this.dynamicList[i].Equals(elementToBeRemoved))
                {
                    isElementRemoved = false;
                }
            }

            Assert.AreEqual(true, isElementRemoved, "The RemoveAt method doesn't remove the element");
        }

        [TestMethod]
        public void TestRemove_ValueContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            ValueType expectedIndex = 1;

            Assert.AreEqual(expectedIndex, this.dynamicList.Remove(33),
                "The Remove method doesn't return the right element");
        }

        [TestMethod]
        public void TestRemove_ValueNotContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var excpetedResult = -1;

            Assert.AreEqual(excpetedResult, this.dynamicList.Remove(55),
                "The Remove method doesn't return the right value when given element not present in the list");
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestRemove_NullValue_ShouldThrowException()
        {
            this.dynamicList.Remove(null);
        }

        [TestMethod]
        public void TestIfElementRemoved_Remove()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var elementToBeRemoved = this.dynamicList.Remove(1);
            ;

            bool isElementRemoved = true;
            for (var i = 0; i < this.dynamicList.Count; i++)
            {
                if (this.dynamicList[i].Equals(elementToBeRemoved))
                {
                    isElementRemoved = false;
                }
            }

            Assert.AreEqual(true, isElementRemoved, "The Remove method doesn't remove the element");
        }

        [TestMethod]
        public void TestCountDecrementation_Remove()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            this.dynamicList.Remove(33);

            var expectedCount = 2;

            Assert.AreEqual(expectedCount, this.dynamicList.Count,
                "The remove method doesn't decrement the elements count when removing an element");
        }

        [TestMethod]
        public void TestIndexOf_ValueContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var expectedIndex = 1;

            Assert.AreEqual(expectedIndex, this.dynamicList.IndexOf(33),
                "The IndexOf method doesn't return the right index when given element contained in the list");
        }

        [TestMethod]
        public void TestIndexOf_ValueNotContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            var expectedResult = -1;

            Assert.AreEqual(expectedResult, this.dynamicList.IndexOf(55),
                "The IndexOf method doesn't return the right value when given value not contained in the list");
        }


        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestIndexOf_NullValue_ShouldThrowException()
        {
            this.dynamicList.IndexOf(null);
        }

        [TestMethod]
        public void TestContains_ValueContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33);
            this.dynamicList.Add(44);

            bool expectedResult = true;

            Assert.AreEqual(expectedResult, this.dynamicList.Contains(22),
                "The Contains method can't find the element");
        }

        [TestMethod]
        public void TestContains_ValueNotContainedInList()
        {
            this.dynamicList.Add(22);
            this.dynamicList.Add(33.135464644444686);
            this.dynamicList.Add(44);

            bool expectedResult = false;

            Assert.AreEqual(expectedResult, this.dynamicList.Contains(55),
                "The contains method doesn't return the right value when given element not contained in the list");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentNullException))]
        public void TestContains_NullValue_ShouldThrowException()
        {
            this.dynamicList.Contains(null);
        }
    }
}