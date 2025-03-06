using HiveMQtt.MQTT5.Types;
using Newtonsoft.Json;
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
        public CheckboxButton cbReference;

        public Overlay()
        {
            mqReference = new HAAvailability();
        }

        public Overlay Init()
        {
            var scr = this.Tag as ScreenExtended;
            var deviceName = scr.DeviceName;
            mqReference.name = deviceName.Trim('\\').Trim('.').Trim('\\');

            return this;
        }

        public void UpdateMqtt()
        {
            if (MQTTService.client!=null)
            {
                var topic = $"ScreenDimmer/{mqReference.device.name}/{mqReference.cmd_t.Trim('~')}";
                MQTTService.client.PublishAsync(topic, cbReference.Checked ? MQTTService.HASwitchOn : MQTTService.HASwitchOff);
            }
        }
    }
}
