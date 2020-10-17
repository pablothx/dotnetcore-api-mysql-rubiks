using System;
using System.ComponentModel.DataAnnotations;

namespace Rubiks.Models
{
    public class TrackingSolution
    {
        [Key]
        public int TrackingSolutionId { get; set; }
        public RubikCube Rubik { get; set; }
        public DateTime ResolutionDate { get; set; }
        public int ResolutionFinishedSeconds { get; set; }
    }
}