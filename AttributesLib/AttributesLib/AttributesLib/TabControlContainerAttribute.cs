using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesLib
{
    public class TabControlContainerAttribute : System.Attribute
    {
        public bool TabControlIsContainer {get;set;}

        public TabControlContainerAttribute(bool tabControlIsContainer)
        {
            TabControlIsContainer = tabControlIsContainer;
        }
    }
}
