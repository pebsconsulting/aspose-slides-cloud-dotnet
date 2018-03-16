// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PlaceholdersApiTests.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using Aspose.Slides.Cloud.Sdk.Model;
using Aspose.Slides.Cloud.Sdk.Model.Requests;

using Aspose.Slides.Cloud.Sdk.Tests.Utils;

namespace Aspose.Slides.Cloud.Sdk.Tests
{
    /// <summary>
    ///  Class for testing PlaceholdersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlaceholdersApiTests
    {
        private PlaceholdersApi m_instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            m_instance = new PlaceholdersApi(TestUtils.Configuration);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        
        /// <summary>
        /// Test GetSlidesPlaceholder
        /// </summary>
        [Test]
        public void GetSlidesPlaceholder()
        {
            GeneralTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new GeneralTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetSlidesPlaceholderInvalidName()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder", "Name");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholderInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder", "SlideIndex");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholderInvalidPlaceholderIndex()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder", "PlaceholderIndex");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholderInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder", "Folder");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholderInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholderRequest, PlaceholderResponse>("GetSlidesPlaceholder", "Storage");
            GetSlidesPlaceholderRequest request = testExecutor.PrepareRequest();
            PlaceholderResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholder(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
        /// <summary>
        /// Test GetSlidesPlaceholders
        /// </summary>
        [Test]
        public void GetSlidesPlaceholders()
        {
            GeneralTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse> testExecutor =
                new GeneralTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse>("GetSlidesPlaceholders");
            GetSlidesPlaceholdersRequest request = testExecutor.PrepareRequest();
            PlaceholdersResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholders(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        [Test]
        public void GetSlidesPlaceholdersInvalidName()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse>("GetSlidesPlaceholders", "Name");
            GetSlidesPlaceholdersRequest request = testExecutor.PrepareRequest();
            PlaceholdersResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholders(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholdersInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse>("GetSlidesPlaceholders", "SlideIndex");
            GetSlidesPlaceholdersRequest request = testExecutor.PrepareRequest();
            PlaceholdersResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholders(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholdersInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse>("GetSlidesPlaceholders", "Folder");
            GetSlidesPlaceholdersRequest request = testExecutor.PrepareRequest();
            PlaceholdersResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholders(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }
        [Test]
        public void GetSlidesPlaceholdersInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPlaceholdersRequest, PlaceholdersResponse>("GetSlidesPlaceholders", "Storage");
            GetSlidesPlaceholdersRequest request = testExecutor.PrepareRequest();
            PlaceholdersResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPlaceholders(request);
                needAssertResponse = true;
            }
            catch (Exception ex)
            {
                testExecutor.AssertException(ex);
            }
            if (needAssertResponse)
            {
                testExecutor.AssertResult(response);
            }
        }

        
    }
}
