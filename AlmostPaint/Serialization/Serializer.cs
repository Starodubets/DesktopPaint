using AlmostPaint.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostPaint.Serialization
{
    public class Serializer
    {
        public static string toJson(List<MFigure> list)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(list);
        }

        public static List<MFigure> fromJson(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MFigure>>(input);
        }
    }
}
