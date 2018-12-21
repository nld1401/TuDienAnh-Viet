using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace coverXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phải tạo file mySchema.XML rỗng trước 
            System.IO.FileStream myFileStream = new System.IO.FileStream("E:\\GitHub\\TuDienAnh-Viet\\TuDienAnh-Viet\\CoverSQL-to-XML\\data.xml", System.IO.FileMode.Create);
            System.Xml.XmlTextWriter MyXmlTextWriter = new System.Xml.XmlTextWriter
                                                       (myFileStream, System.Text.Encoding.Unicode);
            try
            {
                // 
                // ID: tên đăng nhập,  password: mật khẩu,  Initial Catalog: tên Database, Data Source: Sever Name
                SqlConnection con = new SqlConnection("User ID=sa;password=sa;Initial Catalog=AnhViet; Data Source =DESKTOP-56V3QUV");
                // lệnh sql 
                SqlDataAdapter daCust = new SqlDataAdapter("SELECT * FROM dbo.DictData", con);
                DataSet ds = new DataSet();
                daCust.Fill(ds, "DictData");
                ds.WriteXml(MyXmlTextWriter, XmlWriteMode.WriteSchema);
                // thành công
                Console.WriteLine("Save complete");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("faile ");
            }
            finally
            {
                MyXmlTextWriter.Close();
                myFileStream.Close();
            }
            Console.ReadKey();
        }
    }
}
