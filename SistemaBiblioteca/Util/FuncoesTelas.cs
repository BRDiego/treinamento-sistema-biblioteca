using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBiblioteca.Util
{
    internal class FuncoesTelas
    {
        private static FuncoesTelas _instance = new FuncoesTelas();

        public static FuncoesTelas GetInstance()
        {
            return _instance;
        }

        public void ExibirInformacao(string mensagem, string titulo = "INFO")
        {
            MessageBox.Show(
                mensagem,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        public void ExibirAlerta(string mensagem, string titulo = "ATENCAO")
        {
            MessageBox.Show(
                mensagem,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        public void ExibirErro(string mensagem, string titulo = "Erro na aplicacao")
        {
            MessageBox.Show(
                mensagem,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public void ExibirErro(Exception ex, string titulo = "Erro na aplicacao")
        {
            MessageBox.Show(
                ex.Message,
                titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }

        public static void StyleDataGridView(DataGridView grid)
        {
            // General
            grid.AutoGenerateColumns = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;

            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;

            grid.ReadOnly = true;

            // Row
            grid.RowTemplate.Height = 36;

            // Header
            grid.ColumnHeadersHeight = 40;
            grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            // Cells
            grid.DefaultCellStyle = new DataGridViewCellStyle
            {
                Font = new Font("Segoe UI", 10F),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                SelectionBackColor = Color.LightSteelBlue,
                SelectionForeColor = Color.Black
            };

            // Alternating rows
            grid.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.WhiteSmoke
            };

            // Borders
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.LightGray;

            // Don't let the user change column widths
            grid.AllowUserToResizeColumns = false;

            // Better default sizing behavior
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Remove ugly visual focus rectangle
            grid.RowHeadersVisible = false;
        }

        public void ConfigurarTela(Form item)
        {
            foreach (Control control in item.Controls)
            {
                if (control is DataGridView)
                {
                    StyleDataGridView((DataGridView)control);
                }
            }
        }
    }
}
