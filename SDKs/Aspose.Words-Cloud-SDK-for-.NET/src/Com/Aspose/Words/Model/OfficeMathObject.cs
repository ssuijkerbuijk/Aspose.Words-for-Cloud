using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Com.Aspose.Words.Model 
{
  /// <summary>
  /// OfficeMath object.
  /// </summary>  
  public class OfficeMathObject 
  {                       
        /// <summary>
        /// Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text  or displayed on its own line.
        /// </summary>
        /// <value>Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text  or displayed on its own line.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisplayTypeEnum
        {
            
            /// <summary>
            /// Enum Display for "Display"
            /// </summary>            
            Display,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline
        }

        /// <summary>
        /// Gets/sets Office Math justification.
        /// </summary>
        /// <value>Gets/sets Office Math justification.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum JustificationEnum
        {
            
            /// <summary>
            /// Enum CenterGroup for "CenterGroup"
            /// </summary>            
            CenterGroup,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>            
            Center,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>            
            Left,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>            
            Right,
            
            /// <summary>
            /// Enum Inline for "Inline"
            /// </summary>            
            Inline,
            
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default
        }

        /// <summary>
        /// Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        /// <value>Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MathObjectTypeEnum
        {
            
            /// <summary>
            /// Enum OMath for "OMath"
            /// </summary>            
            OMath,
            
            /// <summary>
            /// Enum OMathPara for "OMathPara"
            /// </summary>            
            OMathPara,
            
            /// <summary>
            /// Enum Accent for "Accent"
            /// </summary>            
            Accent,
            
            /// <summary>
            /// Enum Bar for "Bar"
            /// </summary>            
            Bar,
            
            /// <summary>
            /// Enum BorderBox for "BorderBox"
            /// </summary>            
            BorderBox,
            
            /// <summary>
            /// Enum Box for "Box"
            /// </summary>            
            Box,
            
            /// <summary>
            /// Enum Delimiter for "Delimiter"
            /// </summary>            
            Delimiter,
            
            /// <summary>
            /// Enum Degree for "Degree"
            /// </summary>            
            Degree,
            
            /// <summary>
            /// Enum Argument for "Argument"
            /// </summary>            
            Argument,
            
            /// <summary>
            /// Enum Array for "Array"
            /// </summary>            
            Array,
            
            /// <summary>
            /// Enum Fraction for "Fraction"
            /// </summary>            
            Fraction,
            
            /// <summary>
            /// Enum Denominator for "Denominator"
            /// </summary>            
            Denominator,
            
            /// <summary>
            /// Enum Numerator for "Numerator"
            /// </summary>            
            Numerator,
            
            /// <summary>
            /// Enum Function for "Function"
            /// </summary>            
            Function,
            
            /// <summary>
            /// Enum FunctionName for "FunctionName"
            /// </summary>            
            FunctionName,
            
            /// <summary>
            /// Enum GroupCharacter for "GroupCharacter"
            /// </summary>            
            GroupCharacter,
            
            /// <summary>
            /// Enum Limit for "Limit"
            /// </summary>            
            Limit,
            
            /// <summary>
            /// Enum LowerLimit for "LowerLimit"
            /// </summary>            
            LowerLimit,
            
            /// <summary>
            /// Enum UpperLimit for "UpperLimit"
            /// </summary>            
            UpperLimit,
            
            /// <summary>
            /// Enum Matrix for "Matrix"
            /// </summary>            
            Matrix,
            
            /// <summary>
            /// Enum MatrixRow for "MatrixRow"
            /// </summary>            
            MatrixRow,
            
            /// <summary>
            /// Enum NAry for "NAry"
            /// </summary>            
            NAry,
            
            /// <summary>
            /// Enum Phantom for "Phantom"
            /// </summary>            
            Phantom,
            
            /// <summary>
            /// Enum Radical for "Radical"
            /// </summary>            
            Radical,
            
            /// <summary>
            /// Enum SubscriptPart for "SubscriptPart"
            /// </summary>            
            SubscriptPart,
            
            /// <summary>
            /// Enum SuperscriptPart for "SuperscriptPart"
            /// </summary>            
            SuperscriptPart,
            
            /// <summary>
            /// Enum PreSubSuperscript for "PreSubSuperscript"
            /// </summary>            
            PreSubSuperscript,
            
            /// <summary>
            /// Enum Subscript for "Subscript"
            /// </summary>            
            Subscript,
            
            /// <summary>
            /// Enum SubSuperscript for "SubSuperscript"
            /// </summary>            
            SubSuperscript,
            
            /// <summary>
            /// Enum Supercript for "Supercript"
            /// </summary>            
            Supercript
        }

        /// <summary>
        /// Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text  or displayed on its own line.
        /// </summary>
        /// <value>Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text  or displayed on its own line.</value>
        public DisplayTypeEnum? DisplayType { get; set; }

        /// <summary>
        /// Gets/sets Office Math justification.
        /// </summary>
        /// <value>Gets/sets Office Math justification.</value>
        public JustificationEnum? Justification { get; set; }

        /// <summary>
        /// Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.
        /// </summary>
        /// <value>Gets type Aspose.Words.Math.OfficeMath.MathObjectType of this Office Math object.</value>
        public MathObjectTypeEnum? MathObjectType { get; set; }

        /// <summary>
        /// Content of footnote.
        /// </summary>
        /// <value>Content of footnote.</value>    
        public StoryChildNodes Content { get; set; }

        /// <summary>
        /// Node id
        /// </summary>
        /// <value>Node id</value>    
        public string NodeId { get; set; }

        /// <summary>
        /// Link to the document.
        /// </summary>
        /// <value>Link to the document.</value>    
        public WordsApiLink Link { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class OfficeMathObject {\n");
          sb.Append("  Content: ").Append(Content).Append("\n");
          sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
          sb.Append("  Justification: ").Append(Justification).Append("\n");
          sb.Append("  MathObjectType: ").Append(MathObjectType).Append("\n");
          sb.Append("  NodeId: ").Append(NodeId).Append("\n");
          sb.Append("  Link: ").Append(Link).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
