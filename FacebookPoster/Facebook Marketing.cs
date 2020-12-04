using System;
using System.Linq;
using System.Net;
using System.Threading;
using MetroFramework.Forms;
using System.Web;

namespace FacebookMarketing
{
    public partial class frmFacebookMarketing : MetroForm
    {
        public frmFacebookMarketing()
        {
            InitializeComponent();
            //StartUpManager.AddApplicationToCurrentUserStartup("Facebook Marketing");
        }
        const string appId = "1189892814386135";

        // fConnector
        // AppId: 738635072905530
        // AppSecrect: 2dbabf15bd3c28c23d9e7d8feab67974
        // AppCode: 738635072905530|nfgegf5fkGvK6tbyFPharNama-c
        // AccessToken: EAAKfyOEjoToBAPj3fgMHDpFWp4hZAFy2dt5qIsJcYZABNszZAk5I5MvxPSVeL3MJBVGtMZCtTqeX0NnR1s3mWoJE9c8uVIIoPlrhoD4BAUE5LIz652SvhTFuEZCBBPGZAskWGtCtCTZCYb2DeOtKIBnCwWS8w1kw3nuRv9DpP0mvQn5cZAnnqGTI

        // Graph API Explorer
        // AccessToken: EAACEdEose0cBAMY0ycjO1vQTuI6ccn8WmGVObyV36fvImUdo0jMXbJdFvZBXfHEjoszUs1U2cXHA7VYR2yGSjtS7DwPNihzJogYb31Wgmx85SqVlI4zzwu4WawZCAurhhPJZB3EV08RYTe0Bc6Ft44SeI2h2ZApWszcmjV1b1TmXZBaAtmraDblyIk74QBj8ZD

        // Fanpage Săn Khuyến Mãi         
        // AccessToken:  EAACEdEose0cBAIGdSLdEsg5SbooCiXaLTI5GwooMogMLoGOOJBLlZBFM2HLFqVMTzDoWuT8HuGXA1RasinBA12aARstZCSUV8CHbAf9xaxBlCFoG1XYNBQnZCGDsAbsZBUwUwj07cGZCnLkfqSsfK6nXIC05G4JKueMhl3qMRqrXZBhz3DWcx2DTuDHtcPhJEZD
        
        const string appSecret = "7429f97f408f2bd200ce47dda60e9aee";
        string[] groupIdList = { "444944158885936", "708602325818069", "531320553698591" };
        static string accessToken = "EAAQ6M4KFs9cBAHCoT1ZAwqZBelR3DFkUZCKbHfTlUZCk0kh4kIQpm4zGdA01SAMMcp2P0wLPOh0P7AfWaQR0uzwvUFM1FGOev3xZCS0vTJnfYuFXZCa8zZAEXV6kbNvELksoJS1l14UAJiYYSZCZCZBUlZAzk4vGZCz1a60FFjZCfBDKgvyrQe620uyDf";
           
        private void frmFacebookPoster_Load(object sender, EventArgs e)
        {
            string message = "This is testing post my wall";
            accessToken = Handler.GetDefaultAccessToken();
            Handler.PostFacebookWall(accessToken, message, "", true);
        }
        private void PostGroups(string message)
        {
            foreach (var groupId in groupIdList)
            {
                Handler.PostFacebookWall(accessToken, message, groupId, false);
                Thread.Sleep(15 * 60 * 1000);                
            }            
        }        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 9)
            { 
            }
        }        
    }
}
