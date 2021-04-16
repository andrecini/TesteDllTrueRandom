using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presys.Random;

namespace TesteDllTrueRandom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static TrueRandom rdm = new TrueRandom();

        private void btnSortear_Click(object sender, EventArgs e)
        {

            try
            {
                BindingSource bsG = new BindingSource();
                bsG.DataSource = ReturnDataTable(listTreatment(SortNumbers()));
                dataGridView1.DataSource = bsG;

                chart1.DataSource = dataGridView1.DataSource;

                SetSeries();

                chart1.DataBind();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }     
           
        }

        private int[] GetData(int quantify, int min, int max)
        {
            int[] output = new int[3];

            output[0] = quantify;
            output[1] = min;
            output[2] = max;

            return output;
        }

        private int[] GetData(int quantify, int max)
        {
            int[] output = new int[2];

            output[0] = quantify;
            output[1] = max;

            return output;
        }

        private List<long> SortNumbers()
        {
            if (cbMinValue.Checked)
            {
                int[] data = GetData(int.Parse(txtQuantify.Text), int.Parse(txtMinValue.Text), int.Parse(txtMaxValue.Text));
                
                return rdm.SetInteger((uint)data[0], data[1], data[2]).ToList();
            }
            else
            {
                int[] data = GetData(int.Parse(txtQuantify.Text), int.Parse(txtMaxValue.Text));

                return rdm.SetInteger((uint)data[0], 0, data[1]).ToList();
            }

        }

        private List<long> listTreatment(List<long> list)
        {
            long[] vector = new long[long.Parse(txtMaxValue.Text) + 1];

            VectorTreatment(ref vector);

            foreach (var item in list)
            {
                vector[item]++;
            }

            return vector.ToList();
        }

        private void VectorTreatment(ref long[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = 0;
            }
        }

        private DataTable ReturnDataTable(List<long> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Número");
            dt.Columns.Add("Repetições");

            SetDataTable(ref dt, list);

            return dt;
        }

        private void SetDataTable(ref DataTable dados, List<long> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                dados.Rows.Add(i.ToString(), list[i]);
            }
        }

        private void cbMinValue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMinValue.Checked)
                txtMinValue.Enabled = true;
            else
                txtMinValue.Enabled = true;
        }

        private void SetSeries()
        {
            chart1.Series[0].LegendText = "Números Gerados";
            chart1.Series[0].XValueMember = "Número";
            chart1.Series[0].YValueMembers = "Repetições";
        }
    }
}
