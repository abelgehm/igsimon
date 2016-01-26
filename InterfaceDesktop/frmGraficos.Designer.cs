﻿namespace InterfaceDesktop
{
    partial class frmGraficos
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
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chrGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd / MM / yyyy   HH : mm : ss";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(12, 23);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(161, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "dd / MM / yyyy   HH : mm : ss";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(179, 23);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(161, 20);
            this.dtpFim.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(508, 463);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 43);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fim";
            // 
            // chrGrafico
            // 
            this.chrGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chrGrafico.BackColor = System.Drawing.Color.Yellow;
            this.chrGrafico.Location = new System.Drawing.Point(12, 49);
            this.chrGrafico.Name = "chrGrafico";
            this.chrGrafico.Size = new System.Drawing.Size(802, 457);
            this.chrGrafico.TabIndex = 3;
            this.chrGrafico.Text = "chart1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(343, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(75, 39);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "Ações";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::InterfaceDesktop.Properties.Resources.Buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 36);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = global::InterfaceDesktop.Properties.Resources.Excel;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(36, 36);
            this.btnExcel.Text = "toolStripButton1";
            this.btnExcel.ToolTipText = "Exportar gráfico atual";
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 518);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chrGrafico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Name = "frmGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGrafico)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrGrafico;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnExcel;
    }
}