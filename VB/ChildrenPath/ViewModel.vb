Imports System.Collections.Generic

Namespace ChildrenPath

    Friend Class ViewModel
        Public Property AppMenu() As Menu
        Public Property SelectedItem() As MenuItem
        Public Sub New()
            AppMenu = New Menu()
            SelectedItem = AppMenu.MenuItems(0)
        End Sub
    End Class

    Public Class Menu
        Public Property MenuItems() As List(Of MenuItem)
        Public Sub New()
            MenuItems = GetMenuItems()
        End Sub
        Private Shared Function GetMenuItems() As List(Of MenuItem)
            Dim items As New List(Of MenuItem)()
            Dim subitems As New List(Of MenuItem)()
            subitems.Add(New MenuItem() With {.Caption = "SubItem3"})
            items.Add(New MenuItem() With { _
                .Caption = "Item1", _
                .SubItems = New List(Of MenuItem)() From { _
                    New MenuItem() With {.Caption = "SubItem1"}, _
                    New MenuItem() With { _
                        .Caption = "SubItem2", _
                        .SubItems=subitems _
                    } _
                } _
            })
            items.Add(New MenuItem() With { _
                .Caption = "Item2", _
                .SubItems = New List(Of MenuItem)() From { _
                    New MenuItem() With {.Caption = "SubItem1"}, _
                    New MenuItem() With {.Caption = "SubItem2"} _
                } _
            })
            Return items
        End Function
    End Class

    Public Class MenuItem
        Public Property Caption() As String
        Public Property SubItems() As List(Of MenuItem)
    End Class
End Namespace
