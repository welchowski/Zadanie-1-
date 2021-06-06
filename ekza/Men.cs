using System;
using System.Collections.Generic;
using System.Text;

namespace ekza
{
    class Men:TMan
    {
        TMan[] data;
        public Men()
        {
            data = new TMan[10];
            
        }
        // индексатор
        public TMan this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
