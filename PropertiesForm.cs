using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pic.Plugin;
using Pic.Plugin.ViewCtrl;

namespace Interface_Nicolas
{
    public partial class PropertiesForm : Form
    {
        PluginViewCtrl _pluginViewCtrl;
        public PropertiesForm(PluginViewCtrl pluginViewCtrl)
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.ReadOnly = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle =
            new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Propriété";
            dataGridView1.Columns[1].Name = "Valeur";


            _pluginViewCtrl = pluginViewCtrl;
            propertiesListView();
            
        }

        private void propertiesListView()
        {

            //Dictionary<string, Parameter> dict = new Dictionary<string, Parameter>();
            

            foreach (Parameter param in _pluginViewCtrl.CurrentParameterStack)
            {
               if(param is ParameterBool)
                {
                    dataGridView1.Rows.Add(param.Name, _pluginViewCtrl.CurrentParameterStack.GetBoolParameterValue(param.Name));
                }
               else if(param is ParameterDouble)
                {
                    dataGridView1.Rows.Add(param.Name, _pluginViewCtrl.CurrentParameterStack.GetDoubleParameterValue(param.Name));
                }
               else if(param is ParameterInt)
                {
                    dataGridView1.Rows.Add(param.Name, _pluginViewCtrl.CurrentParameterStack.GetIntParameterValue(param.Name));
                }
               else if(param is ParameterMulti)
                {
                    dataGridView1.Rows.Add(param.Name, _pluginViewCtrl.CurrentParameterStack.GetMultiParameterValue(param.Name));
                }                    
            }
        }        
    }
}
