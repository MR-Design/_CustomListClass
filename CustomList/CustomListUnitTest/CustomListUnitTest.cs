using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 16;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 16;
            int countValue = 1;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(customList.Count, countValue);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 16;
            int value1 = 20;


            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        /////////////////////////////////////////////////////////////
        /// <summary>
        ///     [TestMethod]
        public void Test_New_Capacity()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value1 = 20;
            int Capaticy = 8;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value);
            customList.Add(value1);


            //Assert
            Assert.AreEqual(Capaticy, customList.Capacity);
        }
        /// </summary>
        [TestMethod]
        public void TestByIndexOF_list_Remove()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value1 = 20;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Remove(value1);


            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        public void TestByCount_list_Remove()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value2 = 20;
            int CountValue = 1;

            //Act
            customList.Add(value);
            customList.Add(value2);
            customList.Remove(20);


            //Assert
            Assert.AreEqual(CountValue, customList.Count);
        }

    
       
    }
}


