#region Using directives

using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;
using SMSSC.Entities;
using SMSSC.Data;

#endregion

namespace SMSSC.Data.Bases
{	
	///<summary>This class is the base class for any <see cref="MessageHistoryProviderBase"/> implementation. It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.</summary>
	public abstract partial class MessageHistoryProviderBase : MessageHistoryProviderBaseCore
	{
	} // end class
} // end namespace
