using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Umbraco.Core.Publishing
{
    /// <summary>
    /// The result of publishing a content item
    /// </summary>
    internal class PublishStatus
    {
        public IContent ContentItem { get; private set; }
        public PublishStatusType StatusType { get; internal set; }

        /// <summary>
        /// Gets sets the invalid properties if the status failed due to validation.
        /// </summary>
        public IEnumerable<Property> InvalidProperties { get; set; }

        public PublishStatus(IContent content, PublishStatusType statusType)
        {
            ContentItem = content;
            StatusType = statusType;
        }

        /// <summary>
        /// Creates a successful publish status
        /// </summary>
        public PublishStatus(IContent content)
            : this(content, PublishStatusType.Success)
        {            
        }

    }
}