using System;
using System.Linq;

namespace MyJsonLib
{
    public class ConverterToJson
    {
        public static string SerializeObj(object obj, Attribute atr = null)
        {
            string str = "";
            var strType = obj.GetType();
            var strr = strType.GetProperties();
            foreach (var st in strr)
            {
                var atrIgnore = st.GetCustomAttributes(false);
                if(atrIgnore.Any(x => x.GetType() == atr.GetType()))
                {
                    str += "";
                }
                else
                {
                    if (st.GetValue(obj) is string)
                    {
                        if (st != strr.LastOrDefault())
                        {
                            str += $"\"{st.Name}\":\"{st.GetValue(obj)}\",";
                        }
                        else
                        {
                            str += $"\"{st.Name}\":\"{st.GetValue(obj)}\"";
                        }
                    }
                    else
                    {
                        if (st != strr.LastOrDefault())
                        {
                            str += $"\"{st.Name}\":{st.GetValue(obj)},";
                        }
                        else
                        {
                            str += $"\"{st.Name}\":{st.GetValue(obj)}";
                        }
                    }
                }
            }
            return str = $"{{{str}}}";
        }
    }
}
