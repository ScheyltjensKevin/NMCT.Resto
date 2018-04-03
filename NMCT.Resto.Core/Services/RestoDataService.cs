using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Services
{
    public class RestoDataService : IRestoDataService
    {

        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IReviewRepository _reviewRepository;

        public RestoDataService(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            this._restaurantRepository = restaurantRepository;
            this._reviewRepository = reviewRepository;
        }


        public async Task<List<Restaurant>> GetRestaurant()
        {
            return await _restaurantRepository.GetRestaurants();
        }

        public async Task<List<Review>> GetReviews(Guid restoId)
        {
            return await _reviewRepository.GetReviews(restoId);
        }


        public async Task<Restaurant> GetRandomRestaurant()
        {
            List<Restaurant> listResto = await GetRestaurant();

            Random rnd = new Random();
            int randomNmbr = rnd.Next(0, listResto.Count - 1);

            return listResto[randomNmbr];
        }

        public async Task<Guid> AddReview(Guid restoId, Review review)
        {
           return await _reviewRepository.PostReview(restoId, review);
        }
    }
}
