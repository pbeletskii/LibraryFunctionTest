using LibraryFunctionTest;
using System.Security.Principal;

namespace LibralyFunctionTestTests
{
    [TestClass]
    public class Class_FunctionTests
    {
        [TestMethod]
        public void f_1Equals1_DivideByZeroException()
        {
            //Arrange
            double x = 1;
            double N = 1;

            //Act
            Class_Function test = new Class_Function();

            //Assert
            Assert.ThrowsException<System.DivideByZeroException>(() => test.f(x, 1, N));
        }
        [TestMethod]
        public void f_ArgumentZero_ArgumentOutOfRangeException()
        {
            // Arrange
            double x = 2;
            double k = 1;
            Class_Function account = new Class_Function();

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.f(x,k,0));
        }
        [TestMethod]
        public void f_0i1i05_TestMethod2()
        {
            //Arrange
            double x = 1;
            double k = 2;
            double N = 0;
            double expected = 0.53;

            //Act
            Class_Function test = new Class_Function();
            double actual = test.f(x,k,N);

            //Assert
            Assert.IsFalse(expected == actual);
        }
    }
}