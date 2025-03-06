using System;
using System.Windows.Forms;

namespace Augustine.ScreenDimmer
{
    public class CheckboxButton : Button
    {

        private bool isChecked = false;
        public static int DefaultSize = 30;

        public bool Checked
        {
            get { return isChecked; }
            set {
                var triggerChange = (isChecked != value);
                isChecked = value;
                if (triggerChange)
                {
                    RunUpdate();
                }
            }
        }

        public string CBName = "";
        public static string TextEnabled = "🕶️";
        public static string TextDisabled = "🔆";

        public event EventHandler CheckedChanged;

        public CheckboxButton()
        {
            UpdateText();
            this.Click += CheckboxButton_Click;
        }

        private void CheckboxButton_Click(object sender, EventArgs e)
        {
            Toggle();
        }

        public void Toggle()
        {
            Checked = !Checked;
        }

        public void SetEnable()
        {
            Checked = true;
        }

        public void SetDisable()
        {
            Checked = false;
        }
        public void UpdateText()
        {
            Text = $"{(Checked ? TextEnabled : TextDisabled)}";
        }

        public void RunUpdate()
        {
            UpdateText();
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
