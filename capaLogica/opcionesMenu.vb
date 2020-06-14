Imports System.Windows.Forms
Public Module opcionesMenu
    Public Sub ClickEnBotonModificar(menu As ToolStrip)
        menu.Items().Item(0).Enabled = False 'boton agregar
        menu.Items().Item(2).Enabled = True 'boton guardar
        menu.Items().Item(4).Enabled = True 'boton cancelar
        menu.Items().Item(6).Enabled = False 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnBotonCancelar(menu As ToolStrip)
        menu.Items().Item(0).Enabled = True 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = False 'boton cancelar
        menu.Items().Item(6).Enabled = True 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnBotonBuscar(menu As ToolStrip)
        menu.Items().Item(0).Enabled = False 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = True 'boton cancelar
        menu.Items().Item(6).Enabled = False 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnBotonGuardar(menu As ToolStrip)
        menu.Items().Item(0).Enabled = True 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = False 'boton cancelar
        menu.Items().Item(6).Enabled = True 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnBotonNueva(menu As ToolStrip)
        menu.Items().Item(0).Enabled = False 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = True 'boton cancelar
        menu.Items().Item(6).Enabled = False 'boton nueva
        menu.Items().Item(8).Enabled = True ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickTabDatos(menu As ToolStrip)
        menu.Items().Item(0).Enabled = True 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = False 'boton cancelar
        menu.Items().Item(6).Enabled = True 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = False 'boton borrar
        menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnListado(menu As ToolStrip)
        menu.Items().Item(0).Enabled = False 'boton agregar
        menu.Items().Item(2).Enabled = False 'boton guardar
        menu.Items().Item(4).Enabled = True 'boton cancelar
        menu.Items().Item(6).Enabled = False 'boton nueva
        menu.Items().Item(8).Enabled = False ' boton buscar
        menu.Items().Item(10).Enabled = True 'boton borrar
        menu.Items().Item(12).Enabled = True 'boton modificar
    End Sub

    Public Sub ClickEnBotonAgregar(Menu As ToolStrip)
        Menu.Items().Item(0).Enabled = False 'boton agregar
        Menu.Items().Item(2).Enabled = True 'boton guardar
        Menu.Items().Item(4).Enabled = True 'boton cancelar
        Menu.Items().Item(6).Enabled = False 'boton nueva
        Menu.Items().Item(8).Enabled = False ' boton buscar
        Menu.Items().Item(10).Enabled = False 'boton borrar
        Menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub

    Public Sub ClickEnBotonBorrar(Menu As ToolStrip)
        Menu.Items().Item(0).Enabled = True 'boton agregar
        Menu.Items().Item(2).Enabled = False 'boton guardar
        Menu.Items().Item(4).Enabled = False 'boton cancelar
        Menu.Items().Item(6).Enabled = True 'boton nueva
        Menu.Items().Item(8).Enabled = False ' boton buscar
        Menu.Items().Item(10).Enabled = False 'boton borrar
        Menu.Items().Item(12).Enabled = False 'boton modificar
    End Sub
End Module
