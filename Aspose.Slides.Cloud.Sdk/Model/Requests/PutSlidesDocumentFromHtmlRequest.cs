
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutSlidesDocumentFromHtmlRequest.cs">
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

using System.Collections.Generic;
using System.IO;
using Aspose.Slides.Cloud.Sdk.Model;

namespace Aspose.Slides.Cloud.Sdk.Model.Requests 
{
  /// <summary>
  /// Request model for <see cref="Aspose.Slides.Cloud.Sdk.Api.DocumentApi.PutSlidesDocumentFromHtml" /> operation.
  /// </summary>  
  public class PutSlidesDocumentFromHtmlRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesDocumentFromHtmlRequest"/> class.
        /// </summary>        
        public PutSlidesDocumentFromHtmlRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutSlidesDocumentFromHtmlRequest"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="html"></param>
        /// <param name="password"></param>
        /// <param name="storage"></param>
        /// <param name="folder"></param>
        public PutSlidesDocumentFromHtmlRequest(string name, string html, string password = null, string storage = null, string folder = null)
        {
            this.Name = name;
            this.Html = html;
            this.Password = password;
            this.Storage = storage;
            this.Folder = folder;
        }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Html
        /// </summary>  
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>  
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Storage
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Gets or sets Folder
        /// </summary>  
        public string Folder { get; set; }
  }
}