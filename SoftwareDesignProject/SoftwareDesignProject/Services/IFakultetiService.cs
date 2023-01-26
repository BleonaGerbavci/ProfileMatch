using Microsoft.AspNetCore.Mvc;
using SoftwareDesignProject.Data.Models;

namespace SoftwareDesignProject.Services
{
    public interface IFakultetiService
    {
        public Task<ActionResult<IEnumerable<Fakulteti>>> GetAll();
        public void AddFakulteti(Fakulteti fakulteti);
        public void DeleteFakulteti(int fakultetiId);
        public Fakulteti UpdateFakulteti(int fakultetiId);

        // ose mnyra tjeter
        /*
         * 
         */
    }
}
