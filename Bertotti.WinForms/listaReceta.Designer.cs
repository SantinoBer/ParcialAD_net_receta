namespace Bertotti.WinForms
{
    partial class listaReceta
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("Emitida");
            ListViewItem listViewItem2 = new ListViewItem("Dispensada");
            estadoListBox = new ListBox();
            filtrarBtn = new Button();
            listView1 = new ListView();
            recetaDataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniPacienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaEmisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cantidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            coberturaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recetaBindingSource = new BindingSource(components);
            agregarBtn = new Button();
            dispensarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)recetaDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recetaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // estadoListBox
            // 
            estadoListBox.FormattingEnabled = true;
            estadoListBox.ItemHeight = 15;
            estadoListBox.Items.AddRange(new object[] { "Emitida", "Dispensada", "Todos" });
            estadoListBox.Location = new Point(49, 39);
            estadoListBox.Name = "estadoListBox";
            estadoListBox.Size = new Size(120, 94);
            estadoListBox.TabIndex = 0;
            // 
            // filtrarBtn
            // 
            filtrarBtn.Location = new Point(247, 76);
            filtrarBtn.Name = "filtrarBtn";
            filtrarBtn.Size = new Size(75, 23);
            filtrarBtn.TabIndex = 1;
            filtrarBtn.Text = "Filtrar";
            filtrarBtn.UseVisualStyleBackColor = true;
            filtrarBtn.Click += filtrarBtn_Click;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listView1.Location = new Point(599, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(124, 97);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // recetaDataGrid
            // 
            recetaDataGrid.AutoGenerateColumns = false;
            recetaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recetaDataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dniPacienteDataGridViewTextBoxColumn, fechaEmisionDataGridViewTextBoxColumn, cantidadDataGridViewTextBoxColumn, coberturaDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            recetaDataGrid.DataSource = recetaBindingSource;
            recetaDataGrid.Location = new Point(49, 169);
            recetaDataGrid.Name = "recetaDataGrid";
            recetaDataGrid.Size = new Size(644, 153);
            recetaDataGrid.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dniPacienteDataGridViewTextBoxColumn
            // 
            dniPacienteDataGridViewTextBoxColumn.DataPropertyName = "DniPaciente";
            dniPacienteDataGridViewTextBoxColumn.HeaderText = "DniPaciente";
            dniPacienteDataGridViewTextBoxColumn.Name = "dniPacienteDataGridViewTextBoxColumn";
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // coberturaDataGridViewTextBoxColumn
            // 
            coberturaDataGridViewTextBoxColumn.DataPropertyName = "Cobertura";
            coberturaDataGridViewTextBoxColumn.HeaderText = "Cobertura";
            coberturaDataGridViewTextBoxColumn.Name = "coberturaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // recetaBindingSource
            // 
            recetaBindingSource.DataSource = typeof(Domain.Receta);
            // 
            // agregarBtn
            // 
            agregarBtn.Location = new Point(629, 342);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(75, 23);
            agregarBtn.TabIndex = 4;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = true;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // dispensarBtn
            // 
            dispensarBtn.Location = new Point(467, 140);
            dispensarBtn.Name = "dispensarBtn";
            dispensarBtn.Size = new Size(75, 23);
            dispensarBtn.TabIndex = 5;
            dispensarBtn.Text = "Dispensar";
            dispensarBtn.UseVisualStyleBackColor = true;
            dispensarBtn.Click += dispensarBtn_Click;
            // 
            // listaReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dispensarBtn);
            Controls.Add(agregarBtn);
            Controls.Add(recetaDataGrid);
            Controls.Add(listView1);
            Controls.Add(filtrarBtn);
            Controls.Add(estadoListBox);
            Name = "listaReceta";
            Text = "listaReceta";
            Load += listaReceta_Load;
            ((System.ComponentModel.ISupportInitialize)recetaDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)recetaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox estadoListBox;
        private Button filtrarBtn;
        private ListView listView1;
        private DataGridView recetaDataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniPacienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coberturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource recetaBindingSource;
        private Button agregarBtn;
        private Button dispensarBtn;
    }
}