using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW16Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 2, new int[] { 1, 1, 2, 2, 3, 3 }, DisplayName = "buildK_validArr_K2_ReturnsArrWithEveryMemberDuplicated2Times")]
        [DataRow(new int[] { 1, 2, 3 }, 0, new int[] { }, DisplayName = "buildK_validArr_K0_ReturnsEmptyArr")]
        [DataRow(null, 7, null, DisplayName = "buildK_ArrIsNull_ReturnsNull")]

        public void BuildK(int[] a, int k, int[] expected)
        {
            // Arrange
            int[] actual;

            // Act
            actual = HW16.BuildK(a, k);

            // Assert

            if (expected == null && a == null)
            {
                Assert.IsTrue(true);
                return;
            }
            if (expected == null && a != null)
                Assert.Fail("Should return null but didnt");

            if (expected != null && a == null)
                Assert.Fail("Should not return null but we got it");

            Assert.AreEqual(expected.Length, actual.Length, "Error in array length");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Error at index #" + i);

        }


        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 }, 2, DisplayName = "IsCopyK_ArrOf3Nums_BrrEachMemberInArrIsThere2Times_Returns2")]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 3 }, 0, DisplayName = "IsCopyK_ArrOf3Nums_BrrNotValid_Returns0")]
        [DataRow(null, new int[] { 1, 2, 3 }, 0, DisplayName = "IsCopyK_ArrIsNull_BrrValidArr_Returns0")]

        public void IsCopyK(int[] arr, int[] brr, int expected)
        {
            // Arrange
            int actual;

            // Act
            actual = HW16.IsCopyK(arr, brr);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);

        }



        [DataTestMethod]
        [DynamicData("BuildKTestGenerator", DynamicDataSourceType.Method)]
        public void BuildK_DynamicData(int[] a, int k, int[] expected)
        {
            // Arrange
            int[] actual;

            // Act
            actual = HW16.BuildK(a, k);

            // Assert

            if (expected == null && a == null)
            {
                Assert.IsTrue(true);
                return;
            }
            if (expected == null && a != null)
                Assert.Fail("Should return null but didnt");

            if (expected != null && a == null)
                Assert.Fail("Should not return null but we got it");

            Assert.AreEqual(expected.Length, actual.Length, "Error in array length");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Error at index #" + i);

        }


        public static object[][] BuildKTestGenerator()
        {
            return new[]
            {
                new object[] { new int[] { 1, 2, 3 }, 2, new int[] { 1, 1, 2, 2, 3, 3 } },
                new object[] {new int[] { 1, 2, 3 }, 0, new int[] { } },
                new object[] { null, 7, null }

            };
        }



        [DataTestMethod]
        [DynamicData("IsCopyKTestGenerator", DynamicDataSourceType.Method)]
        public void IsCopyK_DynamicData(int[] arr, int[] brr, int expected)
        {
            // Arrange
            int actual;

            // Act
            actual = HW16.IsCopyK(arr, brr);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);

        }

        public static object[][] IsCopyKTestGenerator()
        {
            return new[]
            {
                new object[] {new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 }, 2},
                new object[] { new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 3 }, 0 },
                new object[] { null, new int[] { 1, 2, 3 }, 0 },
            };
        }


    }
}
