using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;


namespace Final.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Final.Models.FinalContext _context;


        public IndexModel(Final.Models.FinalContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 8;
        public string CurrentFilter { get; set; }


        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;} = string.Empty;
        public SelectList SortList {get; set;} = default!;

        public async Task OnGetAsync(string searchString)
        {
            Game = await _context.Games
                .Include(g => g.User).ToListAsync();
            
            if (_context.Games != null)
            {
                var query = _context.Games.Select(g => g);

                
                List<SelectListItem> sortItems = new List<SelectListItem> {
                    new SelectListItem { Text = "Title Ascending", Value = "title_asc" },
                    new SelectListItem { Text = "Title Descending", Value = "title_desc"},
                    new SelectListItem { Text = "Developer Ascending", Value = "dev_asc" },
                    new SelectListItem { Text = "Developer Descending", Value = "dev_desc"},
                    new SelectListItem { Text = "Genre Ascending", Value = "genre_asc" },
                    new SelectListItem { Text = "Genre Descending", Value = "genre_desc"},
                    new SelectListItem { Text = "Price Ascending", Value = "price_asc" },
                    new SelectListItem { Text = "Price Descending", Value = "price_desc"},
                    new SelectListItem { Text = "Owned Ascending", Value = "owned_asc" },
                    new SelectListItem { Text = "Owned Descending", Value = "owned_desc"},
                };

                SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

                switch (CurrentSort)
                {
                    case "title_asc": 
                        query = query.OrderBy(g => g.Title);
                    break;
                    case "title_desc":
                        query = query.OrderByDescending(g => g.Title);
                    break;
                    case "dev_desc":
                        query = query.OrderByDescending(g => g.Developer);
                    break;
                    case "dev_asc": 
                        query = query.OrderBy(g => g.Developer);
                    break;
                    case "genre_desc":
                        query = query.OrderByDescending(g => g.Genre);
                    break;
                    case "genre_asc": 
                        query = query.OrderBy(g => g.Genre);
                    break;
                    case "price_desc":
                        query = query.OrderByDescending(g => g.Price);
                    break;
                    case "price_asc": 
                        query = query.OrderBy(g => g.Price);
                    break;
                    case "owned_desc":
                        query = query.OrderByDescending(g => g.UserId);
                    break;
                    case "owned_asc": 
                        query = query.OrderBy(g => g.UserId);
                    break;
                }

                Game = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();

                CurrentFilter = searchString;
        
                IQueryable<Game> games = from g in _context.Games
                                        select g;
                    games = games.Where(g => g.Title.Contains(searchString)
                    || g.Developer.Contains(searchString)
                    || g.Genre.Contains(searchString));

            }
        }  
    }
}

