using System.ComponentModel.DataAnnotations;

namespace DTO
{
    class Picture
    {
        [Key]
        public int IdPicture { get; set; }
        public string Url { get; set; }
        public virtual Room Room { get; set; }
    }
}
