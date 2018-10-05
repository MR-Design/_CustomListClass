using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {

        [TestMethod]
        public void AddValue_Return_CountIncreaseByOne()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int countValue = 1;

            //Act
            customList.Add(value);

            //Assert
            Assert.AreEqual(customList.Count, countValue);
        }

        [TestMethod]
        public void AddedValue_Returen_IndexValue()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value1 = 20;


            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(value, customList[0]);
        }

        [TestMethod]

        public void CheckCapacity4_AddValueNextIndex_Return_Zero()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value1 = 10;
            int value2 = 20;
           
            int ExpectedResult = 0;

            //Act
            customList.Add(value1);
            customList.Add(value2);
          

            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList[3]);
        }

        [TestMethod]
        public void Add_Over4Arrays_Return_Capacity_8()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value1 = 20;
            int Capaticy = 8;
            int ExpectedResult = Capaticy;

            //Act
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value);
            customList.Add(value1);
            customList.Add(value1);


            //Assert
            Assert.AreEqual(ExpectedResult, customList.Capacity);
        }
        /// </summary>
        [TestMethod]
        public void TestByIndexOF_Add_Methode()
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
        [TestMethod]
        public void TestByCount_Add_Methode()
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

        [TestMethod]
        public void Remove_Value_Returen_CountDecreise()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value2 = 20;
            int CountValue = 1;
            int ExpectedResult = CountValue;
            
            //Act
            customList.Add(value);
            customList.Add(value2);
            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList.Count);
        }

        [TestMethod]
        //

        public void RemoveValueIfArrayLenghtIs5_ReturenCapacityDicrease()
        {
            //Arrange
            CList<int> customList = new CList<int>(); // Need Inumerable{ 10, 20, 30, 40 };
            int value = 10;
            int value2 = 20;
            int Capacity = 4;
            int ExpectedResult = Capacity;

            //Act
            customList.Add(value);
            customList.Add(value2);
            customList.Add(value);
            customList.Add(value);
            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList.Capacity);
        }

        [TestMethod]
        //

        public void RemoveValue_NextValue_GetNewIndex()
        {
            //Arrange
            CList<int> customList = new CList<int>(); 
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int ExpectedResult = value3;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
           
            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList[1]);       
        }

          [TestMethod]
        //

        public void RemoveValue_Return_NewCount()
        {
            int count = 8;
            int ExpectedResult = count;
            //Arrange
            CList<int> customList = new CList<int>(); 
            int value1 = 10;
            int value2 = 20;
            int value3 = 30;
            int value4 = 40;
            int value5 = 50;
            int value6 = 60;
            int value7 = 70;
            int value8 = 80;
            int value9 = 90;
            

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value5);
            customList.Add(value6);
            customList.Add(value7);
            customList.Add(value8);
            customList.Add(value9);

            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList.Count);       
        }

    
    }
}


