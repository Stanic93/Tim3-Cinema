using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.AttributeClass
{
    [AttributeUsage(AttributeTargets.Property)]
    class SqlNameAttribute : Attribute
    {
        public string Naziv;
        public SqlNameAttribute(string naziv)
        {
            Naziv = naziv;
        }
    }
}
