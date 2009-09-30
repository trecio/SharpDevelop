﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Globalization;

namespace ICSharpCode.Profiler.Controller.Data.Linq
{
	sealed class SqlQueryContext
	{
		public readonly int StartDataSetID;
		
		public SqlQueryContext(SQLiteQueryProvider provider)
		{
			this.StartDataSetID = provider.startDataSetID;
		}
		
		int uniqueVariableIndex;
		
		public string GenerateUniqueVariableName()
		{
			return "v" + (++uniqueVariableIndex).ToString(CultureInfo.InvariantCulture);
		}
		
		public CallTreeNodeSqlNameSet CurrentNameSet;
	}
	
	sealed class CallTreeNodeSqlNameSet
	{
		public readonly string ID;
		public readonly string NameID = "nameid";
		public readonly string CpuCyclesSpent;
		public readonly string CallCount;
		public readonly string HasChildren;
		public readonly string ActiveCallCount;
		
		/// <summary>
		/// Gets whether this nameset represents non-merged calls.
		/// </summary>
		public readonly bool IsCalls;
		
		public CallTreeNodeSqlNameSet(SqlQueryContext c, bool isCalls)
		{
			this.IsCalls = isCalls;
			
			string prefix = c.GenerateUniqueVariableName();
			if (isCalls) {
				ID = "id";
				CpuCyclesSpent = "cpucyclesspent";
				CallCount = "callcount";
			} else {
				ID = prefix + "ID";
				CpuCyclesSpent = prefix + "CpuCyclesSpent";
				CallCount = prefix + "CallCount";
			}
			HasChildren = prefix + "HasChildren";
			ActiveCallCount = prefix + "ActiveCallCount";
		}
	}
}