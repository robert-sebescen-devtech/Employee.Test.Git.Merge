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
            var peopleNames = _testRepository.GetPeopleNames();
            List<string> novaLista = new List<string>();
            
            List<string> noShortFirstNames = peopleNames.ToList();
            foreach(String s in noShortFirstNames){
                String ime = s.Split(' ')[0];
                if(ime.Length>3){
                    novaLista.add(s);
                }
            }

            return novaLista;
        }
    }
}