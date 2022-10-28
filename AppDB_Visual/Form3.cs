using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDB_Visual
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            //Criação de colunas no controlo DataGridView
            dataGridView1.Columns.Add("colId", "ID");
            dataGridView1.Columns.Add("colNome", "Nome");
            dataGridView1.Columns.Add("colDepartamento", "Departamento");

            //Carregar os dados
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var lista = from f in dc.Funcionarios select f;

            int nlinha = 0;
            DataGridViewCellStyle vermelho = new DataGridViewCellStyle();
            vermelho.ForeColor = Color.Red;

            foreach (var func in lista)
            {
                DataGridViewRow linha = new DataGridViewRow();
                dataGridView1.Rows.Add(linha);
                dataGridView1.Rows[nlinha].Cells[0].Value = func.ID;
                dataGridView1.Rows[nlinha].Cells[1].Value = func.Nome;
                dataGridView1.Rows[nlinha].Cells[2].Value = func.Departamento;

                if ((string)dataGridView1.Rows[nlinha].Cells[2].Value == "DC")
                    dataGridView1.Rows[nlinha].DefaultCellStyle = vermelho;

                nlinha++;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
