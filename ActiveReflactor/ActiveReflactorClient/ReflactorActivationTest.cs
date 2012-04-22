using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using ActiveReflactorClient.ActivationServiceReference;


namespace ActiveReflactorClient
{
    //<activationrequest> 
    //<version>3</version>
    //<machinehash>0DF8-01F1-42F5-78A3</machinehash>
    //<productcode>24</productcode>
    //<majorversion>7</majorversion>
    //<minorversion>0</minorversion>
    //<serialnumber>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</serialnumber>
    //<session>ecaf103a-f433-42fa-b035-2bf892ab8023</session>
    //<locale>en-US</locale>

    public class ActivationServiceClient
    {
        private string BuildActiveString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<activationrequest>");
            sb.Append("<version>3</version>");
            sb.Append("<machinehash>0DF8-01F1-42F5-78A3</machinehash>");
            sb.Append("<productcode>24</productcode>");
            sb.Append("<majorversion>7</majorversion>");
            sb.Append("<minorversion>0</minorversion>");
            sb.Append("<serialnumber>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</serialnumber>");
            sb.Append("<session>ecaf103a-f433-42fa-b035-2bf892ab8023</session>");
            sb.Append("<locale>en-US</locale>");
            sb.Append("/<activationrequest>");
            return sb.ToString();
        }
        private string BuildDeactiveString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<version>3</version>");
            sb.Append("<machinehash>0DF8-01F1-42F5-78A3</machinehash>");
            sb.Append("<productcode>24</productcode>");
            sb.Append("<majorversion>7</majorversion>");
            sb.Append("<minorversion>0</minorversion>");
            sb.Append("<serialnumber>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</serialnumber>");
            sb.Append("<session>ecaf103a-f433-42fa-b035-2bf892ab8023</session>");
            sb.Append("<locale>en-US</locale>");

            return sb.ToString();
        }
        public void Activate()
        {
            ActivationSoapClient client = new ActivationSoapClient();
            string request = BuildActiveString();
            string response = string.Empty;
            string error = string.Empty;
            client.ActivateLicence(HttpUtility.UrlEncode(request), out response, out error);
        }

        public void Deactivate()
        {
            ActivationSoapClient client = new ActivationSoapClient();
            string request = BuildDeactiveString();
            string error = string.Empty;
            client.DeactivateLicence(request, out error);
        }
    }
}