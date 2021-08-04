#region Using directives

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using SMSSC.Entities;

#endregion

namespace SMSSC.Data.Bases
{	
	///<summary>
	/// The base class to implements to create a .NetTiers provider.
	///</summary>
	public abstract class NetTiersProvider : NetTiersProviderBase
	{
		
		///<summary>
		/// Current MessageTemplateProviderBase instance.
		///</summary>
		public virtual MessageTemplateProviderBase MessageTemplateProvider{get {throw new NotImplementedException();}}
		
		///<summary>
		/// Current MessageHistoryProviderBase instance.
		///</summary>
		public virtual MessageHistoryProviderBase MessageHistoryProvider{get {throw new NotImplementedException();}}
		
		
	}
}
