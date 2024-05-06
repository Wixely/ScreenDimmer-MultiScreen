using HiveMQtt.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiveMQtt.Client;
using HiveMQtt.MQTT5.Types;
using Newtonsoft.Json;
using System.Xml;

namespace Augustine.ScreenDimmer
{
    public class MQTTService
    {
        public static ScreenDimmer screenDimmerMain;
        public static HiveMQClient client;

        public const string HASwitchOn = "ON";
        public const string HASwitchOff = "OFF";

        public static async Task Connect(ScreenDimmer screenDimmer)
        {
            screenDimmerMain = screenDimmer;
            try
            {
                // Setup Client options and instantiate
                var options = new HiveMQClientOptionsBuilder().
                                    Build();

                client = new HiveMQClient(options);
                // Connect to the MQTT broker
                var connectResult = await client.ConnectAsync().ConfigureAwait(false);

                // Configure the subscriptions we want and subscribe
                var builder = new SubscribeOptionsBuilder();
                var machineName = System.Environment.MachineName;

                // Setup an application message handlers BEFORE subscribing to a topic
                client.OnMessageReceived += (sender, args) =>
                {
                    var overlay = screenDimmerMain.overlayWindows.Values.FirstOrDefault(o=> $"ScreenDimmer/{machineName}/{o.mqReference.cmd_t.Trim('~')}" == args.PublishMessage.Topic);

                    overlay.cbReference.InvokeIfRequired(() =>
                    {
                        overlay.cbReference.Checked = args.PublishMessage.PayloadAsString == MQTTService.HASwitchOn;
                    });
                };

                var HABase = "homeassistant";
                var AppBase = "ScreenDimmer";

                foreach (var scr in screenDimmerMain.overlayWindows.Values)
                {
                    var mqEntity = scr.mqReference;
                    builder.WithSubscription($"ScreenDimmer/{machineName}/{mqEntity.cmd_t.Trim('~')}", QualityOfService.ExactlyOnceDelivery, true);
                    var publishResult1 = await client.PublishAsync($"{HABase}/switch/{mqEntity.uniq_id}/config", JsonConvert.SerializeObject(mqEntity));
                }

                var subscribeOptions = builder.Build();
                var subscribeResult = await client.SubscribeAsync(subscribeOptions);

                foreach (var scr in screenDimmerMain.overlayWindows.Values)
                {
                    var mqEntity = scr.mqReference;
                    var publishResult3 = await client.PublishAsync($"ScreenDimmer/{machineName}/mqtt", "connected");
                }
            }
            catch (Exception ex)
            {

            }

        }


    }


    public class HAAvailability
    {
        public long _timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
        [JsonProperty(PropertyName = "~")]
        public string availability { get { return $"ScreenDimmer/{device.name}/"; } }
        public string avty_t { get; set; } = "~mqtt";
        public HADevice device { get; set; } = new HADevice();
        public string pl_avail { get; set; } = "connected";
        public string pl_not_avail { get; set; } = "disconnected";
        public string pl_off { get; set; } = MQTTService.HASwitchOff;
        public string pl_on { get; set; } = MQTTService.HASwitchOn;
        public string uniq_id { get { return $"{device.ids}_{name.ToUpper()}_ENABLED"; } }
        public string name { get; set; }
        public string stat_t { get { return $"~hassControl_{name.ToUpper()}/state"; } }
        public string cmd_t { get { return $"~hassControl_{name.ToUpper()}/state"; } }
        public string ha_sensor_type { get; set; } = "switch";
        public string ic { get; set; } = "mdi:monitor-arrow-down-variant";
    }


    public class HADevice
    {
        public string ids { get; set; } = "2f5657d7c0f803521444affd310e1494";
        public string name { get; set; } = Environment.MachineName;
        public string mf { get; set; } = "ScreenDimmer";
        public string mdl { get; set; } = "HomeAssistant Discovery for ScreenDimmer";
        public string sw { get; set; } = "HomeAssistant Discovery for ScreenDimmer";
    }
}
