﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Handlers.TaskHandlers.Models.GR_TO.SapReader;

namespace TestProject.GR_TO_Test.SapReader
{
    [TestClass]
    public class XlsxSapReaderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Temp\zzpomon17.xlsx";
            ISapReader reader = new XlsxSapReader(path);
            reader.Read();
            if(reader.Succeed)
            {
                var rows = reader.Rows;
            }
        }
    }
}
