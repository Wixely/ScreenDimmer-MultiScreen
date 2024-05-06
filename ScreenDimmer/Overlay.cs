using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Augustine.ScreenDimmer
{
    public class Overlay : Form
    {
        public HAAvailability mqReference;
        public CheckBox cbReference;

        public Overlay()
        {
            mqReference = new HAAvailability();
        }

        public Overlay Init()
        {
            var scr = this.Tag as Screen;
            var deviceName = scr.DeviceName;

            mqReference.name = deviceName.Trim('\\').Trim('.').Trim('\\');


            return this;
        }

        public void UpdateMqtt()
        {

            
            if (MQTTService.client!=null)
            {
                var topic = $"ScreenDimmer/{mqReference.device.name}/{mqReference.cmd_t.Trim('~')}";// mqReference.cmd_t;
                MQTTService.client.PublishAsync(topic, cbReference.Checked ? MQTTService.HASwitchOn : MQTTService.HASwitchOff);

            }

        }
    }
}
