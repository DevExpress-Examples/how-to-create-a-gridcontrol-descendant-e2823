Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Core.WPFCompatibility

Namespace CustomGridControl
	''' <summary>
	''' Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
	'''
	''' Step 1a) Using this custom control in a XAML file that exists in the current project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:CustomGridControl"
	'''
	'''
	''' Step 1b) Using this custom control in a XAML file that exists in a different project.
	''' Add this XmlNamespace attribute to the root element of the markup file where it is 
	''' to be used:
	'''
	'''     xmlns:MyNamespace="clr-namespace:CustomGridControl;assembly=CustomGridControl"
	'''
	''' You will also need to add a project reference from the project where the XAML file lives
	''' to this project and Rebuild to avoid compilation errors:
	'''
	'''     Right click on the target project in the Solution Explorer and
	'''     "Add Reference"->"Projects"->[Select this project]
	'''
	'''
	''' Step 2)
	''' Go ahead and use your control in the XAML file.
	'''
	'''     <MyNamespace:CustomControl1/>
	'''
	''' </summary>

	Public Class CustomGridControl
		Inherits GridControl
		Protected Overrides Sub OnPropertyChanged(ByVal e As SLDependencyPropertyChangedEventArgs)
			If e.Property Is GridControl.FilterCriteriaProperty Then
				MessageBox.Show(e.NewValue.ToString())
			End If
			MyBase.OnPropertyChanged(e)
		End Sub

	End Class
End Namespace
