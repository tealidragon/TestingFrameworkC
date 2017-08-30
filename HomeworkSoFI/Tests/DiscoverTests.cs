using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.TMDb;
using System.Configuration;

namespace HomeworkSoFI
{
    [TestClass]
    public class DiscoverTests
    {
        static string apiKey = ConfigurationManager.AppSettings.Get("apiKey");
        ServiceClient client = new ServiceClient(apiKey);



        [TestInitialize]
        public void TestWork()
        {
            if (apiKey == null)
                throw new Exception("You have not entered an api Key");
        }


        /// <summary>
        /// Assert the movie result returned has movieId.
        /// </summary>
        [TestMethod]
        public void ValidateMovieIdIsAsExpected()
        {
            var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None);
            var results = discover.Result.Results;

            int movieId;
            foreach (Movie m in results)
            {
                movieId = m.Id;
                Assert.AreEqual(321612, movieId);
                break;
            }
        }

        /// <summary>
        /// Assert the movie result is withing the Year Provided.
        /// </summary>
        [TestMethod]
        public void ValidateMovieReleaseDateIsWithinTheYearProvided()
        {
            var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None);
            var results = discover.Result.Results;

            DateTime? movieReleaseDate;
            foreach (Movie m in results)
            {
                movieReleaseDate = m.ReleaseDate;
                Assert.IsTrue(movieReleaseDate.Value.Year >= DateTime.Now.Year);
                break;
            }

        }

        /// <summary>
        /// Assert the movie for 1st movie result is as expected.
        /// </summary>
        [TestMethod]
        public void ValidateMovieTitleIsAsExpected()
        {
            var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None);
            var results = discover.Result.Results;

            string movieTitle;
            foreach (Movie m in results)
            {
                movieTitle = m.Title;
                Assert.AreEqual("Beauty and the Beast", m.Title);
                break;
            }
        }

        /// <summary>
        /// Assert the Movie title is not null or empty.
        /// </summary>
        [TestMethod]
        public void ValidateMovieTitleIsNotNull()
        {
            var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None).Result.Results;

            string movieTitle;
            foreach (Movie m in discover)
            {
                movieTitle = m.Title;
                Assert.IsNotNull(m.Title);
                break;
            }
        }

        /// <summary>
        /// Assert the Discover API returns only results that are not 'Adult'.
        /// </summary>
        [TestMethod]
        public void ValidateAdultMoviesAreNotReturned()
        {

            //TODO test include Adult false

            //Discover movies that are not 'Adult' by passing in false for includeAdult parameter.

            //Validate each result 'Adult' param is false.

            //Need to test this to ensure kid friendly results are returned, and so parent's won't get mad.

            throw new NotImplementedException();
        }

        /// <summary>
        /// Assert that all results have a voter average equal to or greater than the 70% threshold.
        /// </summary>
        [TestMethod]
        public void ValidateResultsReturnOnlyMoviesWithVoteAverageAbove70PercentThreshold()
        {
            //TODO test region

            //Discover movies that are above the 70% threshold. Pass in a decimal for voter average

            //Validate for each result the voter average is 70% or greater.

            //Need to test this to ensure that we are only recommending movies that are discovered to have a 70% or better voting average. Our users want to be able to trust that a recommended is really as good as we think it is.

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ValidateOverviewExistsAndContainsKeyword()
        {
            //TODO test overview contains keyword

            //Discover movies

            //Validate that there is an overview-description of the movie

            //Validate if there is a keyword within the overview description

            //This test is an exploratory-like test to make sure the overview description summarizes the movie we are expection to find. An action movie should have action in the overview. --Note this could be a fragile- or one-off tests that we use to verify that overview has meaning.

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ValidateOriginalLanguageIsUsersLanguage(string userLanguage = "de-DE")
        {
            //TODO test user local language discovers movies local to them.

            //Discover movies with a different userLanguage

            //Validate Original language is userlanguage.

            //This could be useful to verify localization of the APIs. Users with different locales should discover tests local to them, unless specified for other language.

            throw new NotImplementedException();
        }

        /// <summary>
        /// Assert the user can create a request token.
        /// </summary>
        [TestMethod]
        public void ValidateMovieHasGenreIds()
        {
            //TODO test movie has Genres

            //We want to make sure that our users can process movies by category and genre is the best way to do this. 

            //Make sure the returned movie as at least one genreId.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Assert that only movies with number of votes greater than 100 are discovered.
        /// </summary>
        [TestMethod]
        public void ValidateOnlyMoviesWithNumberOfVoteGreaterThan100AreDiscovered()
        {
            //TODO test movies with a vote_count equal to or greater than 100 are discovered

            //Discover tests with vote count set to 100

            //Assert each returned result is as expected to be 100 vote_count or greater.

            //We want to make sure that we are disovering movies that have some repertoire within the community.

            throw new NotImplementedException();
        }

        /// <summary>
        /// Assert that The Movie Database doesn't have record of movies that will release 10 years from now.
        /// </summary>
        [TestMethod]
        public void Validate10YearsInTheFutureDoesNotReturnMovies()
        {
            //TODO test language input

            //Discover tests with a Year that is set 10 years in the future

            //We don't expect the database to have record of movies that will release 10 years from now

            //Assert that no results are returned.

            //We want to make sure that we aren't try to be clairvoyant and bog down are system by keeping results that could change, and aren't set in stone.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Assert that The Movie Database discovers movies releaseing the next year.
        /// </summary>
        [TestMethod]
        public void ValidateFutureYearReleasesWithin1YearsAreReturned()
        {
            //TODO test region

            //Discover tests with Year+1 

            //Assert that results are returned.

            //Need to make sure that we can see what is coming up in the next year so that our users can look forward to movies they have been hoping to see
            throw new NotImplementedException();
        }

    }
}
