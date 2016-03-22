﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlFormatter;

namespace SqlFormatter_Test
{
    [TestClass]
    public class UnitTestUpdates
    {
        [TestMethod]
        public void Update()
        {
            var expected = "UPDATE TEST \n" +
                           "SET COLUMN_1 = COLUMN_1";
            var formatter = new Formatter("UPDATE TEST SET COLUMN_1 = COLUMN_1");
            Assert.AreEqual(expected, formatter.Format());
        }

        [TestMethod]
        public void Update_Where()
        {
            var expected = "UPDATE TEST \n" +
                           "SET COLUMN_1 = COLUMN_1\n" +
                           "WHERE COLUMN_1 = COLUMN_2";
            var formatter = new Formatter("UPDATE TEST SET COLUMN_1 = COLUMN_1 WHERE COLUMN_1 = COLUMN_2");
            Assert.AreEqual(expected, formatter.Format());
        }

        [TestMethod]
        public void Update_WhereVariable()
        {
            var expected = "UPDATE TEST \n" +
                           "SET COLUMN_1 = @VAR_2\n" +
                           "WHERE COLUMN_1 = @VAR_1\n" +
                           "  AND COLUMN_2 = @VAR_2";
            var formatter = new Formatter("UPDATE TEST SET COLUMN_1 = @VAR_2 WHERE COLUMN_1 = @VAR_1 AND COLUMN_2 = @VAR_2");
            Assert.AreEqual(expected, formatter.Format());
        }
    }
}