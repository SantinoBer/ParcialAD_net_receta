namespace Bertotti.WinForms
{
    partial class agregarReceta
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
            dniTxt = new TextBox();
            FechaEmisionDateTimePicker = new DateTimePicker();
            cantidadNumericUpDown = new NumericUpDown();
            CoberturaListBox = new ListBox();
            agregarBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)cantidadNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // dniTxt
            // 
            dniTxt.Location = new Point(78, 74);
            dniTxt.Name = "dniTxt";
            dniTxt.PlaceholderText = "Dni";
            dniTxt.Size = new Size(164, 23);
            dniTxt.TabIndex = 0;
            // 
            // FechaEmisionDateTimePicker
            // 
            FechaEmisionDateTimePicker.Format = DateTimePickerFormat.Short;
            FechaEmisionDateTimePicker.Location = new Point(259, 74);
            FechaEmisionDateTimePicker.Name = "FechaEmisionDateTimePicker";
            FechaEmisionDateTimePicker.Size = new Size(200, 23);
            FechaEmisionDateTimePicker.TabIndex = 1;
            // 
            // cantidadNumericUpDown
            // 
            cantidadNumericUpDown.Location = new Point(339, 115);
            cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            cantidadNumericUpDown.Size = new Size(120, 23);
            cantidadNumericUpDown.TabIndex = 2;
            // 
            // CoberturaListBox
            // 
            CoberturaListBox.FormattingEnabled = true;
            CoberturaListBox.ItemHeight = 15;
            CoberturaListBox.Items.AddRange(new object[] { "Obra Social", "Prepaga", "Particular" });
            CoberturaListBox.Location = new Point(78, 115);
            CoberturaListBox.Name = "CoberturaListBox";
            CoberturaListBox.Size = new Size(164, 64);
            CoberturaListBox.TabIndex = 3;
            // 
            // agregarBtn
            // 
            agregarBtn.Location = new Point(384, 191);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(75, 23);
            agregarBtn.TabIndex = 4;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = true;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // agregarReceta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarBtn);
            Controls.Add(CoberturaListBox);
            Controls.Add(cantidadNumericUpDown);
            Controls.Add(FechaEmisionDateTimePicker);
            Controls.Add(dniTxt);
            Name = "agregarReceta";
            Text = "agregarReceta";
            ((System.ComponentModel.ISupportInitialize)cantidadNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dniTxt;
        private DateTimePicker FechaEmisionDateTimePicker;
        private NumericUpDown cantidadNumericUpDown;
        private ListBox CoberturaListBox;
        private Button agregarBtn;
    }
}