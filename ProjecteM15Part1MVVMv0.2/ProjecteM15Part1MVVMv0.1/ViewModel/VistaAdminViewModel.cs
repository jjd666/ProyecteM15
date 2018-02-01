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
        private List<pedido> _pedido;
        private pedido _selectedPedido;
        private List<repartidor> _repartidor;
        private repartidor _selectedRepartidor;

        public List<cliente> Cliente
        {
            get
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
                NotifyPropertyChanged();
            }
        }

        public cliente SelectedCliente
        {
            get
            {
                return _selectedCliente;
            }
            set
            {
                _selectedCliente = value;
                FillCliente();
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
            FillCliente();
            FillPedido();
            FillRepartidor();
        }

        private void FillCliente()
        {

        }
        private void FillPedido()
        {

        }
        private void FillRepartidor()
        {

        }
    }

}

