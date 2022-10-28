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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Variáveis globais
        string colunaOrdenada = "ID"; //predefinição
        string tipoOrd = "ASC"; //predefinição

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            listView1.AllowColumnReorder = true; //Permite a reordenação de colunas

            //Criação de colunas no controlo ListView
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Departamento");

            DataClasses1DataContext dc = new DataClasses1DataContext();

            var lista = from f in dc.Funcionarios select f;

            foreach (var func in lista)
            {
                ListViewItem item;
                item = listView1.Items.Add(func.ID.ToString());
                item.SubItems.Add(func.Nome);
                item.SubItems.Add(func.Departamento);
            }

            //Ajuste automático das larguras das colunas em função do cabeçalho
            for (int i = 0; i < 3; i++)
                listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int idColuna = e.Column;
            string coluna = listView1.Columns[idColuna].Text;
            string ord;

            if (coluna == colunaOrdenada)
            {
                if (tipoOrd == "ASC")
                    ord = "DESC";
                else
                    ord = "ASC";
            }
            else
                ord = "ASC";

            Ordenar(coluna, ord);
        }

        void Ordenar(string coluna, string ord)
        {
            //Limpar a listView
            listView1.Items.Clear();

            DataClasses1DataContext dc = new DataClasses1DataContext();

            var lista = from f in dc.Funcionarios select f;

            switch (coluna)
            {
                case "ID":
                    if (ord == "ASC")
                        lista = from f in dc.Funcionarios orderby f.ID ascending select f;
                    else
                        lista = from f in dc.Funcionarios orderby f.ID descending select f;
                    break;

                case "Nome":
                    if (ord == "ASC")
                        lista = from f in dc.Funcionarios orderby f.Nome ascending select f;
                    else
                        lista = from f in dc.Funcionarios orderby f.Nome descending select f;
                    break;

                case "Departamento":
                    if (ord == "ASC")
                        lista = from f in dc.Funcionarios orderby f.Departamento ascending select f;
                    else
                        lista = from f in dc.Funcionarios orderby f.Departamento descending select f;
                    break;
            }

            foreach (var func in lista)
            {
                ListViewItem item;
                item = listView1.Items.Add(func.ID.ToString());
                item.SubItems.Add(func.Nome);
                item.SubItems.Add(func.Departamento);
            }

            //Ajuste automático das larguras das colunas em função do cabeçalho
            for (int i = 0; i < 3; i++)
                listView1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);

            colunaOrdenada = coluna; //atualizar a variável global
            tipoOrd = ord;//atualizar a variável global
        }
    }
}
