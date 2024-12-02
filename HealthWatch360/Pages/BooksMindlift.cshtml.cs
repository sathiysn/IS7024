using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Linq;
using static HealthWatch360.Models.Library;

namespace HealthWatch360.Pages
{
    public class BooksMindliftModel : PageModel
    {
        private static readonly HttpClient client = new HttpClient();

        [BindProperty(SupportsGet = true)]
        public string SearchQuery { get; set; } = string.Empty;

        public List<Book> Books { get; set; } = new List<Book>();

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrWhiteSpace(SearchQuery))
            {
                string url = $"https://openlibrary.org/search.json?q={Uri.EscapeDataString(SearchQuery)}";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse JSON response
                    JObject jsonResponse = JObject.Parse(responseBody);
                    var docs = jsonResponse["docs"];

                    if (docs != null)
                    {
                        foreach (var book in docs.Take(10)) // Display top 10 results
                        {
                            Books.Add(new Book
                            {
                                Title = book["title"]?.ToString() ?? "N/A",
                                Author = book["author_name"] != null ? string.Join(", ", book["author_name"].ToObject<string[]>()) : "N/A",
                                ISBN = book["isbn"] != null && book["isbn"].HasValues ? book["isbn"].First.ToString() : "N/A",
                                PublishYear = book["first_publish_year"]?.ToString() ?? "N/A"
                            });
                        }
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                }
            }
        }
    }
}
