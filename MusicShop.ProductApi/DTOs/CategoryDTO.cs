﻿namespace MusicShop.ProductApi.DTOs;
public class CategoryDTO {
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "The Name is Required")]
    [MinLength(1)]
    [MaxLength(100)]
    public string? Name { get; set; }
    public ICollection<Product>? Products { get; set; }
}
