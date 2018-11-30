using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class dictItem
    {
        private List<DictData> item;

        public List<DictData> Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }
    }
}
