
namespace RegistroDeTransacciones.Formularios
{
    partial class FrmBalanceGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUtilidadNeta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUtilidadbruta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalMercancias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInventarioFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInventarioInicial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasivos = new System.Windows.Forms.TextBox();
            this.txtActivos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(35, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(332, 281);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txtUtilidadNeta);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtImpuesto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtUtilidadbruta);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtTotalMercancias);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtInventarioFinal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtInventarioInicial);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPasivos);
            this.panel1.Controls.Add(this.txtActivos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 576);
            this.panel1.TabIndex = 64;
            // 
            // txtUtilidadNeta
            // 
            this.txtUtilidadNeta.Enabled = false;
            this.txtUtilidadNeta.Location = new System.Drawing.Point(639, 533);
            this.txtUtilidadNeta.Name = "txtUtilidadNeta";
            this.txtUtilidadNeta.Size = new System.Drawing.Size(113, 20);
            this.txtUtilidadNeta.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(513, 535);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 80;
            this.label10.Text = "UTILIDAD NETA";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(639, 494);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(113, 20);
            this.txtImpuesto.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 494);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 78;
            this.label11.Text = "ISR (25%)";
            // 
            // txtUtilidadbruta
            // 
            this.txtUtilidadbruta.Enabled = false;
            this.txtUtilidadbruta.Location = new System.Drawing.Point(639, 465);
            this.txtUtilidadbruta.Name = "txtUtilidadbruta";
            this.txtUtilidadbruta.Size = new System.Drawing.Size(113, 20);
            this.txtUtilidadbruta.TabIndex = 77;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(425, 463);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 20);
            this.label12.TabIndex = 76;
            this.label12.Text = "Utilidad Antes Del Impuesto";
            // 
            // txtTotalMercancias
            // 
            this.txtTotalMercancias.Enabled = false;
            this.txtTotalMercancias.Location = new System.Drawing.Point(176, 536);
            this.txtTotalMercancias.Name = "txtTotalMercancias";
            this.txtTotalMercancias.Size = new System.Drawing.Size(113, 20);
            this.txtTotalMercancias.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 535);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "Total Mercancias";
            // 
            // txtInventarioFinal
            // 
            this.txtInventarioFinal.Location = new System.Drawing.Point(176, 493);
            this.txtInventarioFinal.Name = "txtInventarioFinal";
            this.txtInventarioFinal.Size = new System.Drawing.Size(113, 20);
            this.txtInventarioFinal.TabIndex = 73;
            this.txtInventarioFinal.Leave += new System.EventHandler(this.txtInventarioFinal_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 492);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Inventario Final";
            // 
            // txtInventarioInicial
            // 
            this.txtInventarioInicial.Location = new System.Drawing.Point(176, 463);
            this.txtInventarioInicial.Name = "txtInventarioInicial";
            this.txtInventarioInicial.Size = new System.Drawing.Size(113, 20);
            this.txtInventarioInicial.TabIndex = 71;
            this.txtInventarioInicial.Leave += new System.EventHandler(this.txtInventarioInicial_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 463);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "Inventario Inicial";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(22, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Vista Previa Estado De Resultados";
            // 
            // txtPasivos
            // 
            this.txtPasivos.Location = new System.Drawing.Point(669, 366);
            this.txtPasivos.Name = "txtPasivos";
            this.txtPasivos.Size = new System.Drawing.Size(113, 20);
            this.txtPasivos.TabIndex = 68;
            // 
            // txtActivos
            // 
            this.txtActivos.Location = new System.Drawing.Point(158, 369);
            this.txtActivos.Name = "txtActivos";
            this.txtActivos.Size = new System.Drawing.Size(113, 20);
            this.txtActivos.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Total Pasivos + Capital";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Total Activos";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Capital";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView3.Location = new System.Drawing.Point(518, 258);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(329, 108);
            this.dataGridView3.TabIndex = 63;
            this.dataGridView3.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Pasivos";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Location = new System.Drawing.Point(518, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(341, 149);
            this.dataGridView2.TabIndex = 61;
            this.dataGridView2.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Activos";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label36.Location = new System.Drawing.Point(22, 26);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(219, 18);
            this.label36.TabIndex = 57;
            this.label36.Text = "Vista Previa BalanceGeneral";
            // 
            // FrmBalanceGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 571);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBalanceGeneral";
            this.Text = "FrmBalanceGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasivos;
        private System.Windows.Forms.TextBox txtActivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalMercancias;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInventarioFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInventarioInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUtilidadNeta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUtilidadbruta;
        private System.Windows.Forms.Label label12;
    }
}