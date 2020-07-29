using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProgram
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cW_KDataSet.cClient". При необходимости она может быть перемещена или удалена.
            this.cClientTableAdapter.Fill(this.cW_KDataSet.cClient);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете видалити цю інформацію?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) cClientBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Focus();
                this.cClientTableAdapter.Update(this.cW_KDataSet.cClient);
                MessageBox.Show("Збереження пройшло успішно");
            }
            catch
            {
                MessageBox.Show("Помилка збереження. Перевірте коректність інформації та відношеннь таблиць ");
            }
        }

        DataView NewDataView;

        private void button6_Click_1(object sender, EventArgs e)
        {
            NewDataView = new
          DataView(cW_KDataSet.cClient);

            dataGridView1.DataSource = NewDataView;
            try
            {
                NewDataView.Sort = textBox10.Text;
            }
            catch
            {
                MessageBox.Show("Такої категорії не існує!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewDataView = new
          DataView(cW_KDataSet.cClient);

            dataGridView1.DataSource = NewDataView;
            try
            {
                NewDataView.RowFilter = textBox11.Text;
            }
            catch
            {
                MessageBox.Show("Такої категорії або ключа не існує!");
            }
        }
    }
}
