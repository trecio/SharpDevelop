﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Windows;
using System.Windows.Controls;

namespace ICSharpCode.Core.Presentation
{
	sealed class ToolBarComboBox : ComboBox, IStatusUpdate
	{
		IComboBoxCommand menuCommand;
		readonly Codon codon;
		readonly object caller;
		
		public ToolBarComboBox(Codon codon, object caller)
		{
			if (codon == null)
				throw new ArgumentNullException("codon");
			this.codon = codon;
			this.caller = caller;
			ToolTipService.SetShowOnDisabled(this, true);
			this.IsEditable = false;
			menuCommand = (IComboBoxCommand)codon.AddIn.CreateObject(codon.Properties["class"]);
			menuCommand.ComboBox = this;
			menuCommand.Owner = caller;
			UpdateText();
			
			SetResourceReference(FrameworkElement.StyleProperty, ToolBar.ComboBoxStyleKey);
		}
		
		public void UpdateText()
		{
			if (codon.Properties.Contains("tooltip")) {
				this.ToolTip = StringParser.Parse(codon.Properties["tooltip"]);
			}
		}
		
		public void UpdateStatus()
		{
			if (codon.GetFailedAction(caller) == ConditionFailedAction.Exclude)
				this.Visibility = Visibility.Collapsed;
			else
				this.Visibility = Visibility.Visible;
		}
		
		protected override void OnSelectionChanged(SelectionChangedEventArgs e)
		{
			base.OnSelectionChanged(e);
			menuCommand.Run();
		}
	}
}
