using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Operations
{
    /// <summary>
    /// This class handles the downloading of WebSite Data
    /// </summary>
    public class Downloader
    {
        List<DataModel> results = new List<DataModel>();
        WebClient _client;
        string[] sites;
        long totalduration;
        /// <summary>
        /// Constructs a Downloader Object
        /// </summary>
        /// <param name="sites"> The List of sites to obtain the data from</param>
        public Downloader(string[] sites, string mode)
        {
            _client = new WebClient();
            this.sites = sites;
            switch (mode.ToLower())
            {
                case "sync":
                    DoDowloadSync();
                    break;
                case "async":
                    DoDownloadAsync().Wait();
                    break;
                default:
                    break;
            }

        }

        private void DoDowloadSync() {
            Console.WriteLine("Doing task Synchronously");
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            foreach (var item in sites)
{
                this.Results.Add(DownloadWebsiteData(item));
            }
            timer.Stop();
            this.Totalduration = timer.ElapsedMilliseconds;
        }

        private async Task DoDownloadAsync() {
            Task<DataModel>[] tasks = { }; 
            Console.WriteLine("Doing task Asynchronously");
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            foreach (var item in sites)
            {
                DataModel result = await Task.Run(() => DownloadWebsiteData(item));
                this.Results.Add(result);
            }
            timer.Stop();
            this.Totalduration = timer.ElapsedMilliseconds;
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public List<DataModel> Results { get => results; set => results = value; }
        public long Totalduration { get => totalduration; private set => totalduration = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private DataModel DownloadWebsiteData(string url) {
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            string results = _client.DownloadString(url);
            //string results = await _client.DownloadStringAsync(new Uri(new UriBuilder(url)));
            timer.Stop();
            return new DataModel(url,results,timer.ElapsedMilliseconds );

           
        }

    }
}
