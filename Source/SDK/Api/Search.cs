//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    public class Search : PayPalSerializableObject
    {
        /// <summary>
        /// Initial letters of the email address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "email")]
        public string email { get; set; }

        /// <summary>
        /// Initial letters of the recipient's first name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_first_name")]
        public string recipient_first_name { get; set; }

        /// <summary>
        /// Initial letters of the recipient's last name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_last_name")]
        public string recipient_last_name { get; set; }

        /// <summary>
        /// Initial letters of the recipient's business name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_business_name")]
        public string recipient_business_name { get; set; }

        /// <summary>
        /// The invoice number that appears on the invoice.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "number")]
        public string number { get; set; }

        /// <summary>
        /// Status of the invoice.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status")]
        public string status { get; set; }

        /// <summary>
        /// Lower limit of total amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lower_total_amount")]
        public Currency lower_total_amount { get; set; }

        /// <summary>
        /// Upper limit of total amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upper_total_amount")]
        public Currency upper_total_amount { get; set; }

        /// <summary>
        /// Start invoice date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_invoice_date")]
        public string start_invoice_date { get; set; }

        /// <summary>
        /// End invoice date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_invoice_date")]
        public string end_invoice_date { get; set; }

        /// <summary>
        /// Start invoice due date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_due_date")]
        public string start_due_date { get; set; }

        /// <summary>
        /// End invoice due date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_due_date")]
        public string end_due_date { get; set; }

        /// <summary>
        /// Start invoice payment date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_payment_date")]
        public string start_payment_date { get; set; }

        /// <summary>
        /// End invoice payment date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_payment_date")]
        public string end_payment_date { get; set; }

        /// <summary>
        /// Start invoice creation date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "start_creation_date")]
        public string start_creation_date { get; set; }

        /// <summary>
        /// End invoice creation date. Date format yyyy-MM-dd z, as defined in [ISO8601](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "end_creation_date")]
        public string end_creation_date { get; set; }

        /// <summary>
        /// Offset of the search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "page")]
        public float page { get; set; }

        /// <summary>
        /// Page size of the search results.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "page_size")]
        public float page_size { get; set; }

        /// <summary>
        /// A flag indicating whether total count is required in the response.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "total_count_required")]
        public bool? total_count_required { get; set; }
    }
}
