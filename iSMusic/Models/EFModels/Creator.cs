namespace iSMusic.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Creator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Creator()
        {
            Albums = new HashSet<Album>();
            CreatorFollows = new HashSet<CreatorFollow>();
            Song_Creator_Metadata = new HashSet<Song_Creator_Metadata>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string creatorName { get; set; }

        public byte creatorGender { get; set; }

        [Required]
        [StringLength(500)]
        public string creatorAbout { get; set; }

        public int memberId { get; set; }

        [Required]
        [StringLength(100)]
        public string creatorPicPath { get; set; }

        [StringLength(100)]
        public string creatorCoverPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Album> Albums { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CreatorFollow> CreatorFollows { get; set; }

        public virtual Member Member { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Song_Creator_Metadata> Song_Creator_Metadata { get; set; }
    }
}
