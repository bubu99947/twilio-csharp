/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Lookups.V1 
{

    /// <summary>
    /// FetchPhoneNumberOptions
    /// </summary>
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// The phone number to fetch in E.164 format
        /// </summary>
        public Types.PhoneNumber PathPhoneNumber { get; }
        /// <summary>
        /// The ISO country code of the phone number
        /// </summary>
        public string CountryCode { get; set; }
        /// <summary>
        /// The type of information to return
        /// </summary>
        public List<string> Type { get; set; }
        /// <summary>
        /// The unique_name of an Add-on you would like to invoke
        /// </summary>
        public List<string> AddOns { get; set; }
        /// <summary>
        /// Data specific to the add-on you would like to invoke
        /// </summary>
        public Dictionary<string, object> AddOnsData { get; set; }

        /// <summary>
        /// Construct a new FetchPhoneNumberOptions
        /// </summary>
        /// <param name="pathPhoneNumber"> The phone number to fetch in E.164 format </param>
        public FetchPhoneNumberOptions(Types.PhoneNumber pathPhoneNumber)
        {
            PathPhoneNumber = pathPhoneNumber;
            Type = new List<string>();
            AddOns = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CountryCode != null)
            {
                p.Add(new KeyValuePair<string, string>("CountryCode", CountryCode));
            }

            if (Type != null)
            {
                p.AddRange(Type.Select(prop => new KeyValuePair<string, string>("Type", prop)));
            }

            if (AddOns != null)
            {
                p.AddRange(AddOns.Select(prop => new KeyValuePair<string, string>("AddOns", prop)));
            }

            if (AddOnsData != null)
            {
                p.AddRange(PrefixedCollapsibleMap.Serialize(AddOnsData, "AddOns"));
            }

            return p;
        }
    }

}