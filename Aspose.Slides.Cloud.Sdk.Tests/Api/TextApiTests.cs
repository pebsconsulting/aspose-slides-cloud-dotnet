// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextApiTests.cs">
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
    ///  Class for testing TextApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TextApiTests
    {
        private TextApi m_instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            m_instance = new TextApi(TestUtils.Configuration);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        
        /// <summary>
        /// Test GetSlidesPresentationTextItems
        /// </summary>
        [Test]
        public void GetSlidesPresentationTextItems()
        {
            GeneralTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse> testExecutor =
                new GeneralTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse>("GetSlidesPresentationTextItems");
            GetSlidesPresentationTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPresentationTextItems(request);
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
        public void GetSlidesPresentationTextItemsInvalidName()
        {
            InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse>("GetSlidesPresentationTextItems", "Name");
            GetSlidesPresentationTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPresentationTextItems(request);
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
        public void GetSlidesPresentationTextItemsInvalidWithEmpty()
        {
            InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse>("GetSlidesPresentationTextItems", "WithEmpty");
            GetSlidesPresentationTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPresentationTextItems(request);
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
        public void GetSlidesPresentationTextItemsInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse>("GetSlidesPresentationTextItems", "Folder");
            GetSlidesPresentationTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPresentationTextItems(request);
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
        public void GetSlidesPresentationTextItemsInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesPresentationTextItemsRequest, TextItemsResponse>("GetSlidesPresentationTextItems", "Storage");
            GetSlidesPresentationTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesPresentationTextItems(request);
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
        /// Test GetSlidesSlideTextItems
        /// </summary>
        [Test]
        public void GetSlidesSlideTextItems()
        {
            GeneralTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new GeneralTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        public void GetSlidesSlideTextItemsInvalidName()
        {
            InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems", "Name");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        public void GetSlidesSlideTextItemsInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems", "SlideIndex");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        public void GetSlidesSlideTextItemsInvalidWithEmpty()
        {
            InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems", "WithEmpty");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        public void GetSlidesSlideTextItemsInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems", "Folder");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        public void GetSlidesSlideTextItemsInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetSlidesSlideTextItemsRequest, TextItemsResponse>("GetSlidesSlideTextItems", "Storage");
            GetSlidesSlideTextItemsRequest request = testExecutor.PrepareRequest();
            TextItemsResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetSlidesSlideTextItems(request);
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
        /// Test PostSlidesPresentationReplaceText
        /// </summary>
        [Test]
        public void PostSlidesPresentationReplaceText()
        {
            GeneralTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new GeneralTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidName()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "Name");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidOldValue()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "OldValue");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidNewValue()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "NewValue");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidIgnoreCase()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "IgnoreCase");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidFolder()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "Folder");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        public void PostSlidesPresentationReplaceTextInvalidStorage()
        {
            InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesPresentationReplaceTextRequest, PresentationStringReplaceResponse>("PostSlidesPresentationReplaceText", "Storage");
            PostSlidesPresentationReplaceTextRequest request = testExecutor.PrepareRequest();
            PresentationStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesPresentationReplaceText(request);
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
        /// Test PostSlidesSlideReplaceText
        /// </summary>
        [Test]
        public void PostSlidesSlideReplaceText()
        {
            GeneralTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new GeneralTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidName()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "Name");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "SlideIndex");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidOldValue()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "OldValue");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidNewValue()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "NewValue");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidIgnoreCase()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "IgnoreCase");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidFolder()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "Folder");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
        public void PostSlidesSlideReplaceTextInvalidStorage()
        {
            InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostSlidesSlideReplaceTextRequest, SlideStringReplaceResponse>("PostSlidesSlideReplaceText", "Storage");
            PostSlidesSlideReplaceTextRequest request = testExecutor.PrepareRequest();
            SlideStringReplaceResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostSlidesSlideReplaceText(request);
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
