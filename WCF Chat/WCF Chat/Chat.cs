namespace WCF_Chat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Chat")]
    [DataContract]
    public partial class Chat
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Content { get; set; }

        [DataMember]
        [StringLength(100)]
        public string UserName { get; set; }

        [DataMember]
        public DateTime? SentTime { get; set; }

        [DataMember]
        public virtual User User { get; set; }
    }
}
