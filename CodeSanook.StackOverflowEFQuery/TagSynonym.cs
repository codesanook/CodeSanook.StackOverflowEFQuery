namespace CodeSanook.StackOverflowEFQuery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TagSynonym
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(35)]
        public string SourceTagName { get; set; }

        [StringLength(35)]
        public string TargetTagName { get; set; }

        public DateTime CreationDate { get; set; }

        public int OwnerUserId { get; set; }

        public int AutoRenameCount { get; set; }

        public DateTime? LastAutoRename { get; set; }

        public int Score { get; set; }

        public int? ApprovedByUserId { get; set; }

        public DateTime? ApprovalDate { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
