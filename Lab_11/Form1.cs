using System;
using System.Windows.Forms;

namespace OrderPipeline
{
    public partial class Form1 : Form
    {
        // track whether current order was confirmed
        private bool orderConfirmed = false;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();      // populate combo, defaults
            WireUpStaticSubscribers();  // attach event subscribers
        }

        private void InitializeControls()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.AddRange(new string[] { "Laptop", "Mouse", "Keyboard" });
            cmbProduct.SelectedIndex = 0;

            numQuantity.Minimum = 0;
            numQuantity.Maximum = 100;
            numQuantity.Value = 1;
            lblStatus.Text = "Ready";
        }

        private void WireUpStaticSubscribers()
        {
            // Subscribers for OrderCreated
            this.OrderCreated += ValidateOrder;
            this.OrderCreated += DisplayOrderInfo;

            // Subscriber for OrderRejected
            this.OrderRejected += ShowRejection;

            // Subscriber for OrderConfirmed
            this.OrderConfirmed += ShowConfirmation;

            // Subscriber for OrderShipped (ShowDispatch always present)
            this.OrderShipped += ShowDispatch;
        }

        // Event declarations
        public event EventHandler<ShipEventArgs> OrderCreated;
        public event EventHandler OrderRejected;
        public event EventHandler<ConfirmEventArgs> OrderConfirmed;
        public event EventHandler<ShipEventArgs> OrderShipped;

        // Button Click: Process Order
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            string product = cmbProduct.SelectedItem?.ToString() ?? "Unknown";
            bool express = chkExpress.Checked;
            // Raise OrderCreated
            OrderCreated?.Invoke(this, new ShipEventArgs(product, express));
        }

        // ValidateOrder subscriber
        private void ValidateOrder(object sender, ShipEventArgs e)
        {
            int qty = (int)numQuantity.Value;
            if (qty <= 0)
            {
                orderConfirmed = false;
                lblStatus.Text = "Order Invalid – Please retry";
                OrderRejected?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                orderConfirmed = true;
                lblStatus.Text = "Validated";
                var customer = txtCustomer.Text.Trim();
                OrderConfirmed?.Invoke(this, new ConfirmEventArgs(customer));
            }
        }

        // DisplayOrderInfo subscriber
        private void DisplayOrderInfo(object sender, ShipEventArgs e)
        {
            string customer = txtCustomer.Text.Trim();
            int qty = (int)numQuantity.Value;
            MessageBox.Show(
                $"Order Created:\nCustomer: {customer}\nProduct: {e.Product}\nQuantity: {qty}\nExpress: {e.Express}",
                "Order Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // ShowRejection subscriber
        private void ShowRejection(object sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry";
        }

        // ShowConfirmation subscriber
        private void ShowConfirmation(object sender, ConfirmEventArgs e)
        {
            string customer = e?.Customer;
            if (string.IsNullOrWhiteSpace(customer))
                customer = "<Unknown>";
            lblStatus.Text = $"Order Processed Successfully for {customer}";
        }

        // Button Click: Ship Order
        private void btnShipOrder_Click(object sender, EventArgs e)
        {
            if (!orderConfirmed)
            {
                MessageBox.Show("Cannot ship: order not confirmed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string product = cmbProduct.SelectedItem?.ToString() ?? "Unknown";
            bool express = chkExpress.Checked;
            var args = new ShipEventArgs(product, express);

            // Ensure NotifyCourier not duplicated
            OrderShipped -= NotifyCourier;
            if (express)
                OrderShipped += NotifyCourier;

            OrderShipped?.Invoke(this, args);
        }

        // ShowDispatch subscriber
        private void ShowDispatch(object sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
        }

        // NotifyCourier subscriber
        private void NotifyCourier(object sender, ShipEventArgs e)
        {
            if (e.Express)
                MessageBox.Show("Express delivery initiated!", "Courier Notified", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Optional: checked changed (not required to wire)
        private void chkExpress_CheckedChanged(object sender, EventArgs e)
        {
            // optional preview logic
        }
    }
}
