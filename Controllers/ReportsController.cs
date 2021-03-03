using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SegmedReportsApi.Models;
using SegmedReportsApi.Services;

namespace SegmedReportsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        private readonly ReportsService _rs;
        public ReportsController(ReportsService rs)
        {
            _rs = rs;
        }

        [HttpGet]
        public List<Report> Get()
        {
            return _rs.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Report GetById(string id)
        {
            return _rs.GetById(id);
        }
    }
}