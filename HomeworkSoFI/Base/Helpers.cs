using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.TMDb;

namespace HomeworkSoFI.Base
{
    public static class Helpers
    {
        private const string apiKey = "1a03c1afdb5e6e0cc3c88dc5ae95a23b";
        private static ServiceClient client = new ServiceClient(apiKey);

        #region GET

        //internal Movies DiscoveryListOfMovies()
        //{
        //    try
        //    {
        //        var discover = client.Movies.DiscoverAsync("en-US", false, 2017, null, null, null, null, null, "", 1, System.Threading.CancellationToken.None).Result;
        //        return discover;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        #endregion

    }
}
