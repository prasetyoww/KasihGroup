namespace PendaftaranPasien.Models.Domain
{
    public class Pasien
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string JenisPasien { get; set; }

        public string MetodePembayaran { get; set; }

        public string poli { get; set; }
        public string Dokter { get; set; }


        public string Kelamin { get; set; }
        public long Telpon { get; set; }
        public string Agama { get; set; }

    }
}
