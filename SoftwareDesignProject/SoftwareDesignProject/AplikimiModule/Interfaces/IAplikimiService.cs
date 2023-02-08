using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.AplikimiModule.Models;
using SoftwareDesignProject.AplikimiModule.ViewModels;

namespace SoftwareDesignProject.AplikimiModule.Interfaces
{
    public interface IAplikimiService
    {
        public void AddAplikimi(AplikimiVM aplikimi);
        public List<Aplikimi> GetAllAplikimet();
        public Aplikimi GetAplikimiById(int aplikimiId);
        public Aplikimi UpdateAplikiminById(int aplikimiId, AplikimiVM aplikimi);
        public Task<ActionResult> DeleteAplikimi(int id);

    }
}
