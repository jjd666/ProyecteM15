
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
                f2.comboBoxRepartidores.DataSource = db.repartidors.ToList().Select(x => new repartidorDTO(x).Nombre).ToList();

            }
            catch (Exception e)

            {
                MessageBox.Show(e.ToString());

                throw;
            }

        }
        public void liseners()
        {
            f2.buttonGuardar.Click += ButtonGuardarAdmin_Click;
            f3.buttonGuardar.Click += ButtonGuardarClient_Click;
            f1.buttonClient.Click += ButtonClient_Click;
            f1.buttonAdmin.Click += ButtonAdmin_Click;
            f2.dataGridViewClientes.SelectionChanged += DataGridViewPedidos_SelectionChanged;


        }

        private void ButtonGuardarClient_Click(object sender, EventArgs e)
        {
            cliente c = new cliente();
            pedido p = new pedido();
            c.DNI = f3.textBoxDNI.Text;
            c.Direccion = f3.textBoxDireccion.Text;
            c.Nombre = f3.textBoxNombre.Text;
            c.Telefono = f3.textBoxTelefono.Text;

            db.clientes.Add(c);


            int n = trySaveClient();
            if (n==1)
            {
                f3.textBoxDNI.Text = "";
                f3.textBoxDireccion.Text = "";
                f3.textBoxNombre.Text = "";
                f3.textBoxTelefono.Text = "";
                llenartabla();
            }else
            {
                System.Console.WriteLine("ERROR");
            }
        }

        private void ButtonGuardarAdmin_Click(object sender, EventArgs e)
        {
            factura F = new factura();
            F.Administrador_idAdministrador = 1;
            F.idFactura = db.facturas.Count() + 1;
            F.Entrega = 0;
            int conv = Convert.ToInt32(f2.dataGridViewPedidos.SelectedRows[0].Cells["idPedido"].Value.ToString());
            F.Pedido_idPedido = conv;
            F.Pedido_Cliente_DNI = f2.dataGridViewClientes.SelectedRows[0].Cells["DNI"].Value.ToString();
            F.Repartidor_idRepartidor = f2.comboBoxRepartidores.SelectedIndex + 1;//solo estara correcto si estan ordenador por idrepartidor
            db.facturas.Add(F);
            int n = trySaveAdmin();
            llenartabla();
            volerseleccionar(n);

        }

        protected int trySaveClient()
        {
            try
            {
                db.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }

        protected int trySaveAdmin()
        {
            try
            {
                db.SaveChanges();
                return (f2.dataGridViewClientes.SelectedRows[0].Index);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                return 0;
            }
        }
        protected void volerseleccionar(int n)
        {
            try
            {
                f2.dataGridViewClientes.CurrentCell = f2.dataGridViewClientes.Rows[n].Cells[0];
            }
            catch
            {
            }
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
