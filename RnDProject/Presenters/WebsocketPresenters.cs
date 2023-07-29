using RnDProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RnDProject.Views;
using WebSocketSharp;

namespace RnDProject.Presenters
{
    public class WebsocketPresenters
    {
        WebsocketView websocketiew;

        public WebsocketPresenters(WebsocketView view)
        {
            websocketiew = view;
        }

        public void ConnectToSocket()
        {

            WebSocket ws = new WebSocket("wss://socketsbay.com/wss/v2/1/demo/");
            ws.Connect();
            ws.Send("hallo ini testing dari wpf");
            ws.OnMessage += Ws_OnMessage;

        }

        private void Ws_OnMessage(object? sender, MessageEventArgs e)
        {
            var responseContent = System.Text.Json.JsonSerializer.Serialize(e.Data);


            System.Diagnostics.Debug.WriteLine("Connect Success: " + responseContent);
            Console.WriteLine(responseContent);
            websocketiew.DataWebsocketText = responseContent; 
        }
    }
}
