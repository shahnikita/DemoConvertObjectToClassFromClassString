using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoConvertObjectToClassFromClassString
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic shape =	new {
            //    SvgElement = 'path',
            //    SvgRootId = 'page1',
            //    Data = 'M145 224 L146 223 L148 221 L149 219 L152 217 ',
            //    FillColor = 'none',
            //    Stroke = 'black'
            //};
           var json="{   'sId': 'page1',  'd': 'M145 224 L146 223 L148 221 L149 219 L152 217 L159 213 L161 211 L166 209 L169 206 L175 203 L178 202 L183 200 L186 198 L188 197 L191 196 L195 194 L196 193 L199 192 L200 191 L201 190 L202 190 L203 190 L204 190 L205 190 L205 189 ',  'fc': 'none',  's': 'black'}";
            var jOBject=JsonConvert.DeserializeObject(json) as JObject;

            Type type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == "Path");
            var x = jOBject.ToObject(type);
        }
    }
}
