namespace AspNetWebApi_Northwind.DTOs
{
    public class CategoryUpdateDTO
    {
         public int Id { get; set; }
        public string Ad { get; set; } = null!;

        public string? Aciklama { get; set; }
    }
}
