namespace Calc
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool f = true;
            int a = 1;
            int b = 2;
           // Assert.AreEqual(a, b);
           // Assert.AreNotEqual(a, a);
           // Assert.AreSame(a,a);
           // Assert.AreNotSame(a,b);
           // Assert.IsFalse(f);
           // Assert.IsTrue(f);
           // Assert.IsNull(a);
           // Assert.IsNotNull(b);
           // Assert.IsInstanceOfType(a, typeof(int));
           // Assert.IsNotInstanceOfType(a, typeof(string));
            // Assert.ThrowsException();
           // Assert.Fail();
         }

        Calc calc = new Calc(2);

        [TestMethod]
        public void CalcMultiplyTest()
        {
           
            int i1 = calc.Multiply(2); // i1= 4
            int i2 = calc.Multiply(2); // i2= 8
            int i3 = calc.Multiply(2); // i3=16
            int i4 = calc.Multiply(2); // i4=32
            Assert.AreEqual(4, i1);
            Assert.AreEqual(8, i2);
            Assert.AreEqual(16, i3);
            Assert.AreEqual(32, i4);
         }

        [TestMethod]
        public void CalcDevideTest()
        {
            Assert.ThrowsException<DivideByZeroException>(() =>
            {
                calc.Divide(0);
             });
        }

        [TestMethod]
        public void CalcSumTest()
        {
            int i5 = calc.Sum(10); //12
            int i6 = calc.Sum(20); // 12+20=32
            int i7 = calc.Sum(40); // 32+40=72
            int i8 = calc.Sum(50); // 72+50 =122
            Assert.AreEqual(12, i5);
            Assert.AreEqual(32, i6);
            Assert.AreEqual(72, i7);
            Assert.AreEqual(122, i8); 
        }

        [TestMethod]
        public void CalcMinusTest()
        {
            int i9 = calc.Minus(1); // 1
            int i10 = calc.Minus(1); //0 
            double i11 = calc.Minus(5); //-5
            Assert.AreEqual(1, i9);
            Assert.AreEqual(0, i10);
            Assert.AreEqual(-5, i11);
        }

        [TestMethod]
        public void CalcABSTest()
        {
            int i12 = calc.Abs(5); //5
            int i13 = calc.Abs(-10); //10
            int i14 = calc.Abs(-30); //30
            Assert.AreEqual(5, i12);
            Assert.AreEqual(10, i13);
            Assert.AreEqual(30, i14);
        }
    }
}