using Site_anime.Model.Dto;
using Site_anime.Service;

namespace Site_anime.Shared
{
	public partial class CardReview
	{
		public List<ReviewDto> Reviews { get; set; }

		private ReviewService _service;

		public CardReview()
		{
			_service = new();

			Reviews = _service.FindAllReviews();
		}
	}
}
