﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new DataStructureValidation.XMLValidate();
            var r = sut.XMLValidation("<?xml version='1.0'?><bookstore xmlns=\"urn: bookstore - schema\">  <book>    <author>      <first-name>Benjamin</first-name>      <last-name>Franklin</last-name>    </author>  </book>  <book genre=\"novel\">    <title>The Confidence Man</title>    <author>      <first-name>Herman</first-name>      <last-name>Melville</last-name>    </author>    <price>11.99</price>  </book>  <book genre=\"philosophy\">    <title>The Gorgias</title>    <author>      <name>Plato</name>    </author>    <price>9.99</price>  </book></bookstore>");
            var stop = 0;
        }
    }
}
