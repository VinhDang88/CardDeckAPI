using Newtonsoft.Json;
using System.Net;

namespace DeckOfCardsAPI.Models
{
    public class CardsDAL
    {


        public CardsModel GetCards() //adjust method signature
        {
            //Adjust
            //api url
            //string key = "n54uqexwak5v";
            //string key = "16dbfbc819459d7b007daf280088e57c";
            string url = $"https://deckofcardsapi.com/api/deck/n54uqexwak5v/draw/?count=5";

            //setup request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //save response data
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust
            //Convert JSON to a c# object
            CardsModel result = JsonConvert.DeserializeObject<CardsModel>(JSON);
            return result;

        }

        public void ShuffleCards()
        {
            //string url = $"https://deckofcardsapi.com/api/deck/gd1xv1k43de9/shuffle/";
            string url = $"https://deckofcardsapi.com/api/deck/n54uqexwak5v/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }





    }
}
