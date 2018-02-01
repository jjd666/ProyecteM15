using ProjecteM15Part1MVVMv0._1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjecteM15Part1MVVMv0._1.ViewModel
{
    class VistaAdminViewModel
    {
        repartosEntities ctx = new repartosEntities();

        private List<cliente> _cliente;
        private cliente _selectedCliente;
        private int _selectedIndexCliente;
        private List<pedido> _pedido;
        private pedido _selectedPedido;
        private List<repartidor> _repartidor;
        private repartidor _selectedRepartidor;

        public List<cliente> Cliente
        {
            get { return (_cliente); }
            set { _cliente = value; NotifyPropertyChanged(); }
        }

        public int SelectedIndexCliente
        {
            get { return _selectedIndexCliente; }
            set { _selectedIndexCliente = value; NotifyPropertyChanged(); }
        }

        public cliente SelectedCliente
        {
            get { return (_selectedCliente); }
            set
            {
                _selectedCliente = value;
                FillPedido();
                FillRepartidor();
                NotifyPropertyChanged();
            }
        }
        public List<pedido> Pedido
        {
            get
            {
                return _pedido;
            }
            set
            {
                _pedido = value;
                NotifyPropertyChanged();
            }
        }
        public pedido SelectedPedido
        {
            get
            {
                return _selectedPedido;
            }
            set
            {
                _selectedPedido = value;
                FillPedido();
                NotifyPropertyChanged();
            }
        }
        public List<repartidor> Repartidor
        {
            get
            {
                return _repartidor;
            }
            set
            {
                _repartidor = value;
                NotifyPropertyChanged();
            }
        }
        public repartidor SelectedRepartidor
        {
            get
            {
                return _selectedRepartidor;
            }
            set
            {
                _selectedRepartidor = value;
                FillRepartidor();
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public VistaAdminViewModel()
        {
            FillCliente(0);
            FillPedido();
            FillRepartidor();
        }
        private void FillCliente(int index)
        {
            Cliente = ctx.cliente.OrderBy(x => x.Nombre).ToList();
            if (Cliente != null && index >= 0 && index < Cliente.Count)
            {
                SelectedCliente = Cliente[index];
            }
        }

        private void FillCliente(cliente c)
        {
            FillCliente(0);
            if (c != null)
            {
                SelectedCliente = Cliente.Where(x => x.DNI == c.DNI).FirstOrDefault();
            }

        }
        private void FillPedido()
        {
            if (SelectedCliente != null)
            {
                this.Pedido = SelectedCliente.pedido.OrderBy(x => x.idPedido).ToList();
            }

        }
        private void FillRepartidor()
        {

        }
    }

}

