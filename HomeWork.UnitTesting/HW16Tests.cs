using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomeWork.UnitTesting
{
    [TestClass]
    public class HW16Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, 2, new int[] { 1, 1, 2, 2, 3, 3 }, DisplayName = "buildK_validArr_K2_ReturnsArrWithEveryMemberDuplicated2Times")]
        [DataRow(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3 }, DisplayName = "buildK_validArr_K0_ReturnsArrWithSameMembersAsOriginal")]
        [DataRow(new int[] { 1, 2, 3 }, -1, new int[] { 1, 2, 3 }, DisplayName = "buildK_validArr_KMinus1_ReturnsArrWithSameMembersAsOriginal")]

        public void BuildK(int[] a, int k, int[] expected)
        {
            // Arrange
            int[] actual;

            // Act
            actual = HW16.BuildK(a, k);

            // Assert
            Assert.AreEqual(expected.Length, actual.Length, "Error in array length");
            for (int i = 0; i < expected.Length; i++)
                Assert.AreEqual(expected[i], actual[i], "Error at index #" + i);

        }


        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 1, 2, 2, 3, 3 }, 2, DisplayName = "IsCopyK_ArrOf3Nums_BrrEachMemberInArrIsThere2Times_Returns2")]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 3 }, 0, DisplayName = "IsCopyK_ArrOf3Nums_BrrNotValid_Returns0")]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3 }, 4, DisplayName = "IsCopyK_ArrOf3Nums_BrrEachMemberInArrIsThere4Times_Returns4")]

        public void IsCopyK(int[] arr, int[] brr, int expected)
        {
            // Arrange
            int actual;

            // Act
            actual = HW16.IsCopyK(arr, brr);

            // Assert
            Assert.AreEqual(expected, actual, "Should return " + expected + " but got " + actual);

        }


        //[DataTestMethod]
        //[DataRow(new object[] { new int[] { 1, 2, 3 }, 2 }, new object[] { new int[] { 1, 1, 2, 2, 3, 3 } }, DisplayName = "buildK_validArr_K2_ReturnsArrWithEveryMemberDuplicated2Times")]
        //[DataRow(new object[] { new int[] { 1, 2, 3 }, 0 }, new object[] { new int[] { 1, 2, 3 } }, DisplayName = "buildK_validArr_K0_ReturnsArrWithSameMembersAsOriginal")]
        //[DataRow(new object[] { new int[] { 1, 2, 3 }, -1 }, new object[] { new int[] { 1, 2, 3 } }, DisplayName = "buildK_validArr_KMinus1_ReturnsArrWithSameMembersAsOriginal")]

        //public void buildK_DynamicObj(object[] aData, object[] expected)
        //{
        //    // Arrange
        //    int[] actual;
        //    int[] input = (int[])aData[0];
        //    int[] expectedArr = (int[])expected[0];
        //    // Act
        //    actual = HW16.BuildK(input, Convert.ToInt32(aData[1]));

        //    // Assert
        //    Assert.AreEqual(expectedArr.Length, actual.Length, "Error in array length");
        //    for (int i = 0; i < expectedArr.Length; i++)
        //        Assert.AreEqual(expectedArr[i], actual[i], "Error at index #" + i);

        //}
    }
}
