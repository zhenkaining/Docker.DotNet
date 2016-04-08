using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    [DataContract]
    public class CommitContainerChangesParameters // (types.ContainerCommitOptions)
    {
        [QueryStringParameter("container", true)]
        public string ContainerID { get; set; }

        [QueryStringParameter("repo", false)]
        public string RepositoryName { get; set; }

        [QueryStringParameter("tag", false)]
        public string Tag { get; set; }

        [QueryStringParameter("comment", false)]
        public string Comment { get; set; }

        [QueryStringParameter("author", false)]
        public string Author { get; set; }

        [QueryStringParameter("changes", false)]
        public IList<string> Changes { get; set; }

        [QueryStringParameter("pause", false, typeof(BoolQueryStringConverter))]
        public bool? Pause { get; set; }

        [DataMember(Name = "Config")]
        public Config Config { get; set; }
    }
}
