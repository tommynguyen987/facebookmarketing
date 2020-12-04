using Facebook;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
namespace FacebookMarketing
{
    public class Handler
    {
        #region Methods for handling evenst of Facebook
        private static string ApplicationId
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationId"];
            }
        }
        private static string ApplicationSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["ApplicationSecret"];
            }
        }
        private static string ExtendedPermissions
        {
            get
            {
                return ConfigurationManager.AppSettings["ExtendedPermissions"];
            }
        }
        public static string GetDefaultAccessToken()
        {
            try
            {
                bool isInternetConnected = true;
                do
                {
                    isInternetConnected = NetworkIsAvailable();
                } while (!isInternetConnected);

                FacebookClient client = new FacebookClient();
                dynamic result = client.Get("oauth/access_token", new
                {
                    client_id = ApplicationId,
                    client_secret = ApplicationSecret,
                    grant_type = "client_credentials"
                });
                return result.access_token;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return null;
            }
        }
        
        // Post a message on a current wall or a user group
        public static void PostFacebookWall(string accessToken, string message, string groupId, bool isMyself)
        {
            try
            {
                bool isInternetConnected = true;
                do
                {
                    isInternetConnected = NetworkIsAvailable();
                } while (!isInternetConnected);

                var objFacebookClient = new FacebookClient(accessToken);
                var parameters = new Dictionary<string, object>();
                parameters["message"] = message;

                if (isMyself)
                {
                    objFacebookClient.Post("/me/feed", parameters).ToString();
                }
                else
                {
                    objFacebookClient.Post(String.Format("/{0}/feed", groupId), parameters).ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Facebook Posting Error Message:" + System.Environment.NewLine + ex.Message);
            }
        }
        // Retrieve detail of current user
        public static int GetUserId(string accessToken)
        {
            var objFacebookClient = new FacebookClient(accessToken);
            dynamic parameters = new ExpandoObject();
            parameters.fields = new[] { "id" };
            dynamic result = objFacebookClient.Get("me", parameters);
            var userId = result.id;
            return (int)userId;
        }
        // Retrieve all user groups 
        public static string[,] GetGroupsList(string accessToken, int userId)
        {
            string[,] groups;
            var objFacebookClient = new FacebookClient(accessToken);
            dynamic group = objFacebookClient.Get("me/groups");
            int count = (int)group.data.Count;
            groups = new string[count, 2];
            for (int i = 0; i < count; i++)
            {
                groups[i, 0] = group.data[i].id;
                groups[i, 1] = group.data[i].name;
            }
            return groups;
        }
        // Retrieve all group members ids & names in 2D array 
        public static string[,] GetGroupMembersList(string accessToken, int groupId)
        {
            string[,] members;
            var objFacebookClient = new FacebookClient(accessToken);
            dynamic member = objFacebookClient.Get(String.Format("{0}/members", groupId));
            int count = (int)member.data.Count;
            members = new string[count, 2];
            for (int i = 0; i < count; i++)
            {
                members[i, 0] = member.data[i].id;
                members[i, 1] = member.data[i].name;
            }
            return members;
        }
        // Retrieve all user friends ids & names in 2D array 
        public static string[,] GetFriends(string accessToken)
        {
            string[,] friends;
            FacebookClient objFacebookClient = new FacebookClient(accessToken);
            dynamic friend = objFacebookClient.Get("me/friends");
            int count = (int)friend.data.Count;
            friends = new string[count, 2];
            for (int i = 0; i < count; i++)
            {
                friends[i, 0] = friend.data[i].id;
                friends[i, 1] = friend.data[i].name;
            }
            return friends;
        }
        // Check if Internet is connected?
        private static bool NetworkIsAvailable()
        {
            var all = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var item in all)
            {
                if (item.NetworkInterfaceType == NetworkInterfaceType.Loopback || item.NetworkInterfaceType == NetworkInterfaceType.Tunnel)
                    continue;
                //if (item.Name.ToLower().Contains("virtual") || item.Description.ToLower().Contains("virtual"))
                //    continue; //Exclude virtual networks set up by VMWare and others
                if (item.OperationalStatus == OperationalStatus.Up)
                {
                    return true;
                }
            }
            return false;
        }

        public string AccessToken = "AAAGaZC0b6PjkBAHVNXmyCneexbvKTXrGj3UNqqy5k8aOztVkh2ZADiGUMJeZB3ZASJvycPNPkK1mQIZAaE2gQkqokZA6pQNP6fwfNAPvX8WAZDZD";

        // Post a message
        public override string Post(string message, string pictureLink, string link)
        {
            if (string.IsNullOrEmpty(message)) return string.Empty;
            var url = "https://graph.facebook.com/me/feed";
            //.AppendQueryString("access_token", this.AccessToken)
            //.AppendQueryString("privacy", "{\"value\": \"EVERYONE\"}")
            //.AppendQueryString("message", message)
            //.AppendQueryString("picture", pictureLink)
            //.AppendQueryString("link", link);

            return CreateRequest(url, "POST");
        }
        public override string Delete(long PostId)
        {
            string url = "https://graph.facebook.com/" + PostId;
            //.AppendQueryString("access_token", this.AccessToken);
            return CreateRequest(url, "DELETE");
        }
        public static string CreateRequest(string url, string method)
        {
            HttpWebRequest webRequest = System.Net.WebRequest.Create(url) as HttpWebRequest;
            webRequest.Method = method;
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ServicePoint.Expect100Continue = false;
            webRequest.Timeout = 20000;

            Stream responseStream = null;
            StreamReader responseReader = null;
            string responseData = "";
            try
            {
                WebResponse webResponse = webRequest.GetResponse();
                responseStream = webResponse.GetResponseStream();
                responseReader = new StreamReader(responseStream);
                responseData = responseReader.ReadToEnd();
            }
            catch (Exception exc)
            {
                return string.Empty;
            }
            finally
            {
                if (responseStream != null)
                {
                    responseStream.Close();
                    responseReader.Close();
                }
            }

            return responseData;
        }

        #endregion
    }
}
