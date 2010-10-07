Public Interface IPaneles

    Sub nuevo()
    Sub buscar()
    Function eliminar() As IModel
    Function modificar() As IModel
    Function guardar() As IModel

End Interface
