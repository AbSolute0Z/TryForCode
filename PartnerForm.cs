using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol
{
    public partial class PartnerForm : Form
    {
        private PartnerManager _partnerManager;
        private DataTable _partnersTable;

        public PartnerForm(PartnerManager partnerManager)
        {
            InitializeComponent();
            _partnerManager = partnerManager;
            SetupForm();
            LoadPartners();
        }
        private void SetupForm()
        {
            PartnerGridView.AutoGenerateColumns = false;
        }

        private void LoadPartners()
        {
            _partnersTable = _partnerManager.GetAll(); //получаем всех партнеров
            PartnerGridView.Refresh(); //обновляем таблицу
            if(_partnersTable.Rows.Count == 0)
            {
                MessageBox.Show("Данных для отображения нет");
            }
            else //если данные о партнерах есть то их показываем
            {
                PartnerGridView.DataSource = _partnersTable;
            }
                
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addPartnerForm = new addPartnerForm();
            addPartnerForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var editPartnerForm = new editPartnerForm();
            editPartnerForm.ShowDialog();
        }

        private void PartnerGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
