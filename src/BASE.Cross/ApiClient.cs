using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace BASE.Cross
{

    public abstract class ApiClient
    {
        static readonly JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new JsonConverter[] { new StringEnumConverter() }
        };

        protected ApiClient(string baseAddress, HttpMessageHandler handler = null, string token = null)
        {
            Client = handler == null ? new HttpClient() : new HttpClient(handler);
            Client.BaseAddress = new Uri(baseAddress);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (token != null)
            {
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
            }
        }

        protected async Task<T> GetAsync<T>(string uri) => await ParseJson<T>(await Client.GetAsync(uri));

        protected async Task<T> PostAsync<T>(string uri, object data = null) => await ParseJson<T>(await Client.PostAsync(uri, JsonContent.From(data)));

        protected async Task<T> AuthenticationPostAsync<T>(string uri, object data = null)
        {
            var dataEncoded = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>{});

            if (data != null)
            {
                dataEncoded = new FormUrlEncodedContent(data.ToKeyValue());
            }

            return await ParseJson<T>(await Client.PostAsync(uri, dataEncoded));
        }

        protected HttpClient Client { get; }

        async Task<T> ParseJson<T>(HttpResponseMessage response) => JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), Settings);

        class JsonContent : StringContent
        {
            public static JsonContent From(object data) => data == null ? null : new JsonContent(data);

            public JsonContent(object data) : base(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
            {
            }
        }
    }
}