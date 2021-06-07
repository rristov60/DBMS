using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;

namespace Main_DBMS
{
    public partial class Select_Table_Form : Form
    {
        DataTable emptyData = new DataTable();
        public Select_Table_Form()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (comboTables.SelectedIndex)
            {
                case 0:
                    CurrentTable.filled = false;
                    CurrentTable.dtb = emptyData;
                    Queries.TableAuthors();
                    break;
                case 1:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableDiscounts();
                    break;
                case 2:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableEmployee();
                    break;
                case 3:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableJobs();
                    break;
                case 4:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TablePublishers();
                    break;
                case 5:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableRoyalties();
                    break;
                case 6:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableSales();
                    break;
                case 7:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableStores();
                    break;
                case 8:
                    CurrentTable.filled = true;
                    CurrentTable.dtb = emptyData;
                    Queries.TableTitleAuthors();
                    break;
                case 9:
                    CurrentTable.filled = false;
                    CurrentTable.dtb = emptyData;
                    Queries.TableTitles();
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
