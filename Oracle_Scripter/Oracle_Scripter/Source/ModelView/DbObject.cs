using Oracle_Scripter.Source.Extensions;

namespace Oracle_Scripter.Source.ModelView
{
    internal class DbObject
    {
        public string NAME { get; set; }

        public string TYPENAME { get; set; }

        public decimal LINENUMBER { get; set; }

        public override string ToString()
        {
            string s = " - ";

            string rs = s.Implode(new object[] { this.TYPENAME, this.NAME, this.LINENUMBER.ToStr() });

            return rs;
            //return base.ToString();
        }
    }
}