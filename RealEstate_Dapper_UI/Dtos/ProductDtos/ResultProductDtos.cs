namespace RealEstate_Dapper_UI.Dtos.ProductDtos
{
    public class ResultProductDtos
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price {  get; set; }
        public string City{ get; set; } 
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string Coverimage { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string CategoryName { get; set; }

        //public bool DealOfTheDay {  get; set; }


    }
}
