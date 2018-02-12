using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O365Mobile.Models
{
    public class ResourceVisualization
    {
        public string title { get; set; }
        public string type { get; set; }
        public string mediaType { get; set; }
        public string previewImageUrl { get; set; }
        public string previewText { get; set; }
        public string containerWebUrl { get; set; }
        public string containerDisplayName { get; set; }
        public string containerType { get; set; }

    }
}
