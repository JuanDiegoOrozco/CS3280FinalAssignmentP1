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
    class NewOrderViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private ObservableCollection<Order> icollection;
        public NewOrderViewModel()
        {
            this.DisplayName = "New Order";

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

            Order dummy2 = new Order();
            dummy2.OrderNumber = 2;
            dummy2.DatePlaced = DateTime.Today;
            User dumdum2 = new User();
            dumdum2.Name = "50 Cent";
            dumdum2.Phone = "435-754-8289";
            dumdum2.UserId = 5678;
            dummy2.Purchaser = dumdum2;
            dummy2.TotalCost = .50m;

            icollection = new ObservableCollection<Order>();
            icollection.Add(dummy1);
            icollection.Add(dummy2);

            ////////////////////////////////////////////////////////

            Item thing1 = new Item();
            thing1.Name = "Retro Jordan 4";
            thing1.Cost = 199.99m;
            thing1.ItemNumber = 4;
            thing1.OrderItems = dummy1.OrderItems;
            thing1.QuantityOnHand = 7;

            Item thing2 = new Item();
            thing2.Name = "Retro Jordan 13";
            thing2.Cost = 249.99m;
            thing2.ItemNumber = 13;
            thing2.OrderItems = dummy2.OrderItems;
            thing2.QuantityOnHand = 17;

            OrderItem dumster1 = new OrderItem();
            dumster1.ItemNumber = thing1.ItemNumber;
            dumster1.Quantity = 5;
            dumster1.ItemCost = 41;
            dumster1.Item = thing1;
            dumster1.OrderNumber = dummy1.OrderNumber;
            dumster1.OrderItemNumber = thing1.ItemNumber;
            dumster1.Order = dummy1;

            OrderItem dumster2 = new OrderItem();
            dumster2.ItemNumber = thing1.ItemNumber;
            dumster2.Quantity = 9;
            dumster2.ItemCost = 70;
            dumster2.Item = thing2;
            dumster2.OrderNumber = dummy2.OrderNumber;
            dumster2.OrderItemNumber = thing2.ItemNumber;
            dumster2.Order = dummy1;

            //icollection = new ObservableCollection<OrderItem>();
            //icollection.Add(dumster1);
            //icollection.Add(dumster2);

            //icollection = new ObservableCollection<Item>();
            //icollection.Add(thing1);
            //icollection.Add(thing2);

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

        /////////////////////////////////////////////////////////////////

        private ObservableCollection<OrderItem> orderItems;
        public ObservableCollection<OrderItem> AllItems
        {
            get
            {
                return orderItems;
            }
        }

    }
}
