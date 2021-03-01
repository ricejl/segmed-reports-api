using System.Collections.Generic;

namespace SegmedReportsApi.Models
{
    public class Report
    {
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Text { get; set; }
        public string Uri { get; set; }
        public string Author { get; set; }
        public string Id { get; set; }
        public List<string> Tags { get; set; }
    }


}