namespace Soti.Training.Batch2.Operations
{
    /// <summary>
    /// 
    /// </summary>
    public class DataModel
    {
        string site;
        string DataResults;
        long duration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="site"></param>
        /// <param name="result"></param>
        public DataModel(string site, string result)
        {
            this.Site = site;
            this.DataResults1 = result;
        }

        public DataModel(string site, string result, long elapsedMilliseconds) : this(site, result)
        {
            this.Duration = elapsedMilliseconds;
        }

        /// <summary>
        /// Get the site associated to  this data
        /// </summary>
        public string Site { get => site; set => site = value; }
        /// <summary>
        /// Gets the resulting data 
        /// </summary>
        public string DataResults1 { get => DataResults; set => DataResults = value; }
        public long Duration { get => duration; set => duration = value; }
    }
}