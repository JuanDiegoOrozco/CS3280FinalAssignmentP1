using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using InventoryData;
using System.Collections.ObjectModel;
using FinalAssignment.Views;
using System.Windows.Input;
using System.Windows;

namespace FinalAssignment.ViewModels
{
    class NewOrderViewModel : Screen
    {
        /// <summary>
        /// Textbox variables
        /// </summary>
        private string _UOrderNumber;
        private string _UPurchaseDate;
        private string _UPurchaser;
        private string _UOrderTotal;
        /// <summary>
        /// //////////////////////////////
        /// </summary>


        private ObservableCollection<OrderItem> icollection;
        private IEnumerable<Item> Items;
        private OrderItem _SelectedItem;
        private static string Title = "Create New Order";
        public NewOrderViewModel()
        {
            this.DisplayName = Title;

            //Dummy data for testing
            Item thing1 = new Item();
            thing1.Name = "Adidas";
            thing1.Cost = 69.99m;
            thing1.ItemNumber = 71;
            thing1.QuantityOnHand = 17;

            Item thing2 = new Item();
            thing2.Name = "Retro Jordan 13";
            thing2.Cost = 249.99m;
            thing2.ItemNumber = 13;
            thing2.QuantityOnHand = 17;

            Item thing3 = new Item();
            thing3.Name = "Playstation 5";
            thing3.Cost = 499.99m;
            thing3.ItemNumber = 21;
            thing3.QuantityOnHand = 17;

            OrderItem dumster1 = new OrderItem();
            dumster1.ItemNumber = thing1.ItemNumber;
            dumster1.Quantity = 5;
            dumster1.ItemCost = 41;
            dumster1.Item = thing1;
            dumster1.OrderNumber = 1;
            dumster1.OrderItemNumber = thing1.ItemNumber;

            OrderItem dumster2 = new OrderItem();
            dumster2.ItemNumber = thing1.ItemNumber;
            dumster2.Quantity = 9;
            dumster2.ItemCost = 70;
            dumster2.Item = thing2;
            dumster2.OrderNumber = 2;
            dumster2.OrderItemNumber = thing2.ItemNumber;

            OrderItem dumster3 = new OrderItem();
            dumster3.ItemNumber = thing3.ItemNumber;
            dumster3.Quantity = 9;
            dumster3.ItemCost = 70;
            dumster3.Item = thing3;
            dumster3.OrderNumber = 3;
            dumster3.OrderItemNumber = thing3.ItemNumber;
            icollection = new ObservableCollection<OrderItem>();
            icollection.Add(dumster1);
            icollection.Add(dumster2);
            icollection.Add(dumster3);

        }

        public IInventoryData DataManager
        {
            get; set;
        }

        /// <summary>
        /// Save Button Handeling. It called the CheckANDSave function when triggered...
        /// </summary>
        public ICommand SaveOrderB
        {
            get
            {
                //MessageBox.Show("NewOrdersButton Triggered");
                return new DelegateCommand<object>(CheckANDSave, true);
            }

        }

