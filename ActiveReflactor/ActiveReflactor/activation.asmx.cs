using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Text.RegularExpressions;

namespace ActiveReflactor
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://red-gate.com/webservices/ActivationServer")]
    public class Activation : System.Web.Services.WebService
    {
        [WebMethod]
        public bool DeactivateLicence(string deactivationRequest, out string errorMessage)
        {
            errorMessage = "good!";
            return true;
        }

        [WebMethod]
        public bool ActivateLicence(string activationRequest, out string activationResponse, out string errorMessage)
        {
            string sn = GetSNFromRequest(activationRequest);
            string session = GetSNFromRequest(activationRequest);

            activationResponse = this.BuildActivationResponse(sn, session);
            errorMessage = "No error";
            return true;
        }

        /// <summary>
        /// SN format: <serialnumber>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</serialnumber>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetSNFromRequest(string request)
        {
            string pattern = @"<serialnumber>([\w-]+)</serialnumber>";

            return ExtractString(request, pattern);
        }
        /// <summary>
        /// Request format: <session>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</session>
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetSessionFromRequest(string request)
        {
            string pattern = @"<session>([\w-]+)</session>";

            return ExtractString(request, pattern);
        }

        /// <summary>
        /// Extract sn and session strings from the request
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private string ExtractString(string source, string pattern)
        {
            Regex regex = new Regex(pattern);

            string result = string.Empty;
            if (regex.IsMatch(source))
            {
                Match match = regex.Match(source);
                result = match.Groups[1].Value;
            }
            return result;
        }

        private string BuildActivationResponse(string sn, string session)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<activationresponse>");
            sb.Append("<data>");
            sb.Append("<machinehash>0DF8-01F1-42F5-78A3</machinehash>");
            sb.Append("<productcode>24</productcode>");
            sb.Append("<majorversion>7</majorversion>");
            sb.Append("<minorversion>0</minorversion>");
            sb.AppendFormat("<serialnumber>{0}</serialnumber>", sn);
            sb.AppendFormat("<session>{0}</session>", session);
            sb.Append("<edition>Standard</edition>");
            sb.Append("<version>3</version>");
            sb.Append("<userspurchased>1</userspurchased>");
            sb.Append("</data>");
            sb.Append("<signature>jrTeXmkXX4eSwXcpjGIt+XXoP1SMGenCa5Jnk6PUXxTLu1OlJY3apG4Brd5Dz3mRLorjU8qt5ziyujMzBUapyZkSxx6yBruYbK9F6YJKfiB2D7FnyN5mPXS4R4UVqQu5sCFUKtuDr0hJVUV/KVABIZ22DSMRAYi0mYAb2GXnjGk=</signature>");
            sb.Append("</activationresponse>");
            return sb.ToString();
        }

        private string BuildActivationResponse()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<activationresponse>");
            sb.Append("<data>");
            sb.Append("<machinehash>0DF8-01F1-42F5-78A3</machinehash>");
            sb.Append("<productcode>24</productcode>");
            sb.Append("<majorversion>7</majorversion>");
            sb.Append("<minorversion>0</minorversion>");
            sb.Append("<serialnumber>A3KE-ABCD-ABCD-ABCD-ABCD-ABCD</serialnumber>");
            sb.Append("<session>9b9231ba-dd4f-42c0-a836-e517f6b0cae6</session>");
            sb.Append("<edition>Standard</edition>");
            sb.Append("<version>3</version>");
            sb.Append("<userspurchased>1</userspurchased>");
            sb.Append("</data>");
            sb.Append("<signature>jrTeXmkXX4eSwXcpjGIt+XXoP1SMGenCa5Jnk6PUXxTLu1OlJY3apG4Brd5Dz3mRLorjU8qt5ziyujMzBUapyZkSxx6yBruYbK9F6YJKfiB2D7FnyN5mPXS4R4UVqQu5sCFUKtuDr0hJVUV/KVABIZ22DSMRAYi0mYAb2GXnjGk=</signature>");
            sb.Append("</activationresponse>");
            return sb.ToString();
        }
    }
}
