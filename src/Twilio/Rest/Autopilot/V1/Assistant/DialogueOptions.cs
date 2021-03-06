/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchDialogueOptions
    /// </summary>
    public class FetchDialogueOptions : IOptions<DialogueResource> 
    {
        /// <summary>
        /// The assistant_sid
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchDialogueOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The assistant_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchDialogueOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}