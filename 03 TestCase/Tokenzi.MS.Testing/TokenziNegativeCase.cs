using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using Tokenzi.Logic;

namespace Tokenzi.MS.Testing
{
    [TestClass]
    public class TokenziNegativeCase
    {
        #region Default Declaraction

        string inputString = null;
        StringBuilder expected = new StringBuilder();

        #endregion Default Declaraction

        #region Test Initialize 
        /// <summary>
        /// Test Initialize Default Value
        /// </summary>
        [TestInitialize]
        public void NegativeCaseInit()
        {
            inputString = "xyz abc mnp 'asdf dfaa asdf' asd 'fdas asdsadafF'";
            expected = expected.Append("xyz");
            expected = expected.Append("abc");
            expected = expected.Append("wsx");
            expected = expected.Append("'asdf dfaa asdf'");
            expected = expected.Append("asd");
            expected = expected.Append("'fdas asdsadafF'");
        }

        #endregion Test Initalize 

        #region Test Cleanup
        /// <summary>
        /// Test Cleanup 
        /// </summary>
        [TestCleanup]
        public void NegativeCaseClean()
        {
            inputString = null;
            expected = null;
        }

        #endregion Test Cleanup

        #region Test Method
        /// <summary>
        /// Define test and executate
        /// </summary>
        [TestMethod]
        public void NegativeCaseTest()
        {
            // Act
            StringTokenziLogic stringTokenziLogic = new StringTokenziLogic();
            StringBuilder actual = stringTokenziLogic.TestCaseStrTokenzi(inputString);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        #endregion Test Method
    }
}
