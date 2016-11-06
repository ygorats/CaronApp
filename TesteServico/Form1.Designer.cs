namespace TesteServico
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnCadastre = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdCaronas = new System.Windows.Forms.DataGridView();
            this.caronaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origemLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origemLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCaronas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caronaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.btnCadastre);
            this.tabPage1.Controls.Add(this.txtDestino);
            this.tabPage1.Controls.Add(this.txtOrigem);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(521, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(24, 37);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(100, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // btnCadastre
            // 
            this.btnCadastre.Location = new System.Drawing.Point(207, 184);
            this.btnCadastre.Name = "btnCadastre";
            this.btnCadastre.Size = new System.Drawing.Size(75, 23);
            this.btnCadastre.TabIndex = 3;
            this.btnCadastre.Text = "button1";
            this.btnCadastre.UseVisualStyleBackColor = true;
            this.btnCadastre.Click += new System.EventHandler(this.btnCadastre_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(24, 148);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 20);
            this.txtDestino.TabIndex = 2;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(24, 96);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(100, 20);
            this.txtOrigem.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdCaronas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(521, 241);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // grdCaronas
            // 
            this.grdCaronas.AutoGenerateColumns = false;
            this.grdCaronas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCaronas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.destinoLatitudeDataGridViewTextBoxColumn,
            this.destinoLongitudeDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.origemLatitudeDataGridViewTextBoxColumn,
            this.origemLongitudeDataGridViewTextBoxColumn});
            this.grdCaronas.DataSource = this.caronaBindingSource;
            this.grdCaronas.Location = new System.Drawing.Point(0, 0);
            this.grdCaronas.Name = "grdCaronas";
            this.grdCaronas.Size = new System.Drawing.Size(439, 235);
            this.grdCaronas.TabIndex = 0;
            this.grdCaronas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCaronas_CellContentClick);
            // 
            // caronaBindingSource
            // 
            this.caronaBindingSource.DataSource = typeof(TesteServico.ServiceReference1.Carona);
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // destinoLatitudeDataGridViewTextBoxColumn
            // 
            this.destinoLatitudeDataGridViewTextBoxColumn.DataPropertyName = "DestinoLatitude";
            this.destinoLatitudeDataGridViewTextBoxColumn.HeaderText = "DestinoLatitude";
            this.destinoLatitudeDataGridViewTextBoxColumn.Name = "destinoLatitudeDataGridViewTextBoxColumn";
            // 
            // destinoLongitudeDataGridViewTextBoxColumn
            // 
            this.destinoLongitudeDataGridViewTextBoxColumn.DataPropertyName = "DestinoLongitude";
            this.destinoLongitudeDataGridViewTextBoxColumn.HeaderText = "DestinoLongitude";
            this.destinoLongitudeDataGridViewTextBoxColumn.Name = "destinoLongitudeDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // origemLatitudeDataGridViewTextBoxColumn
            // 
            this.origemLatitudeDataGridViewTextBoxColumn.DataPropertyName = "OrigemLatitude";
            this.origemLatitudeDataGridViewTextBoxColumn.HeaderText = "OrigemLatitude";
            this.origemLatitudeDataGridViewTextBoxColumn.Name = "origemLatitudeDataGridViewTextBoxColumn";
            // 
            // origemLongitudeDataGridViewTextBoxColumn
            // 
            this.origemLongitudeDataGridViewTextBoxColumn.DataPropertyName = "OrigemLongitude";
            this.origemLongitudeDataGridViewTextBoxColumn.HeaderText = "OrigemLongitude";
            this.origemLongitudeDataGridViewTextBoxColumn.Name = "origemLongitudeDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 269);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCaronas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caronaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCadastre;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.DataGridView grdCaronas;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origemLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource caronaBindingSource;
    }
}

