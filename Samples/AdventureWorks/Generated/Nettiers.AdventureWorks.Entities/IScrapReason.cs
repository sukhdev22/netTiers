﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'ScrapReason' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IScrapReason 
	{
		/// <summary>			
		/// ScrapReasonID : Primary key for ScrapReason records.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "ScrapReason"</remarks>
		System.Int16 ScrapReasonId { get; set; }
				
		
		
		/// <summary>
		/// Name : Failure description.
		/// </summary>
		System.String  Name  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties


		/// <summary>
		///	Holds a collection of entity objects
		///	which are related to this object through the relation _workOrderScrapReasonId
		/// </summary>	
		TList<WorkOrder> WorkOrderCollection {  get;  set;}	

		#endregion Data Properties

	}
}

