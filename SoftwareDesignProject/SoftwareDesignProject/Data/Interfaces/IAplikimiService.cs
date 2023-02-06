using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Models;
using SoftwareDesignProject.Data.ViewModels;

namespace SoftwareDesignProject.Data.Interfaces
{
    public interface IAplikimiService
    {
        public Task AddAplikimi(IFormFile fileData, AplikimiVM aplikimi);
        public List<Aplikimi> GetAllAplikimet();
        public Aplikimi GetAplikimiById(int aplikimiId);
        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi);
        public Task<ActionResult> DeleteAplikimi(int id);

    }
}
