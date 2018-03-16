// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="NotesSlideShapesApiTests.cs">
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
    ///  Class for testing NotesSlideShapesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NotesSlideShapesApiTests
    {
        private NotesSlideShapesApi m_instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            m_instance = new NotesSlideShapesApi(TestUtils.Configuration);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
        }

        
        /// <summary>
        /// Test DeleteNotesSlideShape
        /// </summary>
        [Test]
        public void DeleteNotesSlideShape()
        {
            GeneralTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new GeneralTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidName()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "Name");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "SlideIndex");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidShapePath()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "ShapePath");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidShapes()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "Shapes");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidFolder()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "Folder");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        public void DeleteNotesSlideShapeInvalidStorage()
        {
            InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse> testExecutor =
                new InvalidPropertyTestExecutor<DeleteNotesSlideShapeRequest, ShapeListResponse>("DeleteNotesSlideShape", "Storage");
            DeleteNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            ShapeListResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.DeleteNotesSlideShape(request);
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
        /// Test GetNotesSlideShapeByPath
        /// </summary>
        [Test]
        public void GetNotesSlideShapeByPath()
        {
            GeneralTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new GeneralTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        public void GetNotesSlideShapeByPathInvalidName()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath", "Name");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        public void GetNotesSlideShapeByPathInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath", "SlideIndex");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        public void GetNotesSlideShapeByPathInvalidPath()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath", "Path");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        public void GetNotesSlideShapeByPathInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath", "Folder");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        public void GetNotesSlideShapeByPathInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeByPathRequest, SaaSposeResponse>("GetNotesSlideShapeByPath", "Storage");
            GetNotesSlideShapeByPathRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeByPath(request);
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
        /// Test GetNotesSlideShapeWithFormat
        /// </summary>
        [Test]
        public void GetNotesSlideShapeWithFormat()
        {
            GeneralTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new GeneralTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidName()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "Name");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "SlideIndex");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidShapeIndex()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "ShapeIndex");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidFormat()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "Format");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidFolder()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "Folder");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidStorage()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "Storage");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidScaleX()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "ScaleX");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidScaleY()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "ScaleY");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        public void GetNotesSlideShapeWithFormatInvalidBounds()
        {
            InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream> testExecutor =
                new InvalidPropertyTestExecutor<GetNotesSlideShapeWithFormatRequest, System.IO.Stream>("GetNotesSlideShapeWithFormat", "Bounds");
            GetNotesSlideShapeWithFormatRequest request = testExecutor.PrepareRequest();
            System.IO.Stream response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.GetNotesSlideShapeWithFormat(request);
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
        /// Test PostNotesSlideAddNewShape
        /// </summary>
        [Test]
        public void PostNotesSlideAddNewShape()
        {
            GeneralTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new GeneralTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidName()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "Name");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "SlideIndex");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidShapePath()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "ShapePath");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidShapeDto()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "ShapeDto");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidFolder()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "Folder");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidStorage()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "Storage");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        public void PostNotesSlideAddNewShapeInvalidShapeToClone()
        {
            InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PostNotesSlideAddNewShapeRequest, ShapeResponse>("PostNotesSlideAddNewShape", "ShapeToClone");
            PostNotesSlideAddNewShapeRequest request = testExecutor.PrepareRequest();
            ShapeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PostNotesSlideAddNewShape(request);
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
        /// Test PutUpdateNotesSlideShape
        /// </summary>
        [Test]
        public void PutUpdateNotesSlideShape()
        {
            GeneralTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new GeneralTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidName()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "Name");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidSlideIndex()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "SlideIndex");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidPath()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "Path");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidDto()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "Dto");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidFolder()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "Folder");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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
        public void PutUpdateNotesSlideShapeInvalidStorage()
        {
            InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse> testExecutor =
                new InvalidPropertyTestExecutor<PutUpdateNotesSlideShapeRequest, SaaSposeResponse>("PutUpdateNotesSlideShape", "Storage");
            PutUpdateNotesSlideShapeRequest request = testExecutor.PrepareRequest();
            SaaSposeResponse response = null;
            bool needAssertResponse = false;
            try
            {
                response = m_instance.PutUpdateNotesSlideShape(request);
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