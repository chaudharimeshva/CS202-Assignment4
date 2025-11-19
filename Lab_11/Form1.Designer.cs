namespace OrderPipeline
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblQuantity;

        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.CheckBox chkExpress;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.Button btnShipOrder;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();

            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.chkExpress = new System.Windows.Forms.CheckBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.btnShipOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();

            //
            // lblCustomer
            //
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 16);
            this.lblCustomer.Text = "Customer Name:";

            //
            // txtCustomer
            //
            this.txtCustomer.Location = new System.Drawing.Point(20, 40);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(220, 22);
            this.txtCustomer.TabIndex = 0;

            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(20, 75);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 16);
            this.lblProduct.Text = "Product:";

            //
            // cmbProduct
            //
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(20, 95);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(220, 24);
            this.cmbProduct.TabIndex = 1;

            //
            // lblQuantity
            //
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(20, 135);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 16);
            this.lblQuantity.Text = "Quantity:";

            //
            // numQuantity
            //
            this.numQuantity.Location = new System.Drawing.Point(20, 155);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 2;

            //
            // chkExpress
            //
            this.chkExpress.AutoSize = true;
            this.chkExpress.Location = new System.Drawing.Point(160, 156);
            this.chkExpress.Name = "chkExpress";
            this.chkExpress.Size = new System.Drawing.Size(76, 21);
            this.chkExpress.TabIndex = 3;
            this.chkExpress.Text = "Express";
            this.chkExpress.UseVisualStyleBackColor = true;
            this.chkExpress.CheckedChanged += new System.EventHandler(this.chkExpress_CheckedChanged);

            //
            // btnProcessOrder
            //
            this.btnProcessOrder.Location = new System.Drawing.Point(20, 195);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(120, 32);
            this.btnProcessOrder.TabIndex = 4;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);

            //
            // btnShipOrder
            //
            this.btnShipOrder.Location = new System.Drawing.Point(160, 195);
            this.btnShipOrder.Name = "btnShipOrder";
            this.btnShipOrder.Size = new System.Drawing.Size(120, 32);
            this.btnShipOrder.TabIndex = 5;
            this.btnShipOrder.Text = "Ship Order";
            this.btnShipOrder.UseVisualStyleBackColor = true;
            this.btnShipOrder.Click += new System.EventHandler(this.btnShipOrder_Click);

            //
            // lblStatus
            //
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(20, 245);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(260, 32);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            //
            // Form1
            //
            this.ClientSize = new System.Drawing.Size(310, 300);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.chkExpress);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.btnShipOrder);
            this.Controls.Add(this.lblStatus);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OrderPipeline";

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
