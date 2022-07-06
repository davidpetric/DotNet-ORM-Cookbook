﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace LLBLGenPro.OrmCookbook.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'CountEmployeesByClassificationResult'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="LLBLGenPro.OrmCookbook.FactoryClasses.QueryFactory.GetCountEmployeesByClassificationResultTypedViewProjection"/>. </remarks>
	[Serializable]
	public partial class CountEmployeesByClassificationResultRow : Recipes.IEmployeeClassificationWithCount
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="CountEmployeesByClassificationResultRow"/> class.</summary>
		public CountEmployeesByClassificationResultRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the EmployeeClassificationKey field.</summary>
		public System.Int32 EmployeeClassificationKey { get; set; }
		/// <summary>Gets or sets the EmployeeClassificationName field.</summary>
		public System.String EmployeeClassificationName { get; set; }
		/// <summary>Gets or sets the EmployeeCount field.</summary>
		public System.Int32 EmployeeCount { get; set; }
	}
}

