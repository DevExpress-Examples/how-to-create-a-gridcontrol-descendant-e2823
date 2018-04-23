Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Controls

Namespace DXGridDescendant
	Partial Public Class MainPage
		Inherits UserControl
		Private coll As List(Of ContactItem)
		Public Sub New()
			InitializeComponent()
			coll = New List(Of ContactItem)()

			Dim f1 As New ContactItem()
			f1.Name = "A"
			f1.Salary = 200
			coll.Add(f1)
			Dim f2 As New ContactItem()
			f2.Name = "B"
			f2.Salary = 100
			coll.Add(f2)

			gridControl1.ItemsSource = coll
		End Sub
	End Class
End Namespace