        /// <summary>
        /// Used to grab the selected item within the listbox
        /// </summary>
        public OrderItem SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;
                NotifyOfPropertyChange("SelectedItem");
            }
        }
        /// <summary>
        /// This is where you check for valid input and save
        /// </summary>
        public void CheckANDSave()
        {
            bool AbleToSave = true;//used to see if they can save
            int regOrderNumber;// if parse is successful this should have a value
            DateTime Udate;// tool for parsing dates this should have a value if successful
            decimal OrderTotal;// if parse is successful this should have a value
            //////////////////////////////////////////////////////////_UOrderNumber Error Handeling
            if (String.IsNullOrWhiteSpace(_UOrderNumber))
            {// check if empty
                MessageBox.Show("Please Type in the Order Number");
                AbleToSave = false;
            }
            else if (!Int32.TryParse(_UOrderNumber, out regOrderNumber))
            {
                AbleToSave = false;
                MessageBox.Show("Please Type in the Order Number");
            }
            else if (regOrderNumber != null)
            {
                if (regOrderNumber <= 0)
                {
                    AbleToSave = false;
                    MessageBox.Show("Please Type in a number greater than 0 for Order Number");
                }
            }
            //////////////////////////////////////////////////////////_UOrderNumber Error Handeling

            //////////////////////////////////////////////////////////_UPurchaseDate Error Handeling
            if (String.IsNullOrWhiteSpace(_UPurchaseDate))
            {// check if empty
                MessageBox.Show("Please Type in a Purchase Date");
                AbleToSave = false;
            }
            else if (!DateTime.TryParse(_UPurchaseDate, out Udate))
            {
                AbleToSave = false;
                MessageBox.Show("Please enter a proper date format");
            }
            //////////////////////////////////////////////////////////_UPurchaseDate Error Handeling

            //////////////////////////////////////////////////////////_UPurchaser Error Handeling
            if (String.IsNullOrWhiteSpace(_UPurchaser))
            {// check if empty
                MessageBox.Show("Please Type in a Purchaser");
                AbleToSave = false;
            }
            //////////////////////////////////////////////////////////_UPurchaser Error Handeling

            //////////////////////////////////////////////////////////_UOrderTotal Error Handeling
            if (String.IsNullOrWhiteSpace(_UOrderTotal))
            {// check if empty
                MessageBox.Show("Please Type in the Order Total");
                AbleToSave = false;
            }
            else if (!Decimal.TryParse(_UOrderTotal, out OrderTotal))
            {
                AbleToSave = false;
                MessageBox.Show("Please Type in the Order Number");
            }
            else if (OrderTotal != null)
            {
                if (OrderTotal <= 0)
                {
                    AbleToSave = false;
                    MessageBox.Show("Please Type in a number greater than 0 for Order Total");
                }
            }
            //////////////////////////////////////////////////////////_UOrderTotal Error Handeling

            //////////////////////////////////////////////////////////SelectedItem Error Handeling
            if(_SelectedItem == null)
            {
                MessageBox.Show("Please select an item");
            }
            //////////////////////////////////////////////////////////SelectedItem Error Handeling

        }

        protected override async void OnActivate()
        {
            base.OnActivate();

            Items = await DataManager.GetItemsAsync();

            //IoC.Get<OrdersViewModel>(). = Title;
        }

        public ObservableCollection<OrderItem> AllItems
        {
            get
            {
                return icollection;
            }
        }
        public void Orders()
        {
            //var ordersVM = IoC.Get<OrdersViewModel>();
            //IoC.Get<OrdersViewModel>();
            //OnActivate(ordersVM);
        }

        /////////////////////////////////////////////////////////////////

        //private ObservableCollection<Item> orderItems;
        //public ObservableCollection<Item> AllItems
        //{
        //    get
        //    {
        //        return orderItems;
        //    }
        //}

        /// <summary>
        /// This is where you receive the textbox's information
        /// </summary>
        /// 
        public string UOrderNumber
        {
            get
            {
                return _UOrderNumber;
            }
            set
            {
                _UOrderNumber = value;
                NotifyOfPropertyChange(_UOrderNumber);
            }
        }
        public string UPurchaseDate
        {
            get
            {
                return _UPurchaseDate;
            }
            set
            {
                _UPurchaseDate = value;
                NotifyOfPropertyChange(_UPurchaseDate);
            }
        }
        public string UPurchaser
        {
            get
            {
                return _UPurchaser;
            }
            set
            {
                _UPurchaser = value;
                NotifyOfPropertyChange(_UPurchaser);
            }
        }
        public string UOrderTotal
        {
            get
            {
                return _UOrderTotal;
            }
            set
            {
                _UOrderTotal = value;
                NotifyOfPropertyChange(_UOrderTotal);
            }
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////
        /// </summary>
        /// 

        internal class DelegateCommand<T> : ICommand
        {
            private System.Action stuff;
            private bool v;

            public DelegateCommand(System.Action stuff, bool v)
            {
                this.stuff = stuff;
                this.v = v;
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                stuff();
            }
        }


    }
}

