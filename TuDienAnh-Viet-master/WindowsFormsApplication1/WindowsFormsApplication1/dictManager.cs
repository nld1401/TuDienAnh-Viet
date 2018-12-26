using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public class DictManager
    {
        #region properties
        private string filePath = "data.xml";

        private DictItem items;

        public DictItem Items
        {
            get { return items; }
            set { items = value; }
        }
        #endregion

        #region methods
        public DictManager()
        {
            items = (DictItem)DeserializeFromXML(filePath);
        }

        public void LoadDataToCombobox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }


        public void Serialize()
        {
            
        }

        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictItem));

            SerializeToXML(Items, filePath);

            fs.Close();
        }

        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer sr = new XmlSerializer(typeof(DictItem));

            object obj = sr.Deserialize(fs);

            fs.Close();

            return obj;
        }

        #endregion
    }
}
