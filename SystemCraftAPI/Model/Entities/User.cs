using System;
using System.ComponentModel.DataAnnotations;

using System.Collections.Generic;

namespace SystemCraftAPI.Model.Entities;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string LastName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; } = string.Empty;

    [Required]
    [StringLength(256)]
    public string Password { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<UserComputerFavorite> FavoriteComputers { get; set; } = new List<UserComputerFavorite>();
    public ICollection<UserLaptopFavorite> FavoriteLaptops { get; set; } = new List<UserLaptopFavorite>();
    public ICollection<UserMonitorFavorite> FavoriteMonitors { get; set; } = new List<UserMonitorFavorite>();
    public ICollection<UserHeadphonesFavorite> FavoriteHeadphones { get; set; } = new List<UserHeadphonesFavorite>();
}
