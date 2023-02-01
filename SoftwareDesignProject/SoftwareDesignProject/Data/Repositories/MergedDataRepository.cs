namespace SoftwareDesignProject.Data.Repositories
{
    public class MergedDataRepository
    {
        private readonly AppDbContext _context;

        public MergedDataRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<object> GetMergedData()
        {
            var mergedData = _context.Aplikimet
                                     .GroupJoin(_context.Students,
                                                  a => a.StudentiNrLeternjoftimit,
                                                  s => s.NrLeternjoftimit,
                                                  (a, s) => new { Aplikimet = a, Students = s })
                                     .SelectMany(x => x.Students.DefaultIfEmpty(),
                                                  (a, s) => new { Aplikimet = a.Aplikimet, Students = s })
                                     .ToList();

            return mergedData.Select(x => new
            {
                x.Aplikimet.Id,
                x.Aplikimet.isSpecialCategory,
                x.Aplikimet.SpecialCategoryReason,
                x.Aplikimet.ApplyDate,
                x.Aplikimet.StudentiNrLeternjoftimit,
                x.Students.NrLeternjoftimit,
                x.Students.Emri,
                x.Students.EmriIPrindit,
                x.Students.Mbiemri,
                x.Students.Qyteti,
                x.Students.NotaMesatare,
                x.Students.NumriKontaktues,
                x.Students.Email,
                x.Students.Gjinia,
                x.Students.VitiIStudimeve,
                x.Students.Statusi,
                x.Students.ProfilePicUrl,
                x.Students.FakultetiId,
                x.Students.Fakulteti
            }).ToList<object>();
        }

    }
}
