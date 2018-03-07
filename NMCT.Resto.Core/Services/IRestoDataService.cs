using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Services
{
    public interface IRestoDataService
    {
        Task<List<Restaurant>> GetRestaurant();
        Task<Restaurant> GetRandomRestaurant();
        Task<List<Review>> GetReviews();
        Task<bool> AddReview(Guid restoId, Review review);
    }
}
