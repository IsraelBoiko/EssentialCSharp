﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_40.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void MainTest_ArgsHasZeroElements_ThrowException()
        {
            Intellitect.ConsoleView.Tester.TestException(() => Program.ChapterMain(new string[] { }), typeof(ArgumentException));
        }

        [TestMethod]
        public void MainTest()
        {
            const string expected = @"Longest argument length = 10
Shortest argument length = 2";
            Intellitect.ConsoleView.Tester.Test(expected, () =>
                {
                    Program.ChapterMain(
                        new string[] {
                            "C#", "C++", "Java", "JavaScript", "COBOL" });
                });
        }
    }
}