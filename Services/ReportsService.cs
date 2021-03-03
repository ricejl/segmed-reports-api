using System.Collections.Generic;
using SegmedReportsApi.Models;
using SegmedReportsApi.Repositories;
using System.Linq;

namespace SegmedReportsApi.Services
{
    public class ReportsService
    {
        private readonly ReportsRepository _rr;
        public ReportsService(ReportsRepository rr)
        {
            _rr = rr;
        }

        public List<Report> Get()
        {
            return _rr.Reports;
        }

        public Report GetById(string id)
        {
            return _rr.Reports.First(r => r.Id == id);
        }
    }
}