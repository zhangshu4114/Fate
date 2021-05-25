using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_.Park_.Exercise_.Console_ {

    [AttributeUsage(AttributeTargets.Class)]
    public class RemarkAttribute:Attribute {
        public string Remark{ get; set; }
    }
}
