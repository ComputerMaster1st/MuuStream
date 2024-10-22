using TwitchLib.Client.Models;

namespace MuuStream
{
    public partial class Main : Form
    {
        private readonly Configuration _config;
        private TwitchChat _chat;

        public delegate void ThreadsafeUI<TControl>(TControl ctrl, Action<TControl> action) where TControl : Control;

        public Main()
        {
            InitializeComponent();

            _config = Configuration.Load();

            if (_config != null)
            {
                if (!string.IsNullOrEmpty(_config.Username))
                {
                    txtUsername.Enabled = false;
                    txtUsername.Text = _config.Username;
                }

                if (!string.IsNullOrEmpty(_config.Channel))
                {
                    txtChannel.Enabled = false;
                    txtChannel.Text = _config.Channel;
                }
                else if (_config.IsUsernameAsChannel)
                {
                    txtChannel.Enabled = false;
                    txtChannel.Text = _config.Username;
                    cbxChannelAsUsername.Enabled = false;
                    cbxChannelAsUsername.Enabled = _config.IsUsernameAsChannel;
                }

                if (!string.IsNullOrEmpty(_config.OAuthKey))
                {
                    txtOAuth.Enabled = false;
                    txtOAuth.Text = _config.OAuthKey;
                }
            }
        }

        public void InvokeThreadSafeUI<TControl>(TControl ctrl, Action<TControl> action) where TControl : Control
        {
            if (ctrl.InvokeRequired)
            {
                var del = new ThreadsafeUI<TControl>(InvokeThreadSafeUI);
                ctrl.Invoke(del, ctrl, action);
            }
            else
                action(ctrl);
        }

        private void Chat_Connected(string e)
        {
            WriteToConsole("<SYSTEM>", e);

            InvokeThreadSafeUI(btnApply, (x) => { x.Enabled = false; });
            InvokeThreadSafeUI(btnConnect, (x) => { x.Enabled = false; });
            InvokeThreadSafeUI(btnReset, (x) => { x.Enabled = true; });
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            _chat = new TwitchChat(_config);
            _chat.ConnectedEvent += Chat_Connected;
            _chat.MessageReceivedEvent += Chat_MessageReceived;
            //_chat.LogEvent += Chat_Log;

            _chat.Connect();
        }

        private void Chat_Log(string log)
            => WriteToConsole("<SYSTEM>", log);

        private void Chat_MessageReceived(ChatMessage e)
            => WriteToConsole(e.Username, e.Message);

        private void BtnReset_Click(object sender, EventArgs e)
        {
            _chat.Disconnect();
            _chat.Dispose();

            btnApply.Enabled = true;
            btnConnect.Enabled = true;
            cbxChannelAsUsername.Enabled = true;
            btnReset.Enabled = false;
        }

        private void WriteToConsole(string from, string message)
            => InvokeThreadSafeUI(lbxChat, (x) =>
            { 
                x.Items.Add(string.Format("{0}: {1}", from, message));

                var index = x.Items.Count <= 1 ? 0 : x.Items.Count - 1;
                x.SelectedIndex = index;
            });

        private void BtnApply_Click(object sender, EventArgs e)
        {
            _config.Channel = txtChannel.Text;
            _config.Username = txtUsername.Text;
            _config.OAuthKey = txtOAuth.Text;
            _config.IsUsernameAsChannel = cbxChannelAsUsername.Checked;

            _config.Save();
        }
    }
}
