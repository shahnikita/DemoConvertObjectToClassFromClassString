using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConvertObjectToClassFromClassString
{
    public class Path
    { 
       // This property defines type of the shape
        /// </summary>
       // [JsonProperty("se")]
        public string SvgElement { get; set; }

        /// <summary>
        /// this property defines svg root id 
        /// </summary>
       // [JsonProperty("sId")]
        public string SvgRootId { get; set; }
        /// <summary>
        /// A set of commands which define the path
        /// </summary>
       // [JsonProperty("d")]
        public string Data { get; set; }
        /// <summary>
        /// The path will be scaled so that the computed path length of the points equals this value
        /// </summary>
       // [JsonProperty("pl")]
        public int PathLength { get; set; }
        // <summary>
        /// The fill property defines the name of the color or color code to be filled for the element
        /// </summary>
       // [JsonProperty("fc")]
        public string FillColor { get; set; }
        /// <summary>
        /// This property defines the border color of the element
        /// </summary>
       // [JsonProperty("s")]
        public string Stroke { get; set; }

        /// <summary>
        /// The stroke-width property defines the thickness of a line, text or outline of an element
        /// </summary>
       // [JsonProperty("sw")]
        public string StrokeWidth { get; set; }

    }
}
