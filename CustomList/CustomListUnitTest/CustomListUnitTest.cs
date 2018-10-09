using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;


namespace CustomListUnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {

        [TestMethod]
        public void AddValue_Return_expected_Count_1_()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int count = 1;
            int ExpectedResult = count;
            //Act
             customList.Add(value);

            //Assert
            Assert.AreEqual(customList.Count, count);
        }

        [TestMethod]
        public void Add_to_List_Returen_Index_0_Expected_Value_10()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value1 = 20;
            int ExpectedResult = value;

            //Act
            customList.Add(value);
            customList.Add(value1);

            //Assert
            Assert.AreEqual(ExpectedResult, customList[0]);
        }

        [TestMethod]

        public void Capacity_Check_Add_to_List_then_Remove_Index_3_ExpectedReturn_0()
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
        public void Add_Over_4_Arrays_Return_Expected_Capacity_8()
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
        public void Remove_IndexOF_Add_Methode()
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
        public void TestByCount_Add_Methode_Return_Expected_Count_1()
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
        public void Remove_Value_Returen_CountDecreise_ExpectedValue_1_()
        {
            //Arrange
            CList<int> customList = new CList<int>();
            int value = 10;
            int value2 = 20;
            int Count = 1;
            int ExpectedResult = Count;
            
            //Act
            customList.Add(value);
            customList.Add(value2);
            customList.Remove(value2);


            //Assert
            Assert.AreEqual(ExpectedResult, customList.Count);
        }

        [TestMethod]
        //

        public void RemoveValueIfArrayLenghtIs5_Returen_Expected_CapacityDicrease_Value_4()
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
     

        public void RemoveValue_NextValue_expected_GetNewIndex_Value3()
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

        public void RemoveValue_Return_Expected_Count_8()
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

        [TestMethod]
        public void Adding_Two_Lists_Returns_Expected_Index_0()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 40, 50, 60 };
            CList<int> expected = new CList<int>() { 10, 20, 30, 40, 50, 60 };
            CList<int> actual = new CList<int>();
            int expectedResult = 10;

            // act
            actual = List1 + List2;

            // assert
            Assert.AreEqual(expectedResult, actual[0]);
        }

        [TestMethod]
        public void AddTwoListsInstance_Returns_Expected_Count_6()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 40, 50, 60 };
            CList<int> expected = new CList<int>() { 10, 20, 30, 40, 50, 60 };
            CList<int> actual = new CList<int>();
            int Count = 6;
            int expectedResult = Count;

            // act
            actual = List1 + List2;

            // assert
            Assert.AreEqual(expectedResult, actual.Count);
        }

        [TestMethod]
        public void AddTwoListsInstance_Returns_Expected_Capacity_8()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 40, 50, 60 };
            CList<int> expected = new CList<int>() { 10, 20, 30, 40, 50, 60 };
            CList<int> actual = new CList<int>();
            int Capacity = 8;
            int expectedResult = Capacity;

            // act
            actual = List1 + List2;

            // assert
            Assert.AreEqual(expectedResult, actual.Capacity);
        }


        /////////////////[- Operator]///////////////////////////////////////
        [TestMethod]
        public void Subtract_Two_Lists_Returns_Expected_Index_0_Value_10()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 30, 20, 60 };
            CList<int> expected = new CList<int>() { 10, 60 };
            CList<int> actual = new CList<int>();
            int expectedResult = 10;

            // act
            actual = List1 - List2;

            // assert
            Assert.AreEqual(expectedResult, actual[0]);
        }

        [TestMethod]
        public void Subtract_Two_Lists_Returns_Expected_Index_1_Value_60()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 30, 20, 60 };
            CList<int> expected = new CList<int>() { 10, 60 };
            CList<int> actual = new CList<int>();
            int expectedResult = 60;

            // act
            actual = List1 - List2;

            // assert
            Assert.AreEqual(expectedResult, actual[1]);
        }

        [TestMethod]
        public void SubtractListsInstance_Returns_Expected_Count_2()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 30, 20, 60 };
            CList<int> expected = new CList<int>() { 10, 60 };
            CList<int> actual = new CList<int>();
            int Count = 2;
            int expectedResult = Count;

            // act
            actual = List1 - List2;

            // assert
            Assert.AreEqual(expectedResult, actual.Count);
        }

        [TestMethod]
        public void SubtractTwoListsInstance_Returns_Expected_Capacity_5()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 10, 20, 30 };
            CList<int> List2 = new CList<int>() { 30, 20, 60 };
            CList<int> expected = new CList<int>() { 10, 60 };
            CList<int> actual = new CList<int>();
            int Capacity = 5;
            int expectedResult = Capacity;

            // act
            actual = List1 - List2;

            // assert
            Assert.AreEqual(expectedResult, actual.Capacity);
        }

        [TestMethod]
        public void Zip_Two_Lists_Returns_Expected_Index_0_Value_1()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 1, 3, 5 };
            CList<int> List2 = new CList<int>() { 2, 4, 6 };
            CList<int> expected = new CList<int>() { 1, 2, 3, 4, 5, 6 };
            CList<int> actual = new CList<int>();
            int expectedResult = 1;

            // act
            // actual.zip(List1, List2)
            // assert
            Assert.AreEqual(expectedResult, actual[0]);
        }

        [TestMethod]
        public void Zip_Two_Lists_Returns_Expected_Index_1_Value_2()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 1, 3, 5 };
            CList<int> List2 = new CList<int>() { 2, 4, 6 };
            CList<int> expected = new CList<int>() { 1, 2, 3, 4, 5, 6 };
            CList<int> actual = new CList<int>();
            int expectedResult = 2;

            // act
            // actual.zip(List1, List2)
            // assert
            Assert.AreEqual(expectedResult, actual[1]);
        }

        [TestMethod]
        public void Zip_Two_Lists_Returns_Expected_Index_5_Value_6()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 1, 3, 5 };
            CList<int> List2 = new CList<int>() { 2, 4, 6 };
            CList<int> expected = new CList<int>() { 1, 2, 3, 4, 5, 6 };
            CList<int> actual = new CList<int>();
            int expectedResult = 5;

            // act
            // actual.zip(List1, List2)

            // assert
            Assert.AreEqual(expectedResult, actual[5]);
        }

        [TestMethod]
        public void ZipListsInstance_Returns_Expected_Count_6()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 1, 3, 5 };
            CList<int> List2 = new CList<int>() { 2, 4, 6 };
            CList<int> expected = new CList<int>() { 1, 2, 3, 4, 5, 6 };
            CList<int> actual = new CList<int>();
            int Count = 6;
            int expectedResult = Count;

            // act
            // actual.zip(List1, List2)
            // assert
            Assert.AreEqual(expectedResult, actual.Count);
        }

        [TestMethod]
        public void ZipTwoListsInstance_Returns_Expected_Capacity_5()
        {
            // arrange
            CList<int> List1 = new CList<int>() { 1, 3, 5 };
            CList<int> List2 = new CList<int>() { 2, 4, 6 };
            CList<int> expected = new CList<int>() { 1, 2, 3, 4, 5, 6 };
            CList<int> actual = new CList<int>();
            int Capacity = 8;
            int expectedResult = Capacity;

            // act
           // actual.zip(List1, List2)

            // assert
           Assert.AreEqual(expectedResult, actual.Capacity);
        }
    }
}


