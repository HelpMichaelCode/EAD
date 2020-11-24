using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise5;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise5.Tests
{
    [TestClass()]
    public class RadioPlayerAppTests
    {
        // TestMethod_Scenario_ExpectedResult
        [TestMethod()]
        public void Like_UserLikesStation_StationAddedToFavouriteLists()
        {
            // Arrange
            RadioPlayerApp radioPlayer;

            // Act
            radioPlayer = new RadioPlayerApp("My Radio Player");
            radioPlayer.Like("Newstalk");

            // Assert
            Assert.IsTrue(radioPlayer.FavouriteStations.Any(s => s.RStation == "Newstalk"));
        }

        [TestMethod()]
        public void IndexerGenreContent_ReturnSpecificCollectionsOfStationGenre_CollectionsOfGenreReturned()
        {
            // Arrange
            RadioPlayerApp radioPlayer = new RadioPlayerApp("My Radio Player");

            // Act

            // Assert
            CollectionAssert.AreEqual(radioPlayer[RadioContent.Music], radioPlayer.stations.FindAll(s => s.Content == RadioContent.Music).OrderByDescending(f => f.Freqeuncy).ToList());
        }
    }
}