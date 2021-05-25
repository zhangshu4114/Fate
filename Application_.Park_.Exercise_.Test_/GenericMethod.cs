using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_.Park_.Exercise_.Test_ {

    public class GenericMethod {
        public E ConvertType<E>(string s) where E:struct {
            E e = (E)Convert.ChangeType(s,typeof(E));
            return e;
        }
    }
}
