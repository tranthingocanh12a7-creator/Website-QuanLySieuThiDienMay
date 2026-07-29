using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN1
{
    public static class DataGridViewHelper
    {
        public static void FormatDataGridView(
       DataGridView dgv,
       string[] rightAlignColumns = null,
       string[] dateColumns = null,
       string[] currencyColumns = null,
       bool centerAll = false
   )
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (centerAll)
                {
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

            if (rightAlignColumns != null)
            {
                foreach (string col in rightAlignColumns)
                    if (dgv.Columns.Contains(col))
                        dgv.Columns[col].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dateColumns != null)
            {
                foreach (string col in dateColumns)
                    if (dgv.Columns.Contains(col))
                        dgv.Columns[col].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (currencyColumns != null)
            {
                foreach (string col in currencyColumns)
                    if (dgv.Columns.Contains(col))
                        dgv.Columns[col].DefaultCellStyle.Format = "N0";
            }
        }
    }
}
