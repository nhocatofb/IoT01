using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO.Ports;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WpfApp2.API
{
    public static class ApiHelper
    {
        private const string _serverDomain = "mqtt.iotwithus.com";
        private const int _port = 1883;
        private static string requestMessage;
        public static MqttClient mqttClient = new MqttClient(_serverDomain, _port, false, null, null, MqttSslProtocols.None);


        public static void InitializeClient()
        {
            mqttClient.MqttMsgPublishReceived += client_recievedMessage;

            string clientId = Guid.NewGuid().ToString();

            mqttClient.Connect(clientId);
        }
        public static void RequestMessage(string message)
        {
            requestMessage = message;
        }

        public static void PublicMessage()
        {
            mqttClient.Publish("iot/control", Encoding.UTF8.GetBytes(requestMessage), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }
        public static void SubscribeMessages()
        {
            Console.WriteLine("Sub: ");

            mqttClient.Subscribe(new string[] { requestMessage }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });

        }

        static void client_recievedMessage(object sender, MqttMsgPublishEventArgs e)
        {
            var message = System.Text.Encoding.Default.GetString(e.Message);
            System.Console.WriteLine("Message reiceved: " + message);
        }
    }
}
