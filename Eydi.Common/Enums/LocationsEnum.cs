using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Common.Enums
{
    public enum TankLocation
    {
        [Description("Main floor")]
        MainFloor,
        [Description("Basement")]
        Basement,
        [Description("Attic")]
        Attic,
        [Description("Crawl space")]
        CrawlSpace,
        [Description("Garage")]
        Garage,
        [Description("Porch")]
        Porch,
        [Description("Outside")]
        Outside,
    }
    public enum ColdAirLocation
    {
        [Description("Basement")]
        Basement,
        [Description("Crawl space")]
        CrawlSpace,
        [Description("Attic")]
        Attic,
        [Description("Main floor")]
        MainFloor
    }
    public enum WallLocation
    {
        [Description("House")]
        House,
    }
    public enum FlueLocation
    {
        [Description("Interior")]
        Interior,
        [Description("Main Exterior")]
        Exterior
    }
}
