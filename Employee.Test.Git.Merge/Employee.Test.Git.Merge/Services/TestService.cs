using Employee.Test.Git.Merge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Test.Git.Merge.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public List<string> PeopleNames()
        {
<<<<<<< HEAD
            var peopleNames = _testRepository.GetPeopleNames();

            List<string> noShortFirstNames = peopleNames.Where(name => name.Split(' ')[0].Length > 3).ToList();

            return noShortFirstNames;
=======
            return _testRepository.GetPeopleNames().Select(name => name.ToUpper()).ToList();
>>>>>>> ff1d588a1fa537d458ea570c57e65a491689f69d
        }
    }
}