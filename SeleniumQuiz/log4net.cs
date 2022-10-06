
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace log4net

{

    [TestClass]

    public class log4net

    {

        private static readonly log4net.ILog log =

        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [TestMethod]

        public void TestCase_01()

        {

            log.Info("Application is working");

        }

    }

}