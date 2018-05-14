
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using PRJM15MVCJesusJuanDavid;//VISTA
using PRJM15MVCJesusJuanDavid.Properties;//resorces


namespace Controller
{
    class Controller
    {
        MainForm f1 = new MainForm();
        FormVistaAdmin f2 = new FormVistaAdmin();
        FormVistaClient f3 = new FormVistaClient();
        vistaFacturas f4 = new vistaFacturas();
        anyadirpedido f5 = new anyadirpedido();
        AnyadirRepartidor f6 = new AnyadirRepartidor();
        inforepjob f7 = new inforepjob();
        RepartosEntities db = new RepartosEntities();

        public void init()
        {
            liseners();
            llenartabla();
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
                f2.comboBoxRepartidores.DataSource = db.repartidors.Where(x => x.Activo == true).ToList().Select(x => new repartidorDTO(x).Nombre).ToList();
                f6.dataGridViewrep.DataSource = db.repartidors.Where(x => x.Activo == true).ToList().Select(x => new repartidorDTO(x)).ToList();
                f5.comboBox1.DataSource = db.clientes.ToList().Select(x => new clienteDTO(x).DNI).ToList();
                f7.comboBoxrep.DataSource = db.repartidors.ToList().Select(x => new repartidorDTO(x).Nombre).ToList();


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
            f6.anyadir.Click += anyadirRepartidorBD;
            f1.salirToolStripMenuItem.Click += SalirToolStripMenuItem_Click;
            f1.añadirPedidoToolStripMenuItem.Click += AñadirPedidoToolStripMenuItem_Click;
            f1.nuevoClienteToolStripMenuItem.Click += ButtonClient_Click;
            f1.modoAvanzadorToolStripMenuItem.Click += ButtonAdmin_Click;
            f2.dataGridViewClientes.SelectionChanged += DataGridViewPedidos_SelectionChanged;
            f3.textBoxNombre.KeyPress += TextBoxNombre_KeyPress;
            f3.buttonsalir.Click += Buttonsalir_Click;
            f2.buttonsalirf2.Click += Buttonsalirf2_Click;
            f2.buttonmostrar.Click += Buttonmostrar_Click;
            f4.buttonSalir.Click += ButtonSalir_Click;
            f1.añadirRepartidorToolStripMenuItem.Click += AñadirRepartidorToolStripMenuItem_Click;
            f6.Borrar.Click += Borrar_Click;
            f5.comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            f5.buttonguardar.Click += Buttonguardar_Click;
            f6.salirrep.Click += Salirrep_Click;
            f1.inforepartidorToolStripMenuItem.Click += InforepartidorToolStripMenuItem_Click;
            f7.buttoncercar.Click += Buttoncercar_Click;
            f7.FormClosing += F7_FormClosing;
            f6.FormClosing += F6_FormClosing;
            f5.FormClosing += F5_FormClosing;
            f4.FormClosing += F4_FormClosing;
            f3.FormClosing += F3_FormClosing;
            f2.FormClosing += F2_FormClosing;
            f3.textBoxDNI.KeyPress += TextBoxDNI_KeyPress;
            f3.textBoxDNI.KeyUp += TextBoxDNI_KeyUp;
            f3.textBoxNombre.KeyPress += TextBoxNombre_KeyPress1;
            f3.textBoxTelefono.KeyPress += TextBoxTelefono_KeyPress;
            f6.checkBoxactivo.CheckedChanged += CheckBoxactivo_CheckedChanged;
            f6.Nombrerep.KeyPress += Nombrerep_KeyPress;
            f6.repdni.KeyPress += Repdni_KeyPress;
            f6.repdni.KeyUp += Repdni_KeyUp;


        }

        private void Repdni_KeyUp(object sender, KeyEventArgs e)
        {
            if (f6.repdni.Text.Length == 8 && !(e.KeyCode == (Keys.Back)))
            {

                f6.repdni.Text = f6.repdni.Text + "-";
                f6.repdni.SelectionStart = f6.repdni.TextLength;


            }
        }

