using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Api.Requests;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using WebApplication1.ApiModel;

namespace WebApplication1.Api
{
    public class AllegroApi:IApi
    {
        public RestClient RestClient { get; set; }
        private ILogger<AllegroApi> Logger;
        public bool IsInternetConnected { get; set; } = true;

        public AllegroApi(ILoggerFactory loggerFactory)
        {
            Logger = loggerFactory.CreateLogger<AllegroApi>();
        }

        private async Task<T1> SendAsync<T1, T2>(T2 content) where T2 : Request
        {
            try
            {
                if (content == null)
                    throw new ArgumentException("wiadomosc jest null");
                RestClient = new RestClient(content.Url);
                RestClient.Timeout = 5000;
                var request = new RestRequest(content.RequestUrl);
                request.Method = content.RequestType;
                request.RequestFormat = DataFormat.Json;
                if (content.Payload != null)
                {
                    request.AddJsonBody(content.Payload);
                }
                foreach (var item in content.HeaderParameters)
                {
                    request.AddHeader(item.Key, item.Value);
                }
                Logger.LogInformation($"Wysyłanie zapytania: {content.GetType()}");
                if (content.ShowContentInLog)
                {
                    if (request.Method != Method.GET)
                        Logger.LogInformation($"Wysyłanie obiektu: {JsonConvert.SerializeObject(content.Payload)}");
                    else
                        Logger.LogInformation($"Wysyłanie obiektu: {content.Url}");
                }

                var response = await RestClient.ExecuteTaskAsync(request);
                if (response.ErrorException == null && response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var serializedResponse = JsonConvert.DeserializeObject<T1>(response.Content);
                    if (content.ShowContentInLog)
                        Logger.LogInformation($"Otzymano odpowiedz: {response.Content}");
                    IsInternetConnected = true;
                    return serializedResponse;
                }
                else
                {
                    var message = "Błąd pobierania danych, sprawdz połączenie";
                    if (response.StatusCode == 0)
                        IsInternetConnected = false;
                    throw new ApplicationException(message + response.Content ?? string.Empty, response.ErrorException);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, ex.Message);
                return default(T1);
            }
        }

        public async Task<Token> Login(RequestLogin requestLogin)
        {
            return await SendAsync<Token, RequestLogin>(requestLogin);
        }

        public async Task<ListingResponse> Offers(RequestOffers requestOffers)
        {
            return await SendAsync<ListingResponse, RequestOffers>(requestOffers);
        }
    }
}
