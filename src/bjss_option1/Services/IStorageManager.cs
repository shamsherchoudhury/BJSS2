using System;
using System.Collections.Generic;
using bjss_option1.Models;

namespace bjss_option1.Services
{
    public interface IStorageManager
    {
        public (bool, IEnumerable<Candidate>) GetCandidates();

    }
}
