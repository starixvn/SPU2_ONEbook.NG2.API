using System;
using EasyNetQ;
using Fanex.Module.Logs.Services;
using ONEbook.NG2.API.Configuration;

namespace ONEbook.NG2.API.Utils
{
    internal static class ApiRabbitMQ<T> where T : class
    {
        public static bool NotifyFailedRequest(T request)
        {
            try
            {
                var config = NG2Configuration.Instance;
                object req = object.ReferenceEquals(null, request) ? Activator.CreateInstance(typeof(T)) : request;
                var bus = RabbitHutch.CreateBus(
                    string.Format(
                        "host={0};virtualHost={1};username={2};password={3};requestedHeartbeat={4}", 
                        config.RabbitHost, 
                        config.RabbitName, 
                        config.RabbitUid, 
                        config.RabbitPwd, 
                        config.RabbitTimeout));

                bus.Publish(req, config.RabbitTopic);

                return true;
            }
            catch (Exception ex)
            {
                ex.Write();

                return false;
            }
        }
    }
}
