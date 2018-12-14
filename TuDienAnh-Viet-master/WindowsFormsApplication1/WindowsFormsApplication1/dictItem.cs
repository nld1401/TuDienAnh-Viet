using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    public class DictItem
    {
        private List<DictData> items;

        public List<DictData> Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }
    }
}
