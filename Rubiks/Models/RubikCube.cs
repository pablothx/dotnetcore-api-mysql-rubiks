using System.ComponentModel.DataAnnotations;

namespace Rubiks.Models
{
    public class RubikCube
    {
        [Key]
        public int RubikId { get; set; }
        public string Name { get; set; }
        public int Sides { get; set; }
        public string Complexity { get; set; }
        public string Description { get; set; }
    }

}