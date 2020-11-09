﻿
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Huobi.SDK.Core.LinearSwap.RESTful.Response.Market
{
    public class GetRiskInfoResponse
    {
        public string status { get; set; }

        [JsonProperty("err-code", NullValueHandling = NullValueHandling.Ignore)]
        public string errorCode { get; set; }

        [JsonProperty("err-msg", NullValueHandling = NullValueHandling.Ignore)]
        public string errorMessage { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<Data> data { get; set; }

        public long ts { get; set; }

        public class Data
        {
            [JsonProperty("estimated_clawback")]
            public double estimatedClawback { get; set; }

            [JsonProperty("insurance_fund")]
            public double insuranceFund { get; set; }

            [JsonProperty("contract_code")]
            public string contractCode { get; set; }
            
        }
    }
}
