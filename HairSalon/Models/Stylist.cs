using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    [Required(ErrorMessage = "Stylist name is required.")]
    public string StylistName { get; set; }
    [Required(ErrorMessage = "Stylist specialty is required.")]
    public string Specialty { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}