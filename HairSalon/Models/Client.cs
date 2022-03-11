using System;
//using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    [Required(ErrorMessage = "Client name is required.")]
    public string ClientName { get; set; }
    [StringLength(10)]
    public string ContactInfo { get; set; }

    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}