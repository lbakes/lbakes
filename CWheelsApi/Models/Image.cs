using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CWheelsApi.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int VehicleId { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
    }
}
