using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTI2_eAutosalloni.ViewModels
{
    public class VehicleViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public int CategoryId { get; set; }
        public SelectListItem Category { get; set; }
        public int BrandId { get; set; }
        public SelectListItem Brand { get; set; }
        public string Description { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public string TransmissionType { get; set; }
        public DateTime Year { get; set; }
        public double Price { get; set; }
        public int Bought { get; set; }
        public int Quantity { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}
