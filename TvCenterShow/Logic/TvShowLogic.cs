using System.Text;
using TvCenterShow.Entities;
using TvCenterShow.Helpers;


namespace TvCenterShow.Logic
{
    public  static class TvShowLogic
    {
    
        #region HardCoded_Data
        private static  List<TelevisionShow> TvShowList = new List<TelevisionShow>
        {
                new TelevisionShow {Id=11,Show="Alf Show",IsFavorite=false },
                new TelevisionShow {Id=22,Show="Mc Giver",IsFavorite=false },
                new TelevisionShow {Id=13,Show="Kenan & Kel ",IsFavorite=false },
                new TelevisionShow {Id=44,Show="The Simpson",IsFavorite=false },
                new TelevisionShow {Id=55,Show="The wonderful Years",IsFavorite=false },
                new TelevisionShow {Id=76,Show="The X Files",IsFavorite=false },
                new TelevisionShow {Id=70,Show="Saved by The Bell",IsFavorite=false },
                new TelevisionShow {Id=98,Show="Mazinger Z",IsFavorite=false },
                new TelevisionShow {Id=89,Show="America's Most Wanted",IsFavorite=false },
                new TelevisionShow {Id=10,Show="Flash",IsFavorite=false }
        };
        #endregion
        /// <summary>
        /// Show a Iitial List only for the unit Testing
        /// </summary>
        /// <returns></returns>
        public static string ShowInitialListData()
        {
            var result = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();           
            foreach (var showOrderItem in TvShowList.OrderBy(x => x.Show))
            {
                stringBuilder.AppendLine($"{showOrderItem.Id}   {showOrderItem.Show}   {GlobalHelper.setBoolToString(showOrderItem.IsFavorite)}");
                result = stringBuilder.ToString();
            }
            return result;
        }
        /// <summary>
        /// Find a Tv Show By Id, use a Integer Param
        /// </summary>
        /// <param name="idShow"></param>
        /// <returns></returns>
        public static TelevisionShow FindTvShowById(int idShow)
        {
            var showFoundItem = TvShowList.Find(x=> x.Id== idShow);
            if(showFoundItem != null)
            {
                showFoundItem.IsFavorite = !showFoundItem.IsFavorite;               
            }            
            return showFoundItem;
        }
       

        /// <summary>
        /// Show all the List of the favorites TV show typing "favorites" as Parameter
        /// </summary>
        /// <param name="inPutParam"></param>
        /// <returns></returns>
        public static string FindTvShowByFavorites(string inPutParam)
        {
            var result = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
           foreach (var showOrderItem in TvShowList.Where(x => x.IsFavorite == true).OrderBy(x => x.Show))
           {
                stringBuilder.AppendLine($"{showOrderItem.Id}   {showOrderItem.Show}   {GlobalHelper.setBoolToString(showOrderItem.IsFavorite)}");
                result = stringBuilder.ToString();
           }           
           return result;
        }
    }
}
