namespace GesSpot
{
    partial class Prog
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
            this.label1 = new System.Windows.Forms.Label();
            this.gesSpotDataSet = new GesSpot.GesSpotDataSet();
            this.buttonPropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPropertiesTableAdapter = new GesSpot.GesSpotDataSetTableAdapters.ButtonPropertiesTableAdapter();
            this.buttonPropertiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gesSpotDataSet1 = new GesSpot.GesSpotDataSet1();
            this.buttonPropertiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonPropertiesTableAdapter1 = new GesSpot.GesSpotDataSet1TableAdapters.ButtonPropertiesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.progHorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gesSpotDataSet2 = new GesSpot.GesSpotDataSet2();
            this.gesSpotDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progHorTableAdapter = new GesSpot.GesSpotDataSet2TableAdapters.ProgHorTableAdapter();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuncioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progHorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programar Anúncio";
            // 
            // gesSpotDataSet
            // 
            this.gesSpotDataSet.DataSetName = "GesSpotDataSet";
            this.gesSpotDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPropertiesBindingSource
            // 
            this.buttonPropertiesBindingSource.DataMember = "ButtonProperties";
            this.buttonPropertiesBindingSource.DataSource = this.gesSpotDataSet;
            // 
            // buttonPropertiesTableAdapter
            // 
            this.buttonPropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPropertiesBindingSource1
            // 
            this.buttonPropertiesBindingSource1.DataMember = "ButtonProperties";
            this.buttonPropertiesBindingSource1.DataSource = this.gesSpotDataSet;
            // 
            // gesSpotDataSet1
            // 
            this.gesSpotDataSet1.DataSetName = "GesSpotDataSet1";
            this.gesSpotDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPropertiesBindingSource2
            // 
            this.buttonPropertiesBindingSource2.DataMember = "ButtonProperties";
            this.buttonPropertiesBindingSource2.DataSource = this.gesSpotDataSet1;
            // 
            // buttonPropertiesTableAdapter1
            // 
            this.buttonPropertiesTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.buttonPropertiesBindingSource;
            this.comboBox1.DisplayMember = "buttonText";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anuncio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 22);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceitar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horarioDataGridViewTextBoxColumn,
            this.anuncioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.progHorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(386, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 309);
            this.dataGridView1.TabIndex = 6;
            // 
            // progHorBindingSource
            // 
            this.progHorBindingSource.DataMember = "ProgHor";
            this.progHorBindingSource.DataSource = this.gesSpotDataSet2;
            // 
            // gesSpotDataSet2
            // 
            this.gesSpotDataSet2.DataSetName = "GesSpotDataSet2";
            this.gesSpotDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gesSpotDataSetBindingSource
            // 
            this.gesSpotDataSetBindingSource.DataSource = this.gesSpotDataSet;
            this.gesSpotDataSetBindingSource.Position = 0;
            // 
            // progHorTableAdapter
            // 
            this.progHorTableAdapter.ClearBeforeFill = true;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horário";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            // 
            // anuncioDataGridViewTextBoxColumn
            // 
            this.anuncioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.anuncioDataGridViewTextBoxColumn.DataPropertyName = "Anuncio";
            this.anuncioDataGridViewTextBoxColumn.HeaderText = "Anuncio";
            this.anuncioDataGridViewTextBoxColumn.Name = "anuncioDataGridViewTextBoxColumn";
            this.anuncioDataGridViewTextBoxColumn.Width = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(380, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Programas";
            // 
            // Prog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(781, 454);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Prog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prog";
            this.Load += new System.EventHandler(this.Prog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPropertiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progHorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gesSpotDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GesSpotDataSet gesSpotDataSet;
        private System.Windows.Forms.BindingSource buttonPropertiesBindingSource;
        private GesSpotDataSetTableAdapters.ButtonPropertiesTableAdapter buttonPropertiesTableAdapter;
        private System.Windows.Forms.BindingSource buttonPropertiesBindingSource1;
        private GesSpotDataSet1 gesSpotDataSet1;
        private System.Windows.Forms.BindingSource buttonPropertiesBindingSource2;
        private GesSpotDataSet1TableAdapters.ButtonPropertiesTableAdapter buttonPropertiesTableAdapter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource gesSpotDataSetBindingSource;
        private GesSpotDataSet2 gesSpotDataSet2;
        private System.Windows.Forms.BindingSource progHorBindingSource;
        private GesSpotDataSet2TableAdapters.ProgHorTableAdapter progHorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anuncioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}