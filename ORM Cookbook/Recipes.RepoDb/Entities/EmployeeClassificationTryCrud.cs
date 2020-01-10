﻿using Recipes.TryCrud;
using RepoDb.Attributes;

namespace Recipes.RepoDb
{
    [Map("[HR].[EmployeeClassification]")]
    public class EmployeeClassificationTryCrud : IEmployeeClassification
    {
        public int EmployeeClassificationKey { get; set; }

        public string? EmployeeClassificationName { get; set; }

        public bool IsExempt { get; set; }

        public bool IsEmployee { get; set; }
    }
}
