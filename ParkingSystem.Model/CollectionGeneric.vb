Imports System.Collections.ObjectModel

Public Class CollectionGeneric(Of T As ICollectable)
    Inherits KeyedCollection(Of Integer, T)


    Protected Overrides Function GetKeyForItem(ByVal item As T) As Integer
        Static mCounter As Integer = 0
        item.Index = mCounter
        mCounter += 1
        Return item.Index
    End Function

    ''' <summary>
    ''' Add object to the list and updates status
    ''' </summary>
    ''' <param name="pObject"> Object to add to the collection</param>
    ''' <returns>Idex of the added object</returns>
    ''' <remarks></remarks>
    Public Overridable Function AddObject(ByVal pObject As T) As Integer
        pObject.State = ICollectable.States.Added
        Me.Add(pObject)
        Return pObject.Index
    End Function
End Class
