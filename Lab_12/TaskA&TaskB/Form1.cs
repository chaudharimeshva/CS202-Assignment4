using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        //  CUSTOM DELEGATES USING CUSTOM EVENTARGS
        public delegate void ColorChangedHandler(object sender, ColorEventArgs e);

        //  CUSTOM EVENTS
        public event ColorChangedHandler ColorChangedEvent;
        public event TextChangedHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            // Add color options
            comboBoxColors.Items.Add("Red");
            comboBoxColors.Items.Add("Green");
            comboBoxColors.Items.Add("Blue");
            comboBoxColors.SelectedIndex = 0;

            // MULTIPLE SUBSCRIBERS FOR COLOR EVENT
            ColorChangedEvent += UpdateLabelColor;
            ColorChangedEvent += ShowNotification;

            // Subscriber for Text Event
            TextChangedEvent += OnTextChanged;
        }
        // Subscriber Method 1 ? Update Label Color

        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            Color selected = Color.Black;

            if (e.ColorName == "Red") selected = Color.Red;
            if (e.ColorName == "Green") selected = Color.Green;
            if (e.ColorName == "Blue") selected = Color.Blue;

            lblDisplay.ForeColor = selected;
        }

        // Subscriber Method 2 ? Show Notification
        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show("Selected Color: " + e.ColorName);
        }

        // Text Changed Subscriber
        private void OnTextChanged(string newText)
        {
            lblDisplay.Text = newText;
        }

        // Button ? Fires ColorChangedEvent
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            string selectedColor = comboBoxColors.SelectedItem.ToString();

            // FIRE THE EVENT with ColorEventArgs
            ColorChangedEvent?.Invoke(this, new ColorEventArgs(selectedColor));
        }

        // Button ? Fires TextChangedEvent
        private void btnChangeText_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            TextChangedEvent?.Invoke("Updated: " + time);
        }
    }

    //CUSTOM EVENTARGS CLASS
    public class ColorEventArgs : EventArgs
    {
        public string ColorName { get; }

        public ColorEventArgs(string colorName)
        {
            ColorName = colorName;
        }
    }
}

