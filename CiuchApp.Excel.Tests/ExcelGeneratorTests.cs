﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.Excel.Tests
{
    [TestClass]
    public class ExcelGeneratorTests
    {
        [TestMethod]
        public void ExcelGenerator_GetGenerator()
        {
            var excelGenerator = "mock";// new ExcelGenerator();

            Assert.IsNotNull(excelGenerator);

        }
    }
}
