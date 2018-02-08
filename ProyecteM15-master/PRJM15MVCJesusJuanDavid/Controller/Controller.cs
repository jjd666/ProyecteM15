﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using PRJM15MVCJesusJuanDavid;//VISTA   

namespace Controller
{
    class Controller
    {
        MainForm f1 = new MainForm();
        FormVistaAdmin f2 = new FormVistaAdmin();
        FormVistaClient f3 = new FormVistaClient();
        repartosssEntities db = new repartosssEntities();
        
        public void init()
        {
            liseners();
            run();
            
        }
        public void run()
        {
            Application.Run(f1);
        }
        public void llenartabla() {

            try
            {
                f2.dataGridViewClientes.DataSource = db.clientes.ToList().Select(c => new clienteDTO(c)).ToList();
                //f2.comboBoxRepartidores.DataSource = db.repartidors.ToList().Select(x => new repartidorDTO)).ToList();

            }
            catch (Exception e)

            {
                MessageBox.Show(e.ToString());

                throw;
            }

        }
        public void liseners()
        {
            f1.buttonClient.Click += ButtonClient_Click;
            f1.buttonAdmin.Click += ButtonAdmin_Click;
            f2.dataGridViewClientes.SelectionChanged += DataGridViewPedidos_SelectionChanged;


        }

        private void ButtonClient_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void DataGridViewPedidos_SelectionChanged(object sender, EventArgs e)
        {

            
            clienteDTO P;
            if ((P= clientselectet())!=null)
            {
                clientpedido(P);

            }
        }
        public void clientpedido(clienteDTO C) {

            try
            {
                f2.dataGridViewPedidos.DataSource = db.pedidoes.Where(x => C.DNI.Equals(x.cliente_DNI)).ToList().Select(x => new pedidoDTO(x)).ToList();
                
            }
            catch (Exception)
            {

                throw;
            }


        }
        protected clienteDTO clientselectet() {

            if (f2.dataGridViewClientes.SelectedRows.Count == 0)
            {
                return null;
            }
            else
            {
                return (clienteDTO.clientedtoparalinia(f2.dataGridViewClientes.SelectedRows[0].Cells));
            }

        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            f2.Show();
            llenartabla();
        }
    }
}