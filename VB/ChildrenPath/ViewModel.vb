Imports System.Collections.Generic

Namespace ChildrenPath

    Friend Class ViewModel

        Public Property AppMenu As Menu

        Public Property SelectedItem As MenuItem

        Public Sub New()
            Me.AppMenu = New ChildrenPath.Menu()
            Me.SelectedItem = Me.AppMenu.MenuItems(0)
        End Sub
    End Class

    Public Class Menu

        Public Property MenuItems As List(Of ChildrenPath.MenuItem)

        Public Sub New()
            Me.MenuItems = ChildrenPath.Menu.GetMenuItems()
        End Sub

        Private Shared Function GetMenuItems() As List(Of ChildrenPath.MenuItem)
            Dim items As System.Collections.Generic.List(Of ChildrenPath.MenuItem) = New System.Collections.Generic.List(Of ChildrenPath.MenuItem)()
            Dim subitems As System.Collections.Generic.List(Of ChildrenPath.MenuItem) = New System.Collections.Generic.List(Of ChildrenPath.MenuItem)()
            subitems.Add(New ChildrenPath.MenuItem() With {.Caption = "SubItem3"})
            items.Add(New ChildrenPath.MenuItem() With {.Caption = "Item1", .SubItems = New System.Collections.Generic.List(Of ChildrenPath.MenuItem)() From {New ChildrenPath.MenuItem() With {.Caption = "SubItem1"}, New ChildrenPath.MenuItem() With {.Caption = "SubItem2", .SubItems = subitems}}})
            items.Add(New ChildrenPath.MenuItem() With {.Caption = "Item2", .SubItems = New System.Collections.Generic.List(Of ChildrenPath.MenuItem)() From {New ChildrenPath.MenuItem() With {.Caption = "SubItem1"}, New ChildrenPath.MenuItem() With {.Caption = "SubItem2"}}})
            Return items
        End Function
    End Class

    Public Class MenuItem

        Public Property Caption As String

        Public Property SubItems As List(Of ChildrenPath.MenuItem)
    End Class
End Namespace
