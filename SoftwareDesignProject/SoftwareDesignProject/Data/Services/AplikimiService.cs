using SoftwareDesignProject.Data.Interfaces;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Data.Services
{
    public class AplikimiService : IAplikimiService
    {
        private readonly AppDbContext _context;

        public AplikimiService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAplikimi(Aplikimi aplikimi)
        {
            var _aplikimi = new Aplikimi()
            {
                NrPersonal = aplikimi.NrPersonal,
                canApply = aplikimi.canApply,
                ApplicationDate = aplikimi.ApplicationDate,
                OpenDate = aplikimi.OpenDate,
                CloseDate = aplikimi.CloseDate,
                ApplicationStatus = aplikimi.ApplicationStatus,
                isSpecialCategory = aplikimi.isSpecialCategory,
                SpecialCategoryReason = aplikimi.SpecialCategoryReason
            };
            _context.Aplikimet.Add(_aplikimi);
            _context.SaveChangesAsync();
        }
    }
}
