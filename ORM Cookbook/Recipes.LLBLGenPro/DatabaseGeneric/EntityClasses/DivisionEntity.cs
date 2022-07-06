﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using LLBLGenPro.OrmCookbook.HelperClasses;
using LLBLGenPro.OrmCookbook.FactoryClasses;
using LLBLGenPro.OrmCookbook.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenPro.OrmCookbook.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Division'.<br/><br/></summary>
	[Serializable]
	public partial class DivisionEntity : CommonEntityBase, Recipes.IDivision
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<DepartmentEntity> _departments;
		private EmployeeEntity _createdByEmployee;
		private EmployeeEntity _modifiedByEmployee;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static DivisionEntityStaticMetaData _staticMetaData = new DivisionEntityStaticMetaData();
		private static DivisionRelations _relationsFactory = new DivisionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CreatedByEmployee</summary>
			public static readonly string CreatedByEmployee = "CreatedByEmployee";
			/// <summary>Member name ModifiedByEmployee</summary>
			public static readonly string ModifiedByEmployee = "ModifiedByEmployee";
			/// <summary>Member name Departments</summary>
			public static readonly string Departments = "Departments";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class DivisionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public DivisionEntityStaticMetaData()
			{
				SetEntityCoreInfo("DivisionEntity", InheritanceHierarchyType.None, false, (int)LLBLGenPro.OrmCookbook.EntityType.DivisionEntity, typeof(DivisionEntity), typeof(DivisionEntityFactory), false);
				AddNavigatorMetaData<DivisionEntity, EntityCollection<DepartmentEntity>>("Departments", a => a._departments, (a, b) => a._departments = b, a => a.Departments, () => new DivisionRelations().DepartmentEntityUsingDivisionKey, typeof(DepartmentEntity), (int)LLBLGenPro.OrmCookbook.EntityType.DepartmentEntity);
				AddNavigatorMetaData<DivisionEntity, EmployeeEntity>("CreatedByEmployee", "DivisionsCreatedByEmployee", (a, b) => a._createdByEmployee = b, a => a._createdByEmployee, (a, b) => a.CreatedByEmployee = b, LLBLGenPro.OrmCookbook.RelationClasses.StaticDivisionRelations.EmployeeEntityUsingCreatedByEmployeeKeyStatic, ()=>new DivisionRelations().EmployeeEntityUsingCreatedByEmployeeKey, null, new int[] { (int)DivisionFieldIndex.CreatedByEmployeeKey }, null, true, (int)LLBLGenPro.OrmCookbook.EntityType.EmployeeEntity);
				AddNavigatorMetaData<DivisionEntity, EmployeeEntity>("ModifiedByEmployee", "DivisionsModifiedByEmployee", (a, b) => a._modifiedByEmployee = b, a => a._modifiedByEmployee, (a, b) => a.ModifiedByEmployee = b, LLBLGenPro.OrmCookbook.RelationClasses.StaticDivisionRelations.EmployeeEntityUsingModifiedByEmployeeKeyStatic, ()=>new DivisionRelations().EmployeeEntityUsingModifiedByEmployeeKey, null, new int[] { (int)DivisionFieldIndex.ModifiedByEmployeeKey }, null, true, (int)LLBLGenPro.OrmCookbook.EntityType.EmployeeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static DivisionEntity()
		{
		}

		/// <summary> CTor</summary>
		public DivisionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public DivisionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this DivisionEntity</param>
		public DivisionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="divisionKey">PK value for Division which data should be fetched into this Division object</param>
		public DivisionEntity(System.Int32 divisionKey) : this(divisionKey, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="divisionKey">PK value for Division which data should be fetched into this Division object</param>
		/// <param name="validator">The custom validator object for this DivisionEntity</param>
		public DivisionEntity(System.Int32 divisionKey, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.DivisionKey = divisionKey;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected DivisionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Method which will construct a filter (predicate expression) for the unique constraint defined on the fields: DivisionName .</summary>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public IPredicateExpression ConstructFilterForUCDivisionName()
		{
			var filter = new PredicateExpression();
			filter.Add(LLBLGenPro.OrmCookbook.HelperClasses.DivisionFields.DivisionName == this.Fields.GetCurrentValue((int)DivisionFieldIndex.DivisionName));
 			return filter;
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Department' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDepartments() { return CreateRelationInfoForNavigator("Departments"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreatedByEmployee() { return CreateRelationInfoForNavigator("CreatedByEmployee"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoModifiedByEmployee() { return CreateRelationInfoForNavigator("ModifiedByEmployee"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this DivisionEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static DivisionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Department' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDepartments { get { return _staticMetaData.GetPrefetchPathElement("Departments", CommonEntityBase.CreateEntityCollection<DepartmentEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreatedByEmployee { get { return _staticMetaData.GetPrefetchPathElement("CreatedByEmployee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathModifiedByEmployee { get { return _staticMetaData.GetPrefetchPathElement("ModifiedByEmployee", CommonEntityBase.CreateEntityCollection<EmployeeEntity>()); } }

		/// <summary>The CreatedByEmployeeKey property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."CreatedByEmployeeKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CreatedByEmployeeKey
		{
			get { return (System.Int32)GetValue((int)DivisionFieldIndex.CreatedByEmployeeKey, true); }
			set	{ SetValue((int)DivisionFieldIndex.CreatedByEmployeeKey, value); }
		}

		/// <summary>The CreatedDate property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."CreatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime CreatedDate
		{
			get { return (System.DateTime)GetValue((int)DivisionFieldIndex.CreatedDate, true); }
			set	{ SetValue((int)DivisionFieldIndex.CreatedDate, value); }
		}

		/// <summary>The DivisionId property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."DivisionId".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid DivisionId
		{
			get { return (System.Guid)GetValue((int)DivisionFieldIndex.DivisionId, true); }
			set	{ SetValue((int)DivisionFieldIndex.DivisionId, value); }
		}

		/// <summary>The DivisionKey property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."DivisionKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 DivisionKey
		{
			get { return (System.Int32)GetValue((int)DivisionFieldIndex.DivisionKey, true); }
			set { SetValue((int)DivisionFieldIndex.DivisionKey, value); }		}

		/// <summary>The DivisionName property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."DivisionName".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 30.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String DivisionName
		{
			get { return (System.String)GetValue((int)DivisionFieldIndex.DivisionName, true); }
			set	{ SetValue((int)DivisionFieldIndex.DivisionName, value); }
		}

		/// <summary>The FloorSpaceBudget property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."FloorSpaceBudget".<br/>Table field type characteristics (type, precision, scale, length): Real, 24, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Single> FloorSpaceBudget
		{
			get { return (Nullable<System.Single>)GetValue((int)DivisionFieldIndex.FloorSpaceBudget, false); }
			set	{ SetValue((int)DivisionFieldIndex.FloorSpaceBudget, value); }
		}

		/// <summary>The FteBudget property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."FteBudget".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 5, 1, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> FteBudget
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DivisionFieldIndex.FteBudget, false); }
			set	{ SetValue((int)DivisionFieldIndex.FteBudget, value); }
		}

		/// <summary>The LastReviewCycle property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."LastReviewCycle".<br/>Table field type characteristics (type, precision, scale, length): DateTimeOffset, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTimeOffset> LastReviewCycle
		{
			get { return (Nullable<System.DateTimeOffset>)GetValue((int)DivisionFieldIndex.LastReviewCycle, false); }
			set	{ SetValue((int)DivisionFieldIndex.LastReviewCycle, value); }
		}

		/// <summary>The MaxEmployees property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."MaxEmployees".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> MaxEmployees
		{
			get { return (Nullable<System.Int32>)GetValue((int)DivisionFieldIndex.MaxEmployees, false); }
			set	{ SetValue((int)DivisionFieldIndex.MaxEmployees, value); }
		}

		/// <summary>The ModifiedByEmployeeKey property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."ModifiedByEmployeeKey".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ModifiedByEmployeeKey
		{
			get { return (System.Int32)GetValue((int)DivisionFieldIndex.ModifiedByEmployeeKey, true); }
			set	{ SetValue((int)DivisionFieldIndex.ModifiedByEmployeeKey, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime2, 7, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)DivisionFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)DivisionFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The SalaryBudget property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."SalaryBudget".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 14, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SalaryBudget
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DivisionFieldIndex.SalaryBudget, false); }
			set	{ SetValue((int)DivisionFieldIndex.SalaryBudget, value); }
		}

		/// <summary>The StartTime property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."StartTime".<br/>Table field type characteristics (type, precision, scale, length): Time, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.TimeSpan> StartTime
		{
			get { return (Nullable<System.TimeSpan>)GetValue((int)DivisionFieldIndex.StartTime, false); }
			set	{ SetValue((int)DivisionFieldIndex.StartTime, value); }
		}

		/// <summary>The SuppliesBudget property of the Entity Division<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Division"."SuppliesBudget".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 14, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SuppliesBudget
		{
			get { return (Nullable<System.Decimal>)GetValue((int)DivisionFieldIndex.SuppliesBudget, false); }
			set	{ SetValue((int)DivisionFieldIndex.SuppliesBudget, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'DepartmentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DepartmentEntity))]
		public virtual EntityCollection<DepartmentEntity> Departments { get { return GetOrCreateEntityCollection<DepartmentEntity, DepartmentEntityFactory>("Division", true, false, ref _departments); } }

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity CreatedByEmployee
		{
			get { return _createdByEmployee; }
			set { SetSingleRelatedEntityNavigator(value, "CreatedByEmployee"); }
		}

		/// <summary>Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity ModifiedByEmployee
		{
			get { return _modifiedByEmployee; }
			set { SetSingleRelatedEntityNavigator(value, "ModifiedByEmployee"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace LLBLGenPro.OrmCookbook
{
	public enum DivisionFieldIndex
	{
		///<summary>CreatedByEmployeeKey. </summary>
		CreatedByEmployeeKey,
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>DivisionId. </summary>
		DivisionId,
		///<summary>DivisionKey. </summary>
		DivisionKey,
		///<summary>DivisionName. </summary>
		DivisionName,
		///<summary>FloorSpaceBudget. </summary>
		FloorSpaceBudget,
		///<summary>FteBudget. </summary>
		FteBudget,
		///<summary>LastReviewCycle. </summary>
		LastReviewCycle,
		///<summary>MaxEmployees. </summary>
		MaxEmployees,
		///<summary>ModifiedByEmployeeKey. </summary>
		ModifiedByEmployeeKey,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>SalaryBudget. </summary>
		SalaryBudget,
		///<summary>StartTime. </summary>
		StartTime,
		///<summary>SuppliesBudget. </summary>
		SuppliesBudget,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace LLBLGenPro.OrmCookbook.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Division. </summary>
	public partial class DivisionRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between DivisionEntity and DepartmentEntity over the 1:n relation they have, using the relation between the fields: Division.DivisionKey - Department.DivisionKey</summary>
		public virtual IEntityRelation DepartmentEntityUsingDivisionKey
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Departments", true, new[] { DivisionFields.DivisionKey, DepartmentFields.DivisionKey }); }
		}

		/// <summary>Returns a new IEntityRelation object, between DivisionEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields: Division.CreatedByEmployeeKey - Employee.EmployeeKey</summary>
		public virtual IEntityRelation EmployeeEntityUsingCreatedByEmployeeKey
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "CreatedByEmployee", false, new[] { EmployeeFields.EmployeeKey, DivisionFields.CreatedByEmployeeKey }); }
		}

		/// <summary>Returns a new IEntityRelation object, between DivisionEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields: Division.ModifiedByEmployeeKey - Employee.EmployeeKey</summary>
		public virtual IEntityRelation EmployeeEntityUsingModifiedByEmployeeKey
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "ModifiedByEmployee", false, new[] { EmployeeFields.EmployeeKey, DivisionFields.ModifiedByEmployeeKey }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticDivisionRelations
	{
		internal static readonly IEntityRelation DepartmentEntityUsingDivisionKeyStatic = new DivisionRelations().DepartmentEntityUsingDivisionKey;
		internal static readonly IEntityRelation EmployeeEntityUsingCreatedByEmployeeKeyStatic = new DivisionRelations().EmployeeEntityUsingCreatedByEmployeeKey;
		internal static readonly IEntityRelation EmployeeEntityUsingModifiedByEmployeeKeyStatic = new DivisionRelations().EmployeeEntityUsingModifiedByEmployeeKey;

		/// <summary>CTor</summary>
		static StaticDivisionRelations() { }
	}
}
