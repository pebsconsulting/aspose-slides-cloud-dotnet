// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TextVerticalType.cs">
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
    /// Vertical text writing mode
    /// </summary>
    /// <value>Vertical text writing mode</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextVerticalType
    {
        
        /// <summary>
        /// Enum Horizontal for "Horizontal"
        /// </summary>
        Horizontal,
        
        /// <summary>
        /// Enum Vertical for "Vertical"
        /// </summary>
        Vertical,
        
        /// <summary>
        /// Enum Vertical270 for "Vertical270"
        /// </summary>
        Vertical270,
        
        /// <summary>
        /// Enum WordArtVertical for "WordArtVertical"
        /// </summary>
        WordArtVertical,
        
        /// <summary>
        /// Enum EastAsianVertical for "EastAsianVertical"
        /// </summary>
        EastAsianVertical,
        
        /// <summary>
        /// Enum MongolianVertical for "MongolianVertical"
        /// </summary>
        MongolianVertical,
        
        /// <summary>
        /// Enum WordArtVerticalRightToLeft for "WordArtVerticalRightToLeft"
        /// </summary>
        WordArtVerticalRightToLeft,
        
        /// <summary>
        /// Enum NotDefined for "NotDefined"
        /// </summary>
        NotDefined
    }

}
