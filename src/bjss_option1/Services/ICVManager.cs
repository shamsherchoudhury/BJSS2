using bjss_option1.Models;
using System.Collections.Generic;

namespace bjss_option1.Services
{
    public interface ICVManager
    {
        (bool, IEnumerable<Candidate>) GetCandidates();

        (bool, Candidate) GetCandidate(Personal personal);

        bool UpdateCandidate(Candidate candidate);

        bool CreateCandidate(Candidate candidate);

        bool DeleteCandidate(Candidate candidate);
    }
}
