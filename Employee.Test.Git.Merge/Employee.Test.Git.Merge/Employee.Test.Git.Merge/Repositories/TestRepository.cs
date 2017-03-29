using System.Collections.Generic;

namespace Employee.Test.Git.Merge.Repositories
{
    public class TestRepository : ITestRepository
    {
        public List<string> GetPeopleNames()
        {
            return new List<string>()
            {
                "Peter Pan",
                "Jon Skeet",
                "Robert Martin",
                "Andy Hunt",
                "Scott Allen",
                "Mark Seemann"
            };
        }
    }
}