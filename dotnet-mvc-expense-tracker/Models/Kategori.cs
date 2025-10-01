namespace dotnet_mvc_expense_tracker.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Deskripsi { get; set; }
        public string Tipe { get; set; } 
        public bool IsActive { get; set; }
        public string Status 
        { 
            get 
            {
                return IsActive ? "Aktif" : "Tidak Aktif";
            }
        }
    }
}
