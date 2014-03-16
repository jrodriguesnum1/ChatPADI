﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLib;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using System.Collections;

namespace ChatServer
{
    class Server
    {
        static void Main(string[] args)
        {
            TcpChannel channelServ = (TcpChannel)TcpChannelGenerator.GetChannel(Constants.SERVICE_SERV_PORT, true);
            ChannelServices.RegisterChannel(channelServ, true);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ChatServer), Constants.REMOTE_SERV_OBJ_NAME, WellKnownObjectMode.Singleton);

            TcpChannel channelClt = new TcpChannel();
            ChannelServices.RegisterChannel(channelClt, true);

            Console.WriteLine("Press <enter> to exit");
            Console.ReadLine();
        }
    }

    public class ChatServer : MarshalByRefObject, IChatServer
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public void Join(string nickname, string url)
        {
            this.users.Add(nickname, url);
        }

        public void SendMsgToServer(string nickname, string msg)
        {
            List<string> markedToRemove = new List<string>();

            foreach (KeyValuePair<string, string> userPair in users)
            {
                if (!userPair.Key.Equals(nickname))
                {
                    try
                    {
                        IChatClient client = (IChatClient)Activator.GetObject(typeof(IChatClient), userPair.Value);
                        client.SendMsgToClient(nickname, msg);
                    }
                    catch (Exception)
                    {
                        markedToRemove.Add(userPair.Key);
                    }
                }
            }

            foreach (string nick in markedToRemove)
            {
                users.Remove(nick);
            }
        }
    }
}
