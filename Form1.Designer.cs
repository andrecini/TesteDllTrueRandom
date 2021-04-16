
namespace TesteDllTrueRandom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSystemRandom = new System.Windows.Forms.RadioButton();
            this.rbTrueRandom = new System.Windows.Forms.RadioButton();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.btnSortear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinValue = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtQuantify = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtLinhas = new System.Windows.Forms.ToolStripMenuItem();
            this.txtColunas = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(102, 22);
            this.toolStripSplitButton1.Text = "Configurations";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtLinhas,
            this.txtColunas,
            this.pizzaToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblTotalTime);
            this.groupBox1.Controls.Add(this.lblx);
            this.groupBox1.Controls.Add(this.btnSortear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMinValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaxValue);
            this.groupBox1.Controls.Add(this.txtMinValue);
            this.groupBox1.Controls.Add(this.txtQuantify);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preenchimento de Dados";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSystemRandom);
            this.groupBox2.Controls.Add(this.rbTrueRandom);
            this.groupBox2.Location = new System.Drawing.Point(14, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 76);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Random";
            // 
            // rbSystemRandom
            // 
            this.rbSystemRandom.AutoSize = true;
            this.rbSystemRandom.Location = new System.Drawing.Point(27, 21);
            this.rbSystemRandom.Name = "rbSystemRandom";
            this.rbSystemRandom.Size = new System.Drawing.Size(102, 17);
            this.rbSystemRandom.TabIndex = 10;
            this.rbSystemRandom.Text = "System Random";
            this.rbSystemRandom.UseVisualStyleBackColor = true;
            // 
            // rbTrueRandom
            // 
            this.rbTrueRandom.AutoSize = true;
            this.rbTrueRandom.Checked = true;
            this.rbTrueRandom.Location = new System.Drawing.Point(27, 47);
            this.rbTrueRandom.Name = "rbTrueRandom";
            this.rbTrueRandom.Size = new System.Drawing.Size(90, 17);
            this.rbTrueRandom.TabIndex = 11;
            this.rbTrueRandom.TabStop = true;
            this.rbTrueRandom.Text = "True Random";
            this.rbTrueRandom.UseVisualStyleBackColor = true;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(90, 323);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(47, 13);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "xxxxxxxx";
            this.lblTotalTime.Visible = false;
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(14, 323);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(70, 13);
            this.lblx.TabIndex = 7;
            this.lblx.Text = "Tempo Total:";
            // 
            // btnSortear
            // 
            this.btnSortear.Location = new System.Drawing.Point(93, 264);
            this.btnSortear.Name = "btnSortear";
            this.btnSortear.Size = new System.Drawing.Size(75, 23);
            this.btnSortear.TabIndex = 6;
            this.btnSortear.Text = "Sortear";
            this.btnSortear.UseVisualStyleBackColor = true;
            this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Máximo:";
            // 
            // cbMinValue
            // 
            this.cbMinValue.AutoSize = true;
            this.cbMinValue.Location = new System.Drawing.Point(14, 70);
            this.cbMinValue.Name = "cbMinValue";
            this.cbMinValue.Size = new System.Drawing.Size(91, 17);
            this.cbMinValue.TabIndex = 4;
            this.cbMinValue.Text = "Valor Mínimo:";
            this.cbMinValue.UseVisualStyleBackColor = true;
            this.cbMinValue.CheckedChanged += new System.EventHandler(this.cbMinValue_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade:";
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(15, 134);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(155, 20);
            this.txtMaxValue.TabIndex = 2;
            this.txtMaxValue.Text = "1000";
            // 
            // txtMinValue
            // 
            this.txtMinValue.Enabled = false;
            this.txtMinValue.Location = new System.Drawing.Point(15, 89);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(155, 20);
            this.txtMinValue.TabIndex = 1;
            this.txtMinValue.Text = "100";
            // 
            // txtQuantify
            // 
            this.txtQuantify.Location = new System.Drawing.Point(15, 44);
            this.txtQuantify.Name = "txtQuantify";
            this.txtQuantify.Size = new System.Drawing.Size(155, 20);
            this.txtQuantify.TabIndex = 0;
            this.txtQuantify.Text = "1000";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grid";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(190, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 356);
            this.tabControl1.TabIndex = 2;
            // 
            // txtLinhas
            // 
            this.txtLinhas.Name = "txtLinhas";
            this.txtLinhas.Size = new System.Drawing.Size(180, 22);
            this.txtLinhas.Text = "Linhas";
            this.txtLinhas.Click += new System.EventHandler(this.linesToolStripMenuItem_Click);
            // 
            // txtColunas
            // 
            this.txtColunas.Name = "txtColunas";
            this.txtColunas.Size = new System.Drawing.Size(180, 22);
            this.txtColunas.Text = "Colunas";
            this.txtColunas.Click += new System.EventHandler(this.colunasToolStripMenuItem_Click);
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            this.pizzaToolStripMenuItem.Click += new System.EventHandler(this.PizzaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(631, 420);
            this.MinimumSize = new System.Drawing.Size(631, 420);
            this.Name = "Form1";
            this.Text = "Teste Dll True Random";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSortear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMinValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtQuantify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSystemRandom;
        private System.Windows.Forms.RadioButton rbTrueRandom;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem txtLinhas;
        private System.Windows.Forms.ToolStripMenuItem txtColunas;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
    }
}

