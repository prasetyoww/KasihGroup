using Microsoft.AspNetCore.Mvc;
using PendaftaranPasien.Data;
using PendaftaranPasien.Models;
using PendaftaranPasien.Models.Domain;

namespace PendaftaranPasien.Controllers
{
    public class PasiensController : Controller
    {
        private readonly MVCDbContext mvcDbContext;

        public PasiensController(MVCDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddPasienViewModel addPasienRequest)
        {
            var pasien = new Pasien()
            {
                Id = Guid.NewGuid(),
                Name = addPasienRequest.Name,
                Kelamin = addPasienRequest.Kelamin,
                Telpon = addPasienRequest.Telpon,
                Agama = addPasienRequest.Agama,
                poli = addPasienRequest.poli,
                JenisPasien = addPasienRequest.JenisPasien,
                Dokter = addPasienRequest.Dokter,
                MetodePembayaran = addPasienRequest.MetodePembayaran
            };

            await mvcDbContext.Pasiens.AddAsync(pasien);
            await mvcDbContext.SaveChangesAsync();

            TempData["Message"] = "Data berhasil disimpan.";

            return RedirectToAction("Add");
        }

    }
}
