using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Opentok.Standard.Sample
{
    public class OpentokSessionManager
    {
    //    <add key = "OTKey" value="46440112" />
    //<add key = "OTSecret" value="433e0d1e0fc6d247ac3ee6c5bbb9021212a8fb57" />
        private readonly string key = "46440112";
        private readonly string secret = "433e0d1e0fc6d247ac3ee6c5bbb9021212a8fb57";

        public string Token { get; set; }
        public string SessionId { get; set; }
        public OpentokSessionManager()
        {
            //this.key = key;
            //this.secret = secret;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }

        public async Task GetTokenAsync()
        {
            await Task.Run(() =>
            {
                int apiKey = Convert.ToInt32(this.key);
                OpenTokSDK.OpenTok opentok = new OpenTokSDK.OpenTok(apiKey, this.secret);
                OpenTokSDK.Session opentoksession = opentok.CreateSession(mediaMode: OpenTokSDK.MediaMode.ROUTED, archiveMode: OpenTokSDK.ArchiveMode.MANUAL);
                Token = opentoksession.GenerateToken(role: OpenTokSDK.Role.PUBLISHER);
                SessionId = opentoksession.Id;
            });
        }

    }
}
