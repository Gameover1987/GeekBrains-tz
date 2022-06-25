using ArrayCopy.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayCopy.Test
{
    [TestClass]
    public class ArrayHelperTest
    {
        [DataRow(new[] { 1, 2, 3 })]
        [TestMethod]
        public void ShouldPerformIntArrayCopy(int[] sourceArray)
        {
            // Given
            // When
            var actualArray = sourceArray.MakeCopy();

            // Then
            CompareArrays(actualArray, sourceArray);
        }

        [DataRow(new[] { "1", "2", "3" })]
        [TestMethod]
        public void ShouldPerformStringArrayCopy(string[] sourceArray)
        {
            // Given
            // When
            var actualArray = sourceArray.MakeCopy();

            // Then
            CompareArrays(actualArray, sourceArray);
        }


        [DataRow(new[] { "1", null, "3" })]
        [TestMethod]
        public void ShouldPerformStringWithNullArrayCopy(string[] sourceArray)
        {
            // Given
            // When
            var actualArray = sourceArray.MakeCopy();

            // Then
            CompareArrays(actualArray, sourceArray);
        }

        private static void CompareArrays<T>(T[] actualArray, T[] expectedArray)
        {
            Assert.IsTrue(actualArray.LongLength == expectedArray.LongLength, "Размеры массивов должны быть равны");
            for (int i = 0; i < actualArray.LongLength; i++)
            {
                if (actualArray[i] == null && expectedArray[i] != null)
                    Assert.Fail("Элементы должны совпадать");

                if (actualArray[i] != null && expectedArray[i] == null)
                    Assert.Fail("Элементы должны совпадать");

                if (actualArray[i] == null && expectedArray[i] == null)
                    continue;

                Assert.IsTrue(actualArray[i].Equals(expectedArray[i]), "Элементы должны совпадать");
            }
        }
    }
}