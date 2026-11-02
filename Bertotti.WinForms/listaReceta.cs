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
    public partial class listaReceta : Form
    {
        private readonly RecetaApiClient api = new RecetaApiClient();
        public listaReceta()
        {
            InitializeComponent();
        }

        private async void filtrarBtn_Click(object sender, EventArgs e)
        {
            try { await CargarAsync(); }
            catch (Exception ex) { MessageBox.Show("error al filtrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void dispensarBtn_Click(object sender, EventArgs e)
        {
            if (recetaDataGrid.CurrentRow?.DataBoundItem is not Receta receta)
            {
                MessageBox.Show("Seleccione una receta.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                await api.DispensarAsync(receta.Id);
                await CargarAsync();
            }
            catch (Exception ex) { MessageBox.Show("error al Dispensar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void agregarBtn_Click(object sender, EventArgs e)
        {
            using var frm = new agregarReceta();   // el nombre de tu form de alta
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                try { await CargarAsync(); }
                catch (Exception ex) { MessageBox.Show("error al agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

        }

        private async void listaReceta_Load(object sender, EventArgs e)
        {
            try
            {
                estadoListBox.ClearSelected();
                await CargarAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarAsync()
        {
            var estado = estadoListBox.SelectedItem?.ToString();
            if (estado == "Todos" || estado == null) estado = null;
            recetaDataGrid.DataSource = await api.GetAsync(estado);
        }
    }
}