        private void Repdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f6.repdni.Text.Length < 8)
            {

                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {

                    e.Handled = false;

                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                if (f6.repdni.Text.Length == 9)

                    e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

        }

        private void Nombrerep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {

                e.Handled = true;
            }


        }
    

        private void CheckBoxactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (f6.checkBoxactivo.Checked)
            {
                f6.dataGridViewrep.DataSource = db.repartidors.Where(x => x.Activo == false).ToList().Select(x => new repartidorDTO(x)).ToList();
            }
            else { f6.dataGridViewrep.DataSource = db.repartidors.Where(x => x.Activo == true).ToList().Select(x => new repartidorDTO(x)).ToList(); }
        }

        //------control TELEFONO----//
        private void TextBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f3.textBoxTelefono.Text.Length < 9)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            { e.Handled = true; }
        }

        //-----FIN control TELEFONO ----//


        //contrl campo nobre form f3----//

        private void TextBoxNombre_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {

                e.Handled = true;
            }


        }


        // ----fin control campo nombre f3 //
        //----controlbuttDNi  vista f3 ----//
        private void TextBoxDNI_KeyUp(object sender, KeyEventArgs e)
        {
            if (f3.textBoxDNI.Text.Length == 8 && !(e.KeyCode == (Keys.Back))) {

                f3.textBoxDNI.Text = f3.textBoxDNI.Text + "-";
                f3.textBoxDNI.SelectionStart = f3.textBoxDNI.TextLength;


            }
        }

        private void TextBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (f3.textBoxDNI.Text.Length < 8)
            {

                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {

                    e.Handled = false;

                }

            }
            else if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                if (f3.textBoxDNI.Text.Length == 9)

                    e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }
        //---FIN CONTRL Textdeni-----//

        private void F7_FormClosing(object sender, FormClosingEventArgs e)
        {
            f7.Hide();
            e.Cancel = true;

        }
        private void F6_FormClosing(object sender, FormClosingEventArgs e)
        {
            f6.Hide();
            e.Cancel = true;
        }
        private void F5_FormClosing(object sender, FormClosingEventArgs e)
        {
            f5.Hide();
            e.Cancel = true;
        }
        private void F4_FormClosing(object sender, FormClosingEventArgs e)
        {
            f4.Hide();
            e.Cancel = true;
        }
        private void F3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f3.Hide();
            e.Cancel = true;
        }
        private void F2_FormClosing(object sender, FormClosingEventArgs e)
        {
            f2.Hide();
            e.Cancel = true;
        }
        private void F1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Hide();
            e.Cancel = true;
        }

        private void InforepartidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.Visible = true;
        }

        private void Salirrep_Click(object sender, EventArgs e)
        {
            f6.Visible = false;
        }

        private void AñadirRepartidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.Visible = true;
        }

        private void AñadirPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Visible = true;
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f1.Close();
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            f4.Visible = false;
        }

        private void Buttonmostrar_Click(object sender, EventArgs e)
        {
            f4.Visible = true;
        }

        private void Buttonsalirf2_Click(object sender, EventArgs e)
        {
            f2.Hide();
        }

        private void Buttonsalir_Click(object sender, EventArgs e)
        {
            f3.Hide();

        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (char.IsLetter((char)e.KeyChar)) {
                    e.Handled = false;
                }
                else if (char.IsControl((char)e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsSeparator((char)e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;

            }
        }


        private void ButtonGuardarClient_Click(object sender, EventArgs e)
        {
            DateTime Hoy = DateTime.Today;

            cliente c = new cliente();
            pedido p = new pedido();
            c.DNI = f3.textBoxDNI.Text;
            c.Direccion = f3.textBoxDireccion.Text;
            c.Nombre = f3.textBoxNombre.Text;
            c.Telefono = f3.textBoxTelefono.Text;

            db.clientes.Add(c);

            p.idPedido = db.pedidoes.Count() + 1;
            p.FechaPedido = Hoy;
            p.FechaEntrega = Hoy.AddDays(2);
            p.Entregado = "NO";

            p.cliente_DNI = f3.textBoxDNI.Text;

            db.pedidoes.Add(p);

            int n = trySaveClient();
            if (n == 1)
            {
                f3.textBoxDNI.Text = "";
                f3.textBoxDireccion.Text = "";
                f3.textBoxNombre.Text = "";
                f3.textBoxTelefono.Text = "";
                llenartabla();
            } else
            {
                System.Console.WriteLine("ERROR");
                MessageBox.Show(Resources.errorañadir);
            }

        }

        private void ButtonGuardarAdmin_Click(object sender, EventArgs e)
        {
            factura F = new factura();
            F.Administrador_idAdministrador = 1;
            F.idFactura = db.facturas.Count() + 1;
            F.Entrega = false;
            int conv = Convert.ToInt32(f2.dataGridViewPedidos.SelectedRows[0].Cells["idPedido"].Value.ToString());
            F.Pedido_idPedido = conv;
            F.Pedido_Cliente_DNI = f2.dataGridViewClientes.SelectedRows[0].Cells["DNI"].Value.ToString();
            F.Repartidor_idRepartidor = f2.comboBoxRepartidores.SelectedIndex + 1;//solo estara correcto si estan ordenador por idrepartidor

            db.facturas.Add(F);
            int n = trySaveAdmin();
            if (n > 0)
            {
                f3.textBoxDNI.Text = "";
                f3.textBoxDireccion.Text = "";
                f3.textBoxNombre.Text = "";
                f3.textBoxTelefono.Text = "";
                llenartabla();
                volerseleccionar(n);
            }
            else
            {
                System.Console.WriteLine("ERROR");
            }

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
            if ((P = clientselectet()) != null)
            {
                clientpedido(P);

            }
        }
        public void clientpedido(clienteDTO C) {

            try
            {
                f2.dataGridViewPedidos.DataSource = db.pedidoes.Where(x => C.DNI.Equals(x.cliente_DNI)).ToList().Select(x => new pedidoDTO(x)).ToList();
                int a = Convert.ToInt32(f2.dataGridViewPedidos.SelectedRows[0].Cells["idPedido"].Value.ToString());
                f4.label1.Text = C.Nombre;
                f4.dataGridViewFacturasClient.DataSource = db.facturas.Where(x => x.Pedido_idPedido == a).ToList().Select(x => new facturaDTO(x)).ToList();
                var qq = from factura b in db.facturas
                         join qw in db.repartidors on b.Repartidor_idRepartidor equals qw.idRepartidor
                         where (b.Pedido_idPedido == a)
                         orderby b.Entrega, qw.Nombre
                         select new { b.idFactura, qw.Nombre, qw.Zona, qw.DNIrep, b.Entrega, };
                f4.dataGridViewFacturasClient.DataSource = qq.ToList();


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


        //-------------------------------------------------//
        //ventana añadir repartidor//
        public void anyadirRepartidorBD(object sender, EventArgs e) {

            repartidor rep = new repartidor();


            rep.idRepartidor = db.repartidors.Max(x => x.idRepartidor) + 1;
            rep.Nombre = f6.Nombrerep.Text;
            rep.DNIrep = f6.repdni.Text;
            rep.Zona = f6.zonarep.Text;
            rep.Activo = true;
            rep.Contrasenya = "1234";

            db.repartidors.Add(rep);
            int n = trySaveClient();
            llenartabla();
            if (n == 0) {

                repartidor rep1= db.repartidors.Where(x => x.DNIrep.Equals(f6.repdni.Text)).FirstOrDefault();
                rep1.Activo = true;
                trySaveClient();
                llenartabla();


            }

        }

    
        private void Borrar_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(f6.dataGridViewrep.SelectedRows[0].Cells["idRepartidor"].Value);
            repartidor rep = db.repartidors.Where(x => x.idRepartidor == a).FirstOrDefault();
            if (f6.checkBoxactivo.Checked == true)
            {
                rep.Activo = true;
            }
            else
                rep.Activo = false;
            
            int n = trySaveClient();
            llenartabla();
            f6.checkBoxactivo.Checked = false;
        }
        //---//

        //----------------------------------//
        //ventana añadirpedido//

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dni = f5.comboBox1.SelectedItem.ToString();
            clienteDTO cl = db.clientes.Where(x => x.DNI.Equals(dni)).ToList().Select(x => new clienteDTO(x)).FirstOrDefault();
            f5.textBoxNombre.Text = cl.Nombre;
            f5.textBoxdirecc.Text = cl.Direccion;
            f5.textBoxTLF.Text = cl.Telefono;
        }

        private void Buttonguardar_Click(object sender, EventArgs e)
        {

            DateTime Hoy = DateTime.Today;
            string dni = f5.comboBox1.SelectedItem.ToString();
            pedido ped = new pedido();
            ped.idPedido= db.pedidoes.Max(x => x.idPedido) + 1;       
            ped.FechaPedido = Hoy;
            ped.FechaEntrega = Hoy.AddDays(2);
            ped.Entregado = "No";
            ped.Decripcion = f5.richTextBoxdescrip.Text;
            ped.cliente_DNI = dni;

            db.pedidoes.Add(ped);

            int n = trySaveClient();
           
            llenartabla();

        }
        //--------//
        // vista infojobrep//

        private void Buttoncercar_Click(object sender, EventArgs e)
        {
            
            int a = f7.comboBoxrep.SelectedIndex+1;
            if (f7.checkBoxpendiente.Checked)
            {

                //f7.dataGridViewrepjob.DataSource = db.facturas.Where(x => x.Repartidor_idRepartidor == a && x.Entrega == 0).ToList().Select(x => new facturaDTO(x)).ToList();
                var qq = from factura b in db.facturas
                         join qw in db.repartidors on b.Repartidor_idRepartidor equals qw.idRepartidor
                         join sd in db.pedidoes on b.idFactura equals sd.idPedido
                         join cl in db.clientes on sd.cliente_DNI equals cl.DNI
                         where (qw.idRepartidor == a && b.Entrega == false)
                         orderby b.Entrega, qw.Nombre
                         select new { b.idFactura, qw.Nombre, qw.Zona, qw.DNIrep, b.Entrega,Nombrecliente=cl.Nombre};
                f7.dataGridViewrepjob.DataSource = qq.ToList();
            }
            else if (f7.checkBoxterminiado.Checked)
            {
               // f7.dataGridViewrepjob.DataSource = db.facturas.Where(x => x.Repartidor_idRepartidor == a && x.Entrega == 1).ToList().Select(x => new facturaDTO(x)).ToList();

                var qq = from factura b in db.facturas
                         join qw in db.repartidors on b.Repartidor_idRepartidor equals qw.idRepartidor
                         join sd in db.pedidoes on b.idFactura equals sd.idPedido
                         join cl in db.clientes on sd.cliente_DNI equals cl.DNI
                         where (qw.idRepartidor == a && b.Entrega == true)
                         orderby b.Entrega, qw.Nombre
                         select new { b.idFactura, qw.Nombre, qw.Zona, qw.DNIrep, b.Entrega,Nombrecliente=cl.Nombre };
                f7.dataGridViewrepjob.DataSource = qq.ToList();


            }
            else {

                var qq = from factura b in db.facturas
                         join qw in db.repartidors on b.Repartidor_idRepartidor equals qw.idRepartidor
                         join sd in db.pedidoes on b.idFactura equals sd.idPedido
                         join cl in db.clientes on sd.cliente_DNI equals cl.DNI
                         where (qw.idRepartidor == a)
                         orderby b.Entrega, qw.Nombre
                         select new {b.idFactura, qw.Nombre, qw.Zona, qw.DNIrep, b.Entrega,Nombrecliente=cl.Nombre};
                f7.dataGridViewrepjob.DataSource = qq.ToList();


            }

        }


    }
}