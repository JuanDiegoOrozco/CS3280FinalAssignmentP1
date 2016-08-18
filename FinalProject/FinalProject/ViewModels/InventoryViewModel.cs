using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using InventoryData;
using System.Collections.ObjectModel;
namespace FinalAssignment.ViewModels
{
    class InventoryViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private ObservableCollection<Order> icollection;
        public InventoryViewModel()
        {
            this.DisplayName = "Inventory Application";

            //Dummy data
            Order dummy1 = new Order();
            dummy1.OrderNumber = 1;
            dummy1.DatePlaced = DateTime.Today;
            User dumdum = new User();
            dumdum.Name = "Mike Jones";
            dumdum.Phone = "218-330-8004";
            dumdum.UserId = 1234;
            dummy1.Purchaser = dumdum;
            dummy1.TotalCost = 1000000;

            icollection = new ObservableCollection<Order>();
            icollection.Add(dummy1);
        }
        public ObservableCollection<Order> AllOrders
        {
            get
            {
                return icollection;
            }
        }
        protected override void OnActivate()
        {
            base.OnActivate();
            Orders();
            foreach (Order od in icollection)
            {
                //OrdersViewList.
            }
        }
        public void Orders()
        {
            //var ordersVM = IoC.Get<OrdersViewModel>();
            //IoC.Get<OrdersViewModel>();
            //OnActivate(ordersVM);
        }
        IEnumerable<Order> OrdersView
        {
            get { return icollection; }
        }
    }
}
