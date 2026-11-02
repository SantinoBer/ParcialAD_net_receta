using Bertotti.Domain;
using Perez.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bertotti.WinForms
{
    public partial class agregarReceta : Form
    {
        private readonly RecetaApiClient api = new RecetaApiClient();
        public agregarReceta()
        {
            InitializeComponent();
        }

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            var receta = new Receta
            {
                DniPaciente = dniTxt.Text.Trim(),
                FechaEmision = DateOnly.FromDateTime(FechaEmisionDateTimePicker.Value),
                Cantidad = (int)cantidadNumericUpDown.Value,
                Cobertura = CoberturaListBox.SelectedItem?.ToString()
            };

            try
            {
                await api.CreateAsync(receta);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
