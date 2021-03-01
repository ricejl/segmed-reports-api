using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SegmedReportsApi.Models;

namespace SegmedReportsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        [HttpGet]
        public List<Report> Get()
        {
            return new List<Report> {
                new Report {
                    Title = "Hospital Sketches",
                    Headline = "\"I want something to do.\"",
                    Text = "This remark being addressed to the world in general, no one in particular felt it their duty to reply; so I repeated it to the smaller world about me, received the following suggestions, and settled the matter by answering my own inquiry, as people are apt to do when very much in earnest.",
                    Tags = new List<string>(),
                    Uri = "https://www.gutenberg.org/files/3837/3837-0.txt",
                    Author = "Louisa May Alcott",
                    Id = "1"
                },
                new Report {
                    Title = "Merck's 1899 Manual",
                    Headline = "MERCK'S MANUAL is designed to meet a need which every general practitioner has often experienced.",
                    Text = "Memory is treacherous.",
                    Tags = new List<string>(),
                    Uri = "https://www.gutenberg.org/cache/epub/41697/pg41697.txt",
                    Author = "Merck & Co.",
                    Id = "2"
                },
                new Report {
                    Title = "The Medicinal Plants of the Philippines",
                    Headline = "Commissioned by His Majesty's Government to study the medicinal plants of my native country",
                    Text = "I returned there and spent two years in collecting data regarding the use that the Filipinos make of their plants in the treatment of disease. At the same time I collected and carefully preserved some with the purpose of taking them to Europe, to study their chemical composition in the laboratories of Paris under the direction of the eminent men who had been my instructors in medicine.",
                    Tags = new List<string>(),
                    Uri = "https://www.gutenberg.org/cache/epub/26393/pg26393.txt",
                    Author = "T. H. Pardo de Tavera",
                    Id = "3"
                }
            };
        }
    }
}