using System;
using System.Net.Http;
using System.Threading.Tasks;
using RestSharp;

namespace Soti.Training.Batch2.Operations
{
    /// <summary>
    /// This is the User Operations available for the Petstore API implementation
    /// </summary>
    public class UserOperations
    {
        /// <summary>
        /// Creates anew set of users from the provided data in an Array
        /// </summary>
        /// <param name="url"> This is the URL Endpoint for the Petstore</param>
        /// <param name="headers"> This should have the Content Type and Other needed Headers</param>
        /// <param name="body">The actual details of the Uers data passed as a JSOn Array</param>
       public void  createUsersFromArrayInput(string url, string[] headers, string body) {

        // How to make a HTTP Request
        //HttpClient client = new HttpClient();
        //HttpResponseMessage response = await client.GetAsync(url);
        //var client = new RestClient(;


    }

    }
}
