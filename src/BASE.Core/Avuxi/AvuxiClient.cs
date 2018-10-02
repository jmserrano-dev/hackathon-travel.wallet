﻿using BASE.Core.Avuxi.Requests;
using BASE.Core.Avuxi.Respones;
using BASE.Cross;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BASE.Core.Avuxi
{
    public class AvuxiClient : ApiClient
    {
        private string AppKey = "5ba9f93132fac7089e1afd33|831c876386abb8e9d8965b64570a3078";

        private const string BaseAddress = "https://data.avuxiapis.com";

        public AvuxiClient() : base(BaseAddress) { }

        public GetNearbyInfoResponse GetNearbyInfo(GetNearbyInfoRequest request)
        {
            string uri = $"v1/GetNearbyInfo?key={AppKey}&latitude={request.Latitude}&longitude={request.Longitude}&Type={request.Type.Name}&language={request.Language}";

            var data = GetAsync<object>(uri).Result;
            var dic = JsonConvert.DeserializeObject<GetNearbyInfoResponse>(data.ToString());

            return dic;
        }

        public GetMetroLinesByCityCenterResponse GetMetroLinesByCityCenter(GetMetroLinesByCityCenterRequest request)
        {
            string uri = $"v1/GetMetroLinesByCityCenter?key={AppKey}&latitude={request.Latitude}&longitude={request.Longitude}";

            var data = GetAsync<object>(uri).Result;
            var result = JsonConvert.DeserializeObject<GetMetroLinesByCityCenterResponse>(data.ToString());

            return result;
        }
    }
}
