using HealthWatch360.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using static HealthWatch360.Models.Library;

namespace HealthWatch360.Pages
{
    public class BooksMindliftModel : PageModel
    {
        public string SearchQuery { get; set; }
        public List<Book> BookResults { get; private set; } = new List<Book>();
        public static List<string> Authors { get; private set; } = new List<string>();

        public async Task OnGetAsync(string searchQuery)
        {

            await FetchBooks(searchQuery);


        }

        private async Task FetchBooks(string searchQuery)
        {
            var apiUrl = "https://mindlift20241130171555.azurewebsites.net/api/reviews";

            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse);

                    // Populate the authors list
                    Authors = bookList.Select(b => b.AuthorName).Distinct().ToList();

                    // Filter books based on the search query (if provided)
                    if (!string.IsNullOrWhiteSpace(searchQuery))
                    {
                        searchQuery = searchQuery.ToLower();
                        BookResults = bookList.Where(b =>
                            b.BookTitle.ToLower().Contains(searchQuery))
                            .ToList();
                    }
                    else
                    {
                        BookResults = bookList;
                    }
                }
                else
                {
                    // Handle the case where the API call fails
                    BookResults = new List<Book>();
                }
            }
        }
    }
}
