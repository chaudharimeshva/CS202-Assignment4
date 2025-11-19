using System;

namespace OrderPipeline
{
    public class ConfirmEventArgs : EventArgs
    {
        public string Customer { get; }

        public ConfirmEventArgs(string customer)
        {
            Customer = customer;
        }
    }
}
