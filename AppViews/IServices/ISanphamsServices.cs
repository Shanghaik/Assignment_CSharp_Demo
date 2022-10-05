using Data.DbContexts;
using Data.ModelsClass;
using Data.Repositories.Interfaces;

namespace Assignment_CSharp_Demo_API.IServices
{
    public interface ISanphamsServices
    {

        public Task<IEnumerable<Sanpham>> GetAllSanPham();
        public Task<Sanpham> GetSanPhamByID(Guid id);
        public  Task<IEnumerable<Sanpham>> SearchSanphamByTen(string name);

        public Task<IEnumerable<Sanpham>> SearchSanphamKhoangGia(long min, long max);


        public bool AddNewSanpham(Sanpham sanpham);

        public bool AddListSanpham(IEnumerable<Sanpham> sanphams);

        public bool UpdateSanpham(Sanpham sanpham);
        public bool UpdateManySanpham(IEnumerable<Sanpham> sanphams);


        public bool DeleteSanpham(Guid id);
        public bool DeleteNhieuSanpham(IEnumerable<Sanpham> sanphams);
    }
}
