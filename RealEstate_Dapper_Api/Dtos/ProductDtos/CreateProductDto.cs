﻿namespace RealEstate_Dapper_Api.Dtos.ProductDtos
{
    public class CreateProductDto
    {
       
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public int ProductCategory { get; set; }
        public string Adress { get; set; }
    }
}
