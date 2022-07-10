using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json;

public class PokemonController : Controller
    {
        private readonly HttpClient _httpClient;
        public PokemonController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("pokeapi");
        }
        public async Task<IActionResult> Index(string page)
        {
            string route = $"pokemon?page={page ?? "1"}";
            HttpResponseMessage response = await _httpClient.GetAsync(route);

            var responseString = await response.Content.ReadAsStringAsync();
            var pokemon = JsonSerializer.Deserialize<ResultsViewModel<PokemonViewModel>>(responseString);
            return View(pokemon);
        }
    }
