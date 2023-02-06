using TvCenterShow.Entities;
using TvCenterShow.Helpers;
using TvCenterShow.Logic;


namespace TvCenterShowUnit.Test
{
    public class TvShowUnitTest
    {
        #region HardCoded_MockData
        List<TelevisionShow> TvShowList = new List<TelevisionShow>();
        #endregion
        [Fact]
        public void TestListAllTvShowNotEmpty()
        {
           
            //Action
            var _TvShowList = TvShowLogic.ShowInitialListData();
            //Assert           
            Assert.NotEmpty(_TvShowList);

        }
        #region Testing Parameter "list"
        /// <summary>
        /// Test to Evaluate if the Void Method is returning Ok if the Type Input Parameter is "list"
        /// </summary>
        [Fact]
        public void TestListAllTvListShowOK()
        {
            //Arrange
            var result = string.Empty;
            var inputParam = "list";
            var resultMessage = "Bad Parameter, Please for this option type the Param:'list', remember the app is not accepting Capitalized Parameter";
            //Action
            if (inputParam == "list")
            {

                result = TvShowLogic.ShowInitialListData();
                //Assert
                Assert.NotEqual(result, resultMessage);

            }

        }

        #endregion

        #region Testing Parameter "favorites"

        /// <summary>
        /// Test to Evaluate if the Void Method is returning Ok if the Type Input Parameter is "favorites"
        /// </summary>
        [Fact]
        public void TestListAllTvFavoritesShowOK()
        {
            //Arrange
            var result = string.Empty;
            var inputParam = "favorites";
            var resultMessage = "Bad Parameter, Please for this option type the Param:'favorites, remember the app is not accepting Capitalized Parameter";
            //Action
            if (inputParam == "list")
            {

                result = TvShowLogic.FindTvShowByFavorites(inputParam);
                //Assert
                Assert.NotEqual(result, resultMessage);

            }

        }

        /// <summary>
        /// Test to Evaluate if the Void Method is returning Wrong if the Type Input Parameter is not "list", This test Should Fails
        /// </summary>
        [Fact]
        public void TestListAllTvFavoritesShowWrong()
        {
            //Arrage
            var result = string.Empty;
            var inputParam = "favorities";
            var resultMessage = "Bad Parameter, Please for this option type the Param:'favorites, remember the app is not accepting Capitalized Parameter";

            //Action
            result = TvShowLogic.FindTvShowByFavorites(inputParam);
            //Assert              
            Assert.Equal(resultMessage, result);
        }
        #endregion

        #region Testing Favorite Mark/UnMark 
        /// <summary>
        /// Evaluating if True result is converted to '*' as Favorite result as expected
        /// </summary>
        [Fact]
        public void TestMarkFavoriteShow()
        {
            //Arrage
            var idParam = 11;
            List<TelevisionShow> TvShowList = new List<TelevisionShow>
            {
                    new TelevisionShow {Id=11,Show="Alf Show",IsFavorite=false },                   
            };

            //Action
            var showFoundItem = TvShowList.Where(x => x.Id == idParam).DefaultIfEmpty().FirstOrDefault();
            showFoundItem.IsFavorite = true;
            var favoriteResult=GlobalHelper.setBoolToString(showFoundItem.IsFavorite);
            //Assert
            Assert.Equal("*", favoriteResult);

        }

        /// <summary>
        /// Evaluating if false result is not equal to '*' as Favorite result as expected
        /// </summary>

        [Fact]
        public void TestUnMarkFavoriteShow()
        {
            //Arrage
            var idParam = 11;
            List<TelevisionShow> TvShowList = new List<TelevisionShow>
            {
                    new TelevisionShow {Id=11,Show="Alf Show",IsFavorite=true },
            };

            //Action
            var showFoundItem = TvShowList.Where(x => x.Id == idParam).DefaultIfEmpty().FirstOrDefault();
            showFoundItem.IsFavorite = false;
            var favoriteResult = showFoundItem.IsFavorite;
            //Assert
            Assert.NotEqual("*", favoriteResult.ToString());

        }

        #endregion
    }
}