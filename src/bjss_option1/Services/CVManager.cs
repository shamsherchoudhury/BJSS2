using bjss_option1.Models;
using System.Collections.Generic;

namespace bjss_option1.Services
{
    public class CVManager : ICVManager
    {
        private IStorageManager _storageManager;

        public CVManager(IStorageManager storageManager)
        {
            _storageManager = storageManager;
        }

        public (bool, IEnumerable<Candidate>) GetCandidates()
        {
            var (success, payload) = _storageManager.GetCandidates();

            return (success, payload ?? new List<Candidate>());
        }

        public (bool, Candidate) GetCandidate(Personal personal)
        {
            return (false, null);
        }

        public bool UpdateCandidate(Candidate candidate)
        {
            return false;
        }

        public bool CreateCandidate(Candidate candidate)
        {
            return false;
        }

        public bool DeleteCandidate(Candidate candidate)
        {
            return false;
        }
    }
}
