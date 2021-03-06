// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PictureFill.cs">
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
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
  /// <summary>
  /// 
  /// </summary>  
  public class PictureFill : FillFormat 
  {                       
        /// <summary>
        /// Gets or sets CropBottom
        /// </summary>
        public double? CropBottom { get; set; }

        /// <summary>
        /// Gets or sets CropLeft
        /// </summary>
        public double? CropLeft { get; set; }

        /// <summary>
        /// Gets or sets CropRight
        /// </summary>
        public double? CropRight { get; set; }

        /// <summary>
        /// Gets or sets CropTop
        /// </summary>
        public double? CropTop { get; set; }

        /// <summary>
        /// Gets or sets Dpi
        /// </summary>
        public int? Dpi { get; set; }

        /// <summary>
        /// Gets or sets Image
        /// </summary>
        public ResourceUriElement Image { get; set; }

        /// <summary>
        /// Gets or sets Base64Data
        /// </summary>
        public string Base64Data { get; set; }

        /// <summary>
        /// Gets or sets SvgData
        /// </summary>
        public string SvgData { get; set; }

        /// <summary>
        /// Gets or sets PictureFillMode
        /// </summary>
        public PictureFillMode PictureFillMode { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PictureFill {\n");
          sb.Append("  Type: ").Append(this.Type).Append("\n");
          sb.Append("  CropBottom: ").Append(this.CropBottom).Append("\n");
          sb.Append("  CropLeft: ").Append(this.CropLeft).Append("\n");
          sb.Append("  CropRight: ").Append(this.CropRight).Append("\n");
          sb.Append("  CropTop: ").Append(this.CropTop).Append("\n");
          sb.Append("  Dpi: ").Append(this.Dpi).Append("\n");
          sb.Append("  Image: ").Append(this.Image).Append("\n");
          sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
          sb.Append("  SvgData: ").Append(this.SvgData).Append("\n");
          sb.Append("  PictureFillMode: ").Append(this.PictureFillMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
