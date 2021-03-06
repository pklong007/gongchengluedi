﻿using TestApp.fire;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    
    
    /// <summary>
    ///这是 ZlibCompressTest 的测试类，旨在
    ///包含所有 ZlibCompressTest 单元测试
    ///</summary>
    [TestClass()]
    public class ZlibCompressTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///DecompressBytes 的测试
        ///</summary>
        [TestMethod()]
        public void DecompressBytesTest()
        {
            byte[] arrOutput = { 0x2C, 0x49, 0x04, 0x89, 0x94, 0x24, 0x16, 0x67, 0x17, 0x2B, 0x59, 0x45, 0x57, 0x2B, 0x15, 0xA5, 0x16, 0xE7, 0x97, 0x16, 0x25, 0xA7, 0x82, 0x39, 0x25, 0x95, 0x05, 0x10, 0x75, 0x65, 0x89, 0x39, 0xA5, 0x20, 0x96, 0x91, 0x81, 0x41, 0xAD, 0x0E, 0x4C, 0xDC, 0x08, 0x2E, 0x6E, 0x89, 0x2C, 0x6C, 0x8C, 0x50, 0x6E, 0x0A, 0x14, 0x8F, 0xD5, 0x51, 0x4A, 0xCE, 0xC8, 0x4C, 0x4D, 0x73, 0xAD, 0x28, 0x00, 0x19, 0x60, 0xA6, 0xA3, 0x94, 0x97, 0x5A, 0xEE, 0x54, 0x9A, 0x99, 0x93, 0x92, 0x99, 0x97, 0xAE, 0x64, 0xA5, 0xF4, 0x6C, 0xEE, 0xBE, 0x67, 0x73, 0x56, 0x3C, 0x9D, 0x3D, 0x5B, 0xA9, 0x36, 0xB6, 0xB6, 0xB6, 0x16, 0x00, 0x01, 0xE7, 0x39, 0x53 };
            
            // byte[] expected = null; // TODO: 初始化为适当的值
            // Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");

            // byte[] arrDescrypt = ZlibCompress.DecompressBytes(arrOutput);
            string outputstr = System.Text.Encoding.UTF8.GetString(arrOutput);
            Console.WriteLine(outputstr);
        }
    }
}
