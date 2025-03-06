using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Augustine.ScreenDimmer
{
    partial class AboutBox : Form
    {
        public static Version version = new Version(1,0);

        public AboutBox()
        {
            InitializeComponent();
            this.Text = "About ScreenDimmer-MultiScreen";
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = "";
            this.textBoxDescription.Text = AssemblyDescription;
            this.Icon = ScreenDimmer.IconMediumBright32x32;
            this.logoPictureBox.Image = TextIcon.CreateTextIcon("\uE286", Color.Black, "", 32).ToBitmap();
        }

        #region Assembly Attribute Accessors

        public string AssemblyVersion
        {
            get
            {
                return version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                return 
                    "ScreenDimmer-Multiscreen is a fork of ScreenDimmer with support for multiple monitors\n" +
                    "Source: https://github.com/Wixely/ScreenDimmer-MultiScreen\n\n" +
                    "Credit: https://github.com/datbnh/ScreenDimmer";
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                return "ↄ2025";
            }
        }
        #endregion
    }
}
