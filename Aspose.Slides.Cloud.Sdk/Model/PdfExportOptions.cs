// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfExportOptions.cs">
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
  /// Provides options that control how a presentation is saved in Pdf format.
  /// </summary>  
  public class PdfExportOptions : ExportOptions 
  {                       
        /// <summary>
        /// Specifies compression type to be used for all textual content in the document.
        /// </summary>
        public PdfTextCompression TextCompression { get; set; }

        /// <summary>
        /// Determines if all characters of font should be embedded or only used subset.
        /// </summary>
        public bool? EmbedFullFonts { get; set; }

        /// <summary>
        /// Desired conformance level for generated PDF document.
        /// </summary>
        public PdfCompliance Compliance { get; set; }

        /// <summary>
        /// Returns or sets a value determining resolution of images inside PDF document. Property affects on file size, time of export and image quality.The default value is 96.
        /// </summary>
        public double? SufficientResolution { get; set; }

        /// <summary>
        /// Returns or sets a value determining the quality of the JPEG images inside PDF document.
        /// </summary>
        public int? JpegQuality { get; set; }

        /// <summary>
        /// True to draw black frame around each slide.
        /// </summary>
        public bool? DrawSlidesFrame { get; set; }

        /// <summary>
        /// Specifies whether the generated document should include hidden slides or not. Default is false. 
        /// </summary>
        public bool? ShowHiddenSlides { get; set; }

        /// <summary>
        /// True to convert all metafiles used in a presentation to the PNG images.
        /// </summary>
        public bool? SaveMetafilesAsPng { get; set; }

        /// <summary>
        /// Setting user password to protect the PDF document. 
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Determines if Aspose.Slides will embed common fonts for ASCII (33..127 code range) text. Fonts for character codes greater than 127 are always embedded. Common fonts list includes PDF's base 14 fonts and additional user specified fonts.
        /// </summary>
        public bool? EmbedTrueTypeFontsForASCII { get; set; }

        /// <summary>
        /// Returns or sets an array of user-defined names of font families which Aspose.Slides should consider common.
        /// </summary>
        public List<string> AdditionalCommonFontFamilies { get; set; }

        /// <summary>
        /// Gets or sets the position of the notes on the page.
        /// </summary>
        public NotesPositions NotesPosition { get; set; }

        /// <summary>
        /// Gets or sets the position of the comments on the page.
        /// </summary>
        public CommentsPositions CommentsPosition { get; set; }

        /// <summary>
        /// Gets or sets the width of the comment output area in pixels (Applies only if comments are displayed on the right).
        /// </summary>
        public int? CommentsAreaWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of comments area (Applies only if comments are displayed on the right).
        /// </summary>
        public string CommentsAreaColor { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PdfExportOptions {\n");
          sb.Append("  Format: ").Append(this.Format).Append("\n");
          sb.Append("  TextCompression: ").Append(this.TextCompression).Append("\n");
          sb.Append("  EmbedFullFonts: ").Append(this.EmbedFullFonts).Append("\n");
          sb.Append("  Compliance: ").Append(this.Compliance).Append("\n");
          sb.Append("  SufficientResolution: ").Append(this.SufficientResolution).Append("\n");
          sb.Append("  JpegQuality: ").Append(this.JpegQuality).Append("\n");
          sb.Append("  DrawSlidesFrame: ").Append(this.DrawSlidesFrame).Append("\n");
          sb.Append("  ShowHiddenSlides: ").Append(this.ShowHiddenSlides).Append("\n");
          sb.Append("  SaveMetafilesAsPng: ").Append(this.SaveMetafilesAsPng).Append("\n");
          sb.Append("  Password: ").Append(this.Password).Append("\n");
          sb.Append("  EmbedTrueTypeFontsForASCII: ").Append(this.EmbedTrueTypeFontsForASCII).Append("\n");
          sb.Append("  AdditionalCommonFontFamilies: ").Append(this.AdditionalCommonFontFamilies).Append("\n");
          sb.Append("  NotesPosition: ").Append(this.NotesPosition).Append("\n");
          sb.Append("  CommentsPosition: ").Append(this.CommentsPosition).Append("\n");
          sb.Append("  CommentsAreaWidth: ").Append(this.CommentsAreaWidth).Append("\n");
          sb.Append("  CommentsAreaColor: ").Append(this.CommentsAreaColor).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }

}
