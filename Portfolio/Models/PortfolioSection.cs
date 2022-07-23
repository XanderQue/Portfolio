using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    /**
     * This Model will be used to add and remove sections
     * of my portfolio. I can for example replace all the 
     * current HTML with a for each loop that runs through 
     * a list of predefined sections.
     *
     */
    public class PortfolioSection
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
