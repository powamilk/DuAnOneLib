namespace DuAnOne.DAL.Entities
{
    public partial class TacGia
    {
        public TacGia()
        {
            TacGiaSaches = new HashSet<TacGiaSach>();
        }

        public Guid Id { get; set; }
        public string TenTacGia { get; set; } = null!;
        public int? QuocTich { get; set; }
        public int Status { get; set; }
        public Guid CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? ModifyBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public Guid? DeleteBy { get; set; }
        public DateTime? DeleteTime { get; set; }

        public virtual ICollection<TacGiaSach> TacGiaSaches { get; set; }
    }
}
