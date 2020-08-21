﻿using Caliburn.Micro;
using Mqtt_MonitoringApp.Helpers;
using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Mqtt_MonitoringApp.ViewModels
{
    public class DataBaseViewModel : Conductor<object>
    {
        #region 속성영역
        string brokerUrl;
        public string BrokerUrl
        {
            get => brokerUrl;
            set
            {
                brokerUrl = value;
                NotifyOfPropertyChange(() => BrokerUrl);
            }
        }

        string topic;
        public string Topic
        {
            get => topic;
            set
            {
                topic = value;
                NotifyOfPropertyChange(() => Topic);
            }
        }

        string connString;
        public string ConnString
        {
            get => connString;
            set
            {
                connString = value;
                NotifyOfPropertyChange(() => ConnString);
            }
        }

        string dbLog;
        public string DbLog
        {
            get => dbLog;
            set
            {
                dbLog = value;
                NotifyOfPropertyChange(() => DbLog);
            }
        }

        bool isConnected;
        public bool IsConnected
        {
            get => isConnected;
            set
            {
                isConnected = value;
                NotifyOfPropertyChange(() => IsConnected);
            }
        }
        #endregion

        public DataBaseViewModel()
        {
            BrokerUrl = Commons.BROKERHOST;
            Topic = Commons.PUB_TOPIC;
            Commons.CONNSTRING = ConnString = "Server=localhost;Port=3306;Database=iot_sensordata;Uid=root;Pwd=mysql_p@ssw0rd";
        }

        public void Connect()
        {
            

            if(IsConnected) // 토글버튼 ON
            {
                Commons.BROKERCLIENT = new MqttClient(BrokerUrl);
                Commons.BROKERCLIENT.MqttMsgPublishReceived += BROKERCLIENT_MqttMsgPublishReceived;
                try
                {
                    if(Commons.BROKERCLIENT.IsConnected != true)
                    {
                        Commons.BROKERCLIENT.Connect("MqttMonitor");
                        Commons.BROKERCLIENT.Subscribe(new string[] { Topic },
                            new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                        UpdateText(">>> Message : Broker Connected");
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else // 토글버튼 OFF
            {
                try
                {
                    if(Commons.BROKERCLIENT.IsConnected)
                    {
                        Commons.BROKERCLIENT.Disconnect();
                        Commons.BROKERCLIENT.MqttMsgPublishReceived -= BROKERCLIENT_MqttMsgPublishReceived;
                        UpdateText(">>> Message : Broker Disconnected...");
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void BROKERCLIENT_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            UpdateText($">>> Message : {message}");
            InsertDatabase(message);
        }

        private void InsertDatabase(string message)
        {
            //TODO
        }

        private void UpdateText(string message)
        {
            DbLog += $"{message}\n";
        }
    }
}
