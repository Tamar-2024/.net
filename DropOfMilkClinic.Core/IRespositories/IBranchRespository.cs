﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropOfMilkClinic.Core.IRespositories
{
    public interface IBranchRespository
    {
        public IEnumerable<Branch> Get();
        public string GetById(int id);
        public List<string> GetByCity(string city);
    }
}
