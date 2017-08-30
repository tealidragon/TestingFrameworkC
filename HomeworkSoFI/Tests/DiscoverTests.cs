using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.TMDb;

namespace HomeworkSoFI
{
    [TestClass]
    public class DiscoverTests
    {
        private const string apiKey = "1a03c1afdb5e6e0cc3c88dc5ae95a23b";
        private static ServiceClient client = new ServiceClient(apiKey);
        private static Movie movie = new Movie();

        /// <summary>
        /// Assert the movie result returned has movieId.
        /// </summary>
        [TestMethod]
        public void ValidateMovieIdIsAsExpected()
        {
            try
            {

                //
                if (apiKey != null)
                {
                    //Test
                    //TODO test movieId
                    DateTime date = new DateTime(2017, 03, 16);
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
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Assert the movie result is withing the Year Provided.
        /// </summary>
        [TestMethod]
        public void ValidateMovieReleaseDateIsWithinTheYearProvided()
        {
            if (apiKey != null)
            {
                DateTime date = new DateTime(2017, 03, 16);
                var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None);
                var results = discover.Result.Results;

                DateTime? moiveReleaseDate;
                foreach (Movie m in results)
                {
                    moiveReleaseDate = m.ReleaseDate;
                    Assert.IsTrue(moiveReleaseDate.Value.Year >= DateTime.Now.Year);
                    break;
                }
            }

        }

        /// <summary>
        /// Assert the movie for 1st movie result is as expected.
        /// </summary>
        [TestMethod]
        public void ValidateMovieTitleIsAsExpected()
        {
            if (apiKey != null)
            {
                //TODO test language input
                DateTime date = new DateTime(2017, 03, 16);
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

        }

        /// <summary>
        /// Assert the Movie title is not null or empty.
        /// </summary>
        [TestMethod]
        public void ValidateMovieTitleIsNotNull()
        {
            if (apiKey != null)
            {
                //TODO test region
                DateTime date = new DateTime(2017, 03, 16);
                var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None);
                var results = discover.Result.Results;

                string movieTitle;
                foreach (Movie m in results)
                {
                    movieTitle = m.Title;
                    Assert.IsNotNull(m.Title);
                    break;
                }
            }


        }

        /// <summary>
        /// Assert the Discover API returns only results that are not 'Adult'.
        /// </summary>
        [TestMethod]
        public void ValidateAdultMoviesAreNotReturned()
        {
            if (apiKey != null)
            {
                //TODO test include Adult false

                //Discover movies that are not 'Adult' by passing in false for includeAdult parameter.

                //Validate each result 'Adult' param is false.

                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Assert that all results have a voter average equal to or greater than the 70% threshold.
        /// </summary>
        [TestMethod]
        public void ValidateResultsReturnOnlyMoviesWithVoteAverageAbove70PercentThreshold()
        {
            if (apiKey != null)
            {
                //TODO test region

                //Discover movies that are above the 70% threshold. Pass in a decimal for voter average

                //Validate for each result the voter average is 70% or greater.

                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ValidateOverviewExistsAndContainsKeyword()
        {
            if (apiKey != null)
            {
                //TODO test overview contains keyword

                //Discover movies

                //Validate that there is an overview-description of the movie

                //Validate if there is a keywork within the overview description

                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ValidateOriginalLanguageIsUsersLanguage(string userLanguage = "de-DE")
        {
            if (apiKey != null)
            {
                //TODO test region

                //Discover movies with a different userLanguage

                //Validate Original language is userlanguage.

                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Assert the user can create a request token.
        /// </summary>
        [TestMethod]
        public void ValidateMovieHasGenreIds()
        {
            if (apiKey != null)
            {
                //TODO test language input
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Assert that only movies with number of votes greater than 100 are discovered.
        /// </summary>
        [TestMethod]
        public void ValidateOnlyMoviesWithNumberOfVoteGreaterThan100AreDiscovered()
        {
            if (apiKey != null)
            {
                //TODO test movies with a vote_count equal to or greater than 100 are discovered

                //Discover tests with vote count set to 100

                //Assert each returned result is as expected to be 100 vote_count or greater.

                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// Assert that The Movie Database doesn't have record of movies that will release 10 years from now.
        /// </summary>
        [TestMethod]
        public void Validate10YearsInTheFutureDoesNotReturnMovies()
        {
            if (apiKey != null)
            {
                //TODO test language input

                //Discover tests with a Year that is set 10 years in the future

                //We don't expect the database to have record of movies that will release 10 years from now


                //Assert that no results are returned.
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Assert that The Movie Database discovers movies releaseing the next year.
        /// </summary>
        [TestMethod]
        public void ValidateFutureYearReleasesWithin1YearsAreReturned()
        {
            if (apiKey != null)
            {
                //TODO test region

                //Discover tests with Year+1 

                //Assert that results are returned.
                throw new NotImplementedException();
            }
        }

    }
}
