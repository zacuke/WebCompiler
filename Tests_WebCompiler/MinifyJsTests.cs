﻿using NUnit.Framework;
using System.Collections.Generic;
using WebCompiler.Compile;
using WebCompiler.Configuration.Settings;

namespace Tests_WebCompiler
{
    public class MinifyJsTests : TestsBase
    {
        [SetUp]
        public void CreatePipeline()
        {
            pipeline = (file) => new CompilationStep(file).With(new JavascriptMinifier(new JavaScriptMinifySettings { TermSemicolons = false }));
            input = "../../../TestCases/Js/test.js";
            output_files = new List<string> { "../../../TestCases/Js/test.min.js" };
            expected_output = "../../../TestCases/Js/test.min.js";
            DeleteTemporaryFiles();
        }
        [Test]
        public void CallTest() => Test();
    }
}