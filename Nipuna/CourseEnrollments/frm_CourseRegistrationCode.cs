using Nipuna.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace Nipuna.CourseEnrollments
{
    public partial class frm_CourseRegistrationCode : Form
    {
        public string Barcode;

        public frm_CourseRegistrationCode()
        {
            InitializeComponent();
        }

        public frm_CourseRegistrationCode(string barcode)
        {
            InitializeComponent();
            Barcode = barcode;
        }

        public frm_CourseRegistrationCode(RegistrationIds registration)
        {
            InitializeComponent();
            
        }

        private void frm_CourseRegistrationCode_Load(object sender, EventArgs e)
        {

            // create barcode
            var writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128,
                
                Options = new EncodingOptions 
                {
                    Height = 50,
                    Width = 200
                }
                

            };
            pic_Barcode.Image = writer.Write(Barcode);
           
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            // print barcode
            var print = new PrintDialog();
            var doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            print.Document = doc;
            if (print.ShowDialog() == DialogResult.OK)
                doc.Print();

            this.Close();
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pic_Barcode.Width, pic_Barcode.Height);
            pic_Barcode.DrawToBitmap(bm,new Rectangle(0,0, pic_Barcode.Width, pic_Barcode.Height));
            e.Graphics.DrawImage(bm, 0, 30);
            bm.Dispose();
        }
    }
}
