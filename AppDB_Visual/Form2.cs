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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            //Criação do primeiro nível da árvore (departamentos)
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var lista = from d in dc.Departamentos select d;
            foreach (var dep in lista)
                treeView1.Nodes.Add(dep.Sigla);

            //Criação do segundo nível da árvore (funcionários)
            var lista2 = from f in dc.Funcionarios orderby f.Nome select f;

            string depart;
            foreach (var func in lista2)
            {
                depart = func.Departamento;
                foreach (TreeNode noPrincipal in treeView1.Nodes)
                    if (noPrincipal.Text == depart)
                        noPrincipal.Nodes.Add(func.Nome);
            }
        }
    }
}
