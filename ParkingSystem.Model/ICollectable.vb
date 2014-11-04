Public Interface ICollectable

    Enum States
        Unchanged = 0
        Added = 1
        Deleted = 2
        Removed = 3
        Modified = 4
    End Enum

    Property State() As States
    Property Index() As Integer

End Interface
