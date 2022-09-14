using Site_anime.Model.Dto;

namespace Site_anime.Service
{
    public class ReviewService
    {
        public ReviewService()
        {

        }

        public List<ReviewDto> FindAllReviews()
        {            
            return SimulateList();
        }
        private List<ReviewDto> SimulateList()
        {
            List<ReviewDto> list = new List<ReviewDto>();

            list.Add(new()
            {
                Anime = "Sword Art Online",
                Content = "The story of the first season follows the adventures of Kazuto \"Kirito\" Kirigaya and Asuna Yuuki, two players who are trapped in the virtual world of \"Sword Art Online\" (SAO). They are tasked to clear all 100 Floors and defeat the final boss in order to be freed from the game.",
                Image = "https://img.comunidades.net/dig/digitalnews/5fe886f3daa6485efecf1ea6dc5207931343265548_full.jpg"
            });

            return list;
        };
    }
}
