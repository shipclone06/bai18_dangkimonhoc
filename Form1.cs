using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai18_dangkimonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã Số Sinh Viên: " + txtmssv.Text;
            thongtin += "\nHọ Và Tên: " + txthoten.Text;
            thongtin += "\nNiên Khóa: " + cbonienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbolop.SelectedItem;
            string hocky = "";
            if (rd1.Checked)
            {
                hocky =rd1.Text;
            }
            if (rd2.Checked)
            {
                hocky = rd2.Text;
            }
            if (rd3.Checked)
            {
                hocky = rd3.Text;
            }
            if (rd4.Checked)
            {
                hocky = rd4.Text;
            }
            thongtin += "\nĐã Đăng Ký Học Kỳ: " + hocky + "\ncác môn học: ";
            //lấy giá trị từ CheckListBox
            int stt = 1;
            foreach (var item in clsbmonhoc.CheckedItems)
            {
                //messagebox.show(item.toString());
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, " thông tin sinh viên");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtmssv.Clear();
            txthoten.Clear();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbonienkhoa.Items.Add("2007");
            cbonienkhoa.Items.Add("2008");
            cbonienkhoa.Items.Add("2009");
            cbonienkhoa.Items.Add("2010");
            cbonienkhoa.Items.Add("2011");
            cbonienkhoa.Items.Add("2012");
            cbonienkhoa.Items.Add("2013");
            cbonienkhoa.Items.Add("2014");
            cbonienkhoa.Items.Add("2015");
            cbonienkhoa.Items.Add("2016");
            cbonienkhoa.Items.Add("2017");

            cbolop.Items.Add("CD18A");
            cbolop.Items.Add("CD19A");
            cbolop.Items.Add("CD20A");
            cbolop.Items.Add("CD21A");
            cbolop.Items.Add("CD22A");
            cbolop.Items.Add("CD23A");
            cbolop.Items.Add("CD24A");
            cbolop.Items.Add("CD25A");
            cbolop.Items.Add("CD26A");
            cbolop.Items.Add("CD27A");
            cbolop.Items.Add("CD28A");
            cbolop.SelectedIndex = 0;

            rd1.Checked = true;

            clsbmonhoc.Items.Add("LT WIN", CheckState.Checked);
            clsbmonhoc.Items.Add("LT Internet", CheckState.Unchecked);
            clsbmonhoc.Items.Add("Mạng Máy Tính", CheckState.Unchecked);
            clsbmonhoc.Items.Add("UML", CheckState.Checked);
        }

        private void cbonienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
