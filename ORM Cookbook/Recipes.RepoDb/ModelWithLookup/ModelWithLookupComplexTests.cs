﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recipes.ModelWithLookup;
using Recipes.RepoDb.Entities;

namespace Recipes.RepoDb.ModelWithLookup
{
    [TestClass]
    public class ModelWithLookupComplexTests : ModelWithLookupComplexTests<EmployeeComplex>
    {
        protected override IModelWithLookupComplexRepository<EmployeeComplex> GetRepository()
        {
            return new ModelWithLookupComplexRepository(Setup.ConnectionString);
        }
    }
}