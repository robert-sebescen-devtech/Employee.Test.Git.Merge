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
=======
>>>>>>> 554c23c67b2127f8224135dcb9aa81ac650b3774

             return _testRepository.GetPeopleNames().Select(name => name.ToUpper()).ToList();
         

<<<<<<< HEAD
            return noShortFirstNames;

=======
>>>>>>> 554c23c67b2127f8224135dcb9aa81ac650b3774
        }
    }
}