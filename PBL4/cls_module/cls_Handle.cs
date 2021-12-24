using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PBL4.cls_module
{
    class cls_Handle
    {
        public cls_Handle() { }
        public string FormatNumber(object numb)
        {
            string str = numb.ToString();
            string pattern = @"(?<a>\d*)(?<b>\d{3})*";
            Match m = Regex.Match(str, pattern, RegexOptions.RightToLeft);
            StringBuilder sb = new StringBuilder();
            foreach (Capture i in m.Groups["b"].Captures)
            {
                sb.Insert(0, "." + i.Value);
            }
            sb.Insert(0, m.Groups["a"].Value);
            return sb.ToString().Trim('.');
        }

        public string DeleteDotInNumber(string s)
        {
            string rs = s;
            int pos = 0;
            foreach (char c in s.ToArray())
            {
                if (c.Equals('.'))
                {
                    rs = rs.Remove(pos, 1);
                    pos--;
                }
                pos++;
            }
            return rs;
        }

        //check chuỗi lấy từ file có phải số hay không
        public bool IsNumeric(string s)
        {
            bool is_numeric = true;
            foreach (char c in s)
            {
                if (!char.IsDigit(c) || char.IsWhiteSpace(c))
                {
                    is_numeric = false;
                    break;
                }
            }
            return is_numeric;
        }

        public bool CheckEmpty(string port, string ip, string name)
        {
            if (port == "" || ip == "" || name == "")
            {
                return true;
            }
            else return false;
        }

    }

}
