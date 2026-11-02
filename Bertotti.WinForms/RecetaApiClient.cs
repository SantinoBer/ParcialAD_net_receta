using System.Net.Http.Json;
using Bertotti.Domain;

namespace Perez.WinForm;

public class RecetaApiClient
{
    private static readonly HttpClient _http = new()
    {
        BaseAddress = new Uri("http://localhost:5220")
    };

    public async Task<List<Receta>> GetAsync(string? estado)
    {
        var url = string.IsNullOrWhiteSpace(estado)
            ? "api/recetas"
            : $"api/recetas?estado={Uri.EscapeDataString(estado)}";
        return await _http.GetFromJsonAsync<List<Receta>>(url) ?? new();
    }

    public async Task<List<string>> GetEstadosAsync()
        => await _http.GetFromJsonAsync<List<string>>("api/recetas/estados") ?? new();

    public async Task<List<string>> GetCoberturasAsync()
        => await _http.GetFromJsonAsync<List<string>>("api/recetas/coberturas") ?? new();

    public async Task CreateAsync(Receta receta)
    {
        var resp = await _http.PostAsJsonAsync("api/recetas", receta);
        await EnsureOkAsync(resp);
    }

    public async Task DispensarAsync(int id)
    {
        var resp = await _http.PutAsync($"api/recetas/{id}/dispensar", null);
        await EnsureOkAsync(resp);
    }

    private static async Task EnsureOkAsync(HttpResponseMessage resp)
    {
        if (resp.IsSuccessStatusCode) return;
        var msg = await resp.Content.ReadAsStringAsync();
        throw new InvalidOperationException(string.IsNullOrWhiteSpace(msg) ? resp.ReasonPhrase : msg);
    }
}