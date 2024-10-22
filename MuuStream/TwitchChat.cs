using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace MuuStream
{
    internal class TwitchChat : IDisposable
    {
        private TwitchClient _client;
        private bool disposedValue;

        public event Connected ConnectedEvent;
        public event MessageReceived MessageReceivedEvent;
        public event Error ErrorEvent;
        public event Log LogEvent;

        public delegate void Connected(string channel);
        public delegate void MessageReceived(ChatMessage message);
        public delegate void Error(string error);
        public delegate void Log(string log);

        public TwitchChat(Configuration configuration)
        {
            // Credentials
            var credentials = new ConnectionCredentials(configuration.Username, configuration.OAuthKey);
            var options = new ClientOptions
            {
                MessagesAllowedInPeriod = 750,
                ThrottlingPeriod = TimeSpan.FromSeconds(30)
            };

            // Initializing
            _client = new TwitchClient(new WebSocketClient(options));
            var channel = configuration.IsUsernameAsChannel ? configuration.Username : configuration.Channel;
            _client.Initialize(credentials, channel);

            // Events
            _client.OnLog += Client_OnLog;
            _client.OnJoinedChannel += Client_OnJoinedChannel;
            _client.OnMessageReceived += Client_OnMessageReceived;
            //_client.OnConnected += Client_OnConnected;
            _client.OnConnectionError += Client_OnConnectionError;
        }

        public void Connect()
            => _client.Connect();

        public void Disconnect()
            => _client.Disconnect();

        private void Client_OnConnectionError(object sender, OnConnectionErrorArgs e)
        {
            ErrorEvent?.Invoke(e.Error.Message);
        }

        private void Client_OnConnected(object sender, OnConnectedArgs e)
        {
            
        }

        private void Client_OnMessageReceived(object sender, OnMessageReceivedArgs e)
            => MessageReceivedEvent?.Invoke(e.ChatMessage);

        private void Client_OnJoinedChannel(object sender, OnJoinedChannelArgs e)
        {
            _client.SendMessage(e.Channel, "MuuStream has arrived! I'm watching you~!");
            ConnectedEvent?.Invoke(e.Channel);
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            LogEvent?.Invoke(e.Data);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _client.Disconnect();
                }

                _client = null;
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
