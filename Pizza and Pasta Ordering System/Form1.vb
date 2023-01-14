Imports MetroFramework

Public Class Form1

    Dim _MushroomPizza As Integer = 25, _TomatoesPizza As Integer = 25, _PepperoniPizza As Integer = 25, _PineapplePizza As Integer = 25
    Dim _Spaghetti As Integer = 25, _Carbonara As Integer = 25, _Lasagna As Integer = 25, _MacAndCheese As Integer = 25
    Dim _Cola As Integer = 25, _Choco As Integer = 25
    Dim tempMushroom As Integer = 0, tempTomatoes As Integer = 0, tempPepperoni As Integer = 0, tempPineapple As Integer = 0
    Dim tempSpaghetti As Integer = 0, tempCarbonara As Integer = 0, tempLasagna As Integer = 0, tempMacAndCheese As Integer = 0
    Dim tempCola As Integer = 0, tempChoco As Integer = 0

    Dim _TotalPayment As Double = 0

#Region "Check Supply / Timer to auto update"
    Private Sub stockCheckerTimer_Tick(sender As Object, e As EventArgs) Handles stockCheckerTimer.Tick
        txtMushroomPizzaStock.Text = _MushroomPizza
        txtTomatoesPizzaStock.Text = _TomatoesPizza
        txtPepperoniPizzaStock.Text = _PepperoniPizza
        txtPineapplePizzaStock.Text = _PineapplePizza
        txtSpaghettiStock.Text = _Spaghetti
        txtCarbonaraStock.Text = _Carbonara
        txtLasagnaStock.Text = _Lasagna
        txtMacAndCheeseStock.Text = _MacAndCheese
        txtColaStock.Text = _Cola
        txtChocoStock.Text = _Choco

        CheckIfSoldout()
    End Sub

    Private Sub CheckIfSoldout()
        If _MushroomPizza = 0 Then
            chkMushroomPizza.Checked = False
            chkMushroomPizza.Enabled = False
            chkMushroomPizza.Text = "Sold Out"
        Else
            chkMushroomPizza.Enabled = True
            chkMushroomPizza.Text = "Regular Pizza w/ Mushroom"
        End If
        If _TomatoesPizza = 0 Then
            chkTomatoesPizza.Checked = False
            chkTomatoesPizza.Enabled = False
            chkTomatoesPizza.Text = "Sold Out"
        Else
            chkTomatoesPizza.Enabled = True
            chkTomatoesPizza.Text = "Regular Pizza w/ Tomatoes"
        End If
        If _PepperoniPizza = 0 Then
            chkPepperoniPizza.Checked = False
            chkPepperoniPizza.Enabled = False
            chkPepperoniPizza.Text = "Sold Out"
        Else
            chkPepperoniPizza.Enabled = True
            chkPepperoniPizza.Text = "Pepperoni Pizza"
        End If
        If _PineapplePizza = 0 Then
            chkPineapplePizza.Checked = False
            chkPineapplePizza.Enabled = False
            chkPineapplePizza.Text = "Sold Out"
        Else
            chkPineapplePizza.Enabled = True
            chkPineapplePizza.Text = "Pineapple and Ham Pizza"
        End If

        If _Spaghetti = 0 Then
            chkSpaghetti.Checked = False
            chkSpaghetti.Enabled = False
            chkSpaghetti.Text = "Sold Out"
        Else
            chkSpaghetti.Enabled = True
            chkSpaghetti.Text = "Spaghetti - $2"
        End If

        If _Carbonara = 0 Then
            chkCarbonara.Checked = False
            chkCarbonara.Enabled = False
            chkCarbonara.Text = "Sold Out"
        Else
            chkCarbonara.Enabled = True
            chkCarbonara.Text = "Carbonara - $2"
        End If

        If _Lasagna = 0 Then
            chkLasagna.Checked = False
            chkLasagna.Enabled = False
            chkLasagna.Text = "Sold Out"
        Else
            chkLasagna.Enabled = True
            chkLasagna.Text = "Lasagna - $3"
        End If

        If _MacAndCheese = 0 Then
            chkMacAndCheese.Checked = False
            chkMacAndCheese.Enabled = False
            chkMacAndCheese.Text = "Sold Out"
        Else
            chkMacAndCheese.Enabled = True
            chkMacAndCheese.Text = "Macaroni and Cheese - $4"
        End If

        If _Cola = 0 Then
            chkCola.Checked = False
            chkCola.Enabled = False
            chkCola.Text = "Sold Out"
        Else
            chkCola.Enabled = True
            chkCola.Text = "Cola ($1)"
        End If

        If _Choco = 0 Then
            chkChoco.Checked = False
            chkChoco.Enabled = False
            chkChoco.Text = "Sold Out"
        Else
            chkChoco.Enabled = True
            chkChoco.Text = "Choco ($1)"
        End If
    End Sub
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stockCheckerTimer.Start()

        txtMushroomPizzaStock.ReadOnly = True
        txtTomatoesPizzaStock.ReadOnly = True
        txtPepperoniPizzaStock.ReadOnly = True
        txtPineapplePizzaStock.ReadOnly = True
        txtSpaghettiStock.ReadOnly = True
        txtCarbonaraStock.ReadOnly = True
        txtLasagnaStock.ReadOnly = True
        txtMacAndCheeseStock.ReadOnly = True
        txtColaStock.ReadOnly = True
        txtChocoStock.ReadOnly = True

        txt_UserChange.ReadOnly = True
        txt_UserCardNumber.MaxLength = 16

        txtCarbonaraQty.Enabled = False
        txtChocoQty.Enabled = False
        txtColaQty.Enabled = False
        txtLasagnaQty.Enabled = False
        txtMacAndCheeseQty.Enabled = False
        txtMushroomPizzaQty.Enabled = False
        txtPepperoniPizzaQty.Enabled = False
        txtPineapplePizzaQty.Enabled = False
        txtSpaghettiQty.Enabled = False
        txtTomatoesPizzaQty.Enabled = False
        txtChocoQty.Enabled = False
        txtColaQty.Enabled = False
        txtWaterQty.Enabled = False

    End Sub

#Region "Check if Cash or Card Payment"
    Private Sub rad_CashPayment_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CashPayment.CheckedChanged
        pnl_CashPayment.BringToFront()
    End Sub

    Private Sub rad_CardPayment_CheckedChanged(sender As Object, e As EventArgs) Handles rad_CardPayment.CheckedChanged
        pnl_CardPayment.BringToFront()
    End Sub

    Private Sub lstItems_Checkout_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lstItems_Checkout.ColumnWidthChanging
        'Disable column size to changed
        e.Cancel = True
        e.NewWidth = lstItems_Checkout.Columns(e.ColumnIndex).Width
    End Sub
#End Region

#Region "Proceed to Payment or Void Order"
    Private Sub btn_BackToMenu_Click(sender As Object, e As EventArgs) Handles btn_BackToMenu.Click
        pnl_MenuOrder.BringToFront()
    End Sub

    Private Sub btn_ProceedCheckout_Click(sender As Object, e As EventArgs) Handles btn_ProceedCheckout.Click
        Dim result As DialogResult = MetroMessageBox.Show(Me, "Would you like to proceed onto checkout?", "Process Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            GenerateOrderListPizza()
            GenerateOrderListPasta()
            GenerateOrderListDrinks()
            ClearInputs()
            UnCheckAllOrders()
            ProceedCheckout()
        Else
            'Stay on same page as checkout not proceed
        End If

    End Sub
    Private Sub btn_ClearInputs_Click(sender As Object, e As EventArgs) Handles btn_ClearInputs.Click
        ClearInputs()
        UnCheckAllOrders()
    End Sub
#End Region

#Region "Payment Cash Method"
    Private Sub txt_UserBalance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_UserBalance.KeyPress
        If Asc(e.KeyChar) > 58 Then e.KeyChar = ""
    End Sub

    Private Sub txt_UserBalance_TextChanged(sender As Object, e As EventArgs) Handles txt_UserBalance.TextChanged
        txt_UserChange.Text = Val(txt_UserBalance.Text) - _TotalPayment
    End Sub

    Private Sub btn_SubmitOrder_Click(sender As Object, e As EventArgs) Handles btn_SubmitOrder.Click
        Dim result As DialogResult = MetroMessageBox.Show(Me, "Submit Order?", "Done Ordering", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            If rad_CashPayment.Checked Then
                If Val(txt_UserBalance.Text) >= _TotalPayment Then
                    MetroMessageBox.Show(Me, "Order has been submitted", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    ClearInputs()
                    UnCheckAllOrders()
                    SuccessOrderNoStockReturn()
                    lstItems_Checkout.Items.Clear()
                    pnl_MenuOrder.BringToFront()
                Else
                    MetroMessageBox.Show(Me, "Not enough balance, please input the required payment", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_UserBalance.Focus()
                End If

            End If
            If rad_CardPayment.Checked Then
                Dim _cvv As String = txt_CVV1.Text & txt_CVV2.Text & txt_CVV3.Text & txt_CVV4.Text
                If txt_UserCardNumber.Text = "1122334455667788" And _cvv = "1234" Then
                    MetroMessageBox.Show(Me, "A Total of $" & _TotalPayment & " has been charged to your card", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    ClearInputs()
                    UnCheckAllOrders()
                    SuccessOrderNoStockReturn()
                    lstItems_Checkout.Items.Clear()
                    pnl_MenuOrder.BringToFront()
                Else
                    MetroMessageBox.Show(Me, "Please input correct card information", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txt_UserBalance.Focus()
                End If
            End If
        Else
            'stay on same page as choice is no
        End If
    End Sub

    Private Sub SuccessOrderNoStockReturn()
        tempMushroom = 0
        tempTomatoes = 0
        tempPepperoni = 0
        tempPineapple = 0
        tempSpaghetti = 0
        tempCarbonara = 0
        tempLasagna = 0
        tempMacAndCheese = 0
        tempCola = 0
        tempChoco = 0
    End Sub

    Private Sub CalculateTotalAmount()
        _TotalPayment = 0
        For Each item As ListViewItem In lstItems_Checkout.Items
            _TotalPayment += Convert.ToDouble(item.SubItems(2).Text)
        Next
    End Sub
#End Region

#Region "CVV or Card Payment Method"
    Private Sub txt_UserCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_UserCardNumber.KeyPress
        If Asc(e.KeyChar) > 58 Then e.KeyChar = ""
    End Sub

    Private Sub txt_CVVKeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CVV4.KeyPress, txt_CVV3.KeyPress, txt_CVV2.KeyPress, txt_CVV1.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
AndAlso (Not Char.IsDigit(e.KeyChar) _
AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_CVV1_Click(sender As Object, e As EventArgs) Handles txt_CVV1.Click
        txt_CVV1.Clear()
        txt_CVV2.Clear()
        txt_CVV3.Clear()
        txt_CVV4.Clear()
    End Sub
    Private Sub txt_CVV2_Click(sender As Object, e As EventArgs) Handles txt_CVV2.Click
        txt_CVV1.Focus()
    End Sub
    Private Sub txt_CVV3_Click(sender As Object, e As EventArgs) Handles txt_CVV3.Click
        txt_CVV1.Focus()
    End Sub

    Private Sub txt_CVV4_Click(sender As Object, e As EventArgs) Handles txt_CVV4.Click
        txt_CVV1.Focus()
    End Sub

    Private Sub txt_CVV1_TextChanged(sender As Object, e As EventArgs) Handles txt_CVV1.TextChanged
        If txt_CVV1.Text.Length = 1 Then txt_CVV2.Focus()
    End Sub

    Private Sub txt_CVV2_TextChanged(sender As Object, e As EventArgs) Handles txt_CVV2.TextChanged
        If txt_CVV2.Text.Length = 1 Then txt_CVV3.Focus()
    End Sub

    Private Sub txt_CVV3_TextChanged(sender As Object, e As EventArgs) Handles txt_CVV3.TextChanged
        If txt_CVV3.Text.Length = 1 Then txt_CVV4.Focus()
    End Sub

    Private Sub txt_CVV4_TextChanged(sender As Object, e As EventArgs) Handles txt_CVV4.TextChanged
        If txt_CVV4.Text.Length = 1 Then btn_SubmitOrder.Focus()
    End Sub
#End Region

#Region "Void Order and Return Stock"
    Private Sub ReturnStock()
        _MushroomPizza = _MushroomPizza + tempMushroom
        _TomatoesPizza = _TomatoesPizza + tempTomatoes
        _PepperoniPizza = _PepperoniPizza + tempPepperoni
        _PineapplePizza = _PineapplePizza + _PineapplePizza
        _Spaghetti = _Spaghetti + tempSpaghetti
        _Carbonara = _Carbonara + tempCarbonara
        _Lasagna = _Lasagna + tempLasagna
        _MacAndCheese = _MacAndCheese + tempMacAndCheese
        _Choco = _Choco + tempChoco
        _Cola = _Cola + tempCola

        tempMushroom = 0
        tempTomatoes = 0
        tempPepperoni = 0
        tempPineapple = 0
        tempSpaghetti = 0
        tempCarbonara = 0
        tempLasagna = 0
        tempMacAndCheese = 0
        tempCola = 0
        tempChoco = 0
    End Sub

    Private Sub btn_VoidOrder_Click(sender As Object, e As EventArgs) Handles btn_VoidOrder.Click
        btn_VoidOrder.Visible = False
        txtCodetoVoid.Visible = True
    End Sub

    Private Sub txtCodetoVoid_TextChanged(sender As Object, e As EventArgs) Handles txtCodetoVoid.TextChanged
        If txtCodetoVoid.Text = "123456" Then
            txtCodetoVoid.Visible = False
            btn_VoidOrder.Visible = True
            MetroMessageBox.Show(Me, "Order has been voided", "Void Order", MessageBoxButtons.OK, MessageBoxIcon.Question)
            lstItems_Checkout.Items.Clear()
            ReturnStock()
            pnl_MenuOrder.BringToFront()
            txtCodetoVoid.Text = ""
        End If
    End Sub
#End Region

#Region "Clear Inputs / Uncheck all Orders / Proceed to Checkout"
    Private Sub ClearInputs()
        txtCarbonaraQty.Text = ""
        txtChocoQty.Text = ""
        txtColaQty.Text = ""
        txtLasagnaQty.Text = ""
        txtMacAndCheeseQty.Text = ""
        txtMushroomPizzaQty.Text = ""
        txtPepperoniPizzaQty.Text = ""
        txtPineapplePizzaQty.Text = ""
        txtSpaghettiQty.Text = ""
        txtTomatoesPizzaQty.Text = ""
        txtWaterQty.Text = ""

        txt_UserBalance.Text = ""
        txt_UserChange.Text = ""
        txt_UserCardNumber.Text = ""
        txt_CVV1.Text = ""
        txt_CVV2.Text = ""
        txt_CVV3.Text = ""
        txt_CVV4.Text = ""
    End Sub

    Private Sub UnCheckAllOrders()
        chkCarbonara.Checked = False
        chkChoco.Checked = False
        chkCola.Checked = False
        chkLasagna.Checked = False
        chkMacAndCheese.Checked = False
        chkMushroomPizza.Checked = False
        chkPepperoniPizza.Checked = False
        chkPineapplePizza.Checked = False
        chkSpaghetti.Checked = False
        chkTomatoesPizza.Checked = False
        chkWater.Checked = False
    End Sub

    Private Sub ProceedCheckout()
        If Val(txtMushroomPizzaQty.Text) > _MushroomPizza Or Val(txtTomatoesPizzaQty.Text) > _TomatoesPizza Or Val(txtPepperoniPizzaQty.Text) > _PepperoniPizza Or Val(txtPineapplePizzaQty.Text) > _PineapplePizza Or Val(txtSpaghettiQty.Text) > _Spaghetti Or Val(txtCarbonaraQty.Text) > _Carbonara Or Val(txtMacAndCheeseQty.Text) > _MacAndCheese Or Val(txtLasagnaQty.Text) > _Lasagna Or Val(txtColaQty.Text) > _Cola Or Val(txtChocoQty.Text) > _Choco Then

        Else
            pnl_Checkout.BringToFront()
            CalculateTotalAmount()
            txt_TotalToPay.Text = "$" & _TotalPayment
        End If
    End Sub
#End Region

#Region "Disable Inputuing Text/Char from Quantity"
    Private Sub txtDisableTextPizza(sender As Object, e As KeyPressEventArgs) Handles txtTomatoesPizzaQty.KeyPress, txtPineapplePizzaQty.KeyPress, txtPepperoniPizzaQty.KeyPress, txtMushroomPizzaQty.KeyPress
        If Asc(e.KeyChar) > 58 Then e.KeyChar = ""
    End Sub

    Private Sub txtDisableTextDrinks(sender As Object, e As KeyPressEventArgs) Handles txtWaterQty.KeyPress, txtColaQty.KeyPress, txtChocoQty.KeyPress
        If Asc(e.KeyChar) > 58 Then e.KeyChar = ""
    End Sub

    Private Sub txtDisableTextPasta(sender As Object, e As KeyPressEventArgs) Handles txtSpaghettiQty.KeyPress, txtMacAndCheeseQty.KeyPress, txtLasagnaQty.KeyPress, txtCarbonaraQty.KeyPress
        If Asc(e.KeyChar) > 58 Then e.KeyChar = ""
    End Sub
#End Region

#Region "Checkboxes Disabled if not gonna order"
    Private Sub chkMushroomPizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkMushroomPizza.CheckedChanged
        txtMushroomPizzaQty.Enabled = chkMushroomPizza.Checked
    End Sub
    Private Sub chkTomatoesPizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkTomatoesPizza.CheckedChanged
        txtTomatoesPizzaQty.Enabled = chkTomatoesPizza.Checked
    End Sub

    Private Sub chkPepperoniPizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPepperoniPizza.CheckedChanged
        txtPepperoniPizzaQty.Enabled = chkPepperoniPizza.Checked
    End Sub

    Private Sub chkPineapplePizza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPineapplePizza.CheckedChanged
        txtPineapplePizzaQty.Enabled = chkPineapplePizza.Checked
    End Sub

    Private Sub chkSpaghetti_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpaghetti.CheckedChanged
        txtSpaghettiQty.Enabled = chkSpaghetti.Checked
    End Sub

    Private Sub chkCarbonara_CheckedChanged(sender As Object, e As EventArgs) Handles chkCarbonara.CheckedChanged
        txtCarbonaraQty.Enabled = chkCarbonara.Checked
    End Sub

    Private Sub chkLasagna_CheckedChanged(sender As Object, e As EventArgs) Handles chkLasagna.CheckedChanged
        txtLasagnaQty.Enabled = chkLasagna.Checked
    End Sub

    Private Sub chkMacAndCheese_CheckedChanged(sender As Object, e As EventArgs) Handles chkMacAndCheese.CheckedChanged
        txtMacAndCheeseQty.Enabled = chkMacAndCheese.Checked
    End Sub

    Private Sub chkCola_CheckedChanged(sender As Object, e As EventArgs) Handles chkCola.CheckedChanged
        txtColaQty.Enabled = chkCola.Checked
    End Sub

    Private Sub chkChoco_CheckedChanged(sender As Object, e As EventArgs) Handles chkChoco.CheckedChanged
        txtChocoQty.Enabled = chkChoco.Checked
    End Sub


    Private Sub chkWater_CheckedChanged(sender As Object, e As EventArgs) Handles chkWater.CheckedChanged
        txtWaterQty.Enabled = chkWater.Checked
    End Sub
#End Region

#Region "Check Pizza Supply"
    Private Sub CheckMushroomPizzaSupply()
        If _MushroomPizza = 0 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Mushroom is now Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _MushroomPizza < 3 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Mushroom has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _MushroomPizza <= 5 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Mushroom has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckTomatoesPizzaSupply()
        If _TomatoesPizza = 0 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Tomatoes is now Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _TomatoesPizza < 3 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Tomatoes has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _TomatoesPizza <= 5 Then
            MetroMessageBox.Show(Me, "Regular Pizza w/ Tomatoes has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckPepperoniPizzaSupply()
        If _PepperoniPizza = 0 Then
            MetroMessageBox.Show(Me, "Pepperoni Pizza is now Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _PepperoniPizza < 3 Then
            MetroMessageBox.Show(Me, "Pepperoni Pizza has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _PepperoniPizza <= 5 Then
            MetroMessageBox.Show(Me, "Pepperoni Pizza has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckPineapplePizzaSupply()
        If _PineapplePizza = 0 Then
            MetroMessageBox.Show(Me, "Pineapple and Ham Pizza is now Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _PineapplePizza < 3 Then
            MetroMessageBox.Show(Me, "Pineapple and Ham Pizza has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _PineapplePizza <= 5 Then
            MetroMessageBox.Show(Me, "Pineapple and Ham Pizza has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub
#End Region

#Region "Check Pasta Supply"
    Private Sub CheckSpaghettiSupply()
        If _Spaghetti = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _Spaghetti < 3 Then
            MetroMessageBox.Show(Me, "Spaghetti has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _Spaghetti <= 5 Then
            MetroMessageBox.Show(Me, "Spaghetti has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckCarbonaraSupply()
        If _Carbonara = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _Carbonara < 3 Then
            MetroMessageBox.Show(Me, "Carbonara has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _Carbonara <= 5 Then
            MetroMessageBox.Show(Me, "Carbonara has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckLasagnaSupply()
        If _Lasagna = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _Lasagna < 3 Then
            MetroMessageBox.Show(Me, "Lasagna has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _Lasagna <= 5 Then
            MetroMessageBox.Show(Me, "Lasagna has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub
    Private Sub CheckMacAndCheeseSupply()
        If _MacAndCheese = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _MacAndCheese < 3 Then
            MetroMessageBox.Show(Me, "Macaroni and Cheese has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _MacAndCheese <= 5 Then
            MetroMessageBox.Show(Me, "Macaroni and Cheese has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub
#End Region

#Region "Check Drinks Supply"
    Private Sub CheckColaSupply()
        If _Cola = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _Cola < 3 Then
            MetroMessageBox.Show(Me, "Cola has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _Cola <= 5 Then
            MetroMessageBox.Show(Me, "Cola has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub

    Private Sub CheckChocoSupply()
        If _Choco = 0 Then
            MetroMessageBox.Show(Me, "Out of Stock", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf _Choco < 3 Then
            MetroMessageBox.Show(Me, "Choco has only less than 3 stock left", "Stock Critical", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf _Choco <= 5 Then
            MetroMessageBox.Show(Me, "Choco has only less than 5 stock left", "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            'All conditions passed, stock has > 5 left
        End If
    End Sub
#End Region

#Region "Generate Orders"
    Private Sub GenerateOrderListPizza()
        If chkMushroomPizza.Checked = True Then
            If txtMushroomPizzaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Regular w/ Mushroom Pizza you want to order before proceeding!")
            Else
                If Val(txtMushroomPizzaQty.Text) > _MushroomPizza Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtMushroomPizzaQty.Text)
                    If radSmallMushroomPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Small " & chkMushroomPizza.Text)
                        item.SubItems.Add(txtMushroomPizzaQty.Text)
                        Dim total As Double = qty * 2
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radMediumMushroomPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Medium " & chkMushroomPizza.Text)
                        item.SubItems.Add(txtMushroomPizzaQty.Text)
                        Dim total As Double = qty * 5
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radLargeMushroomPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Large " & chkMushroomPizza.Text)
                        item.SubItems.Add(txtMushroomPizzaQty.Text)
                        Dim total As Double = qty * 7
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    _MushroomPizza = _MushroomPizza - qty
                    tempMushroom = tempMushroom + qty
                    CheckMushroomPizzaSupply()
                End If
            End If
        End If

        If chkTomatoesPizza.Checked = True Then
            If txtTomatoesPizzaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Regular w/ Tomatoes Pizza you want to order before proceeding!")
            Else
                If Val(txtTomatoesPizzaQty.Text) > _TomatoesPizza Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtTomatoesPizzaQty.Text)
                    If radSmallTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Small " & chkTomatoesPizza.Text)
                        item.SubItems.Add(txtTomatoesPizzaQty.Text)
                        Dim total As Double = qty * 2
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radMediumTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Medium " & chkTomatoesPizza.Text)
                        item.SubItems.Add(txtTomatoesPizzaQty.Text)
                        Dim total As Double = qty * 5
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radLargeTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Large " & chkTomatoesPizza.Text)
                        item.SubItems.Add(txtTomatoesPizzaQty.Text)
                        Dim total As Double = qty * 7
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    _TomatoesPizza = _TomatoesPizza - qty
                    tempTomatoes = tempTomatoes + qty
                    CheckTomatoesPizzaSupply()
                End If
            End If
        End If

        If chkPepperoniPizza.Checked = True Then
            If txtPepperoniPizzaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Pepperoni Pizza you want to order before proceeding!")
            Else
                If Val(txtPepperoniPizzaQty.Text) > _PepperoniPizza Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtPepperoniPizzaQty.Text)
                    If radSmallPepperoniPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Small " & chkPepperoniPizza.Text)
                        item.SubItems.Add(txtPepperoniPizzaQty.Text)
                        Dim total As Double = qty * 4
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radMediumPepperoniPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Medium " & chkPepperoniPizza.Text)
                        item.SubItems.Add(txtPepperoniPizzaQty.Text)
                        Dim total As Double = qty * 7
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radLargePepperoniPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Large " & chkPepperoniPizza.Text)
                        item.SubItems.Add(txtPepperoniPizzaQty.Text)
                        Dim total As Double = qty * 10
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    _PepperoniPizza = _PepperoniPizza - qty
                    tempPepperoni = tempPepperoni + qty
                    CheckPepperoniPizzaSupply()
                End If
            End If
        End If

        If chkPineapplePizza.Checked = True Then
            If txtPineapplePizzaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Pineapple and Ham Pizza you want to order before proceeding!")
            Else
                If Val(txtPineapplePizzaQty.Text) > _PineapplePizza Then

                Else
                    Dim qty = Val(txtPineapplePizzaQty.Text)
                    If radSmallTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Small " & chkPineapplePizza.Text)
                        item.SubItems.Add(txtPineapplePizzaQty.Text)
                        Dim total As Double = qty * 4
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radMediumTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Medium " & chkPineapplePizza.Text)
                        item.SubItems.Add(txtPineapplePizzaQty.Text)
                        Dim total As Double = qty * 7
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    If radLargeTomatoesPizza.Checked Then
                        Dim item As ListViewItem = New ListViewItem("Large " & chkPineapplePizza.Text)
                        item.SubItems.Add(txtPineapplePizzaQty.Text)
                        Dim total As Double = qty * 10
                        item.SubItems.Add(total)
                        lstItems_Checkout.Items.Add(item)
                    End If
                    _PineapplePizza = _PineapplePizza - qty
                    tempPineapple = tempPineapple + qty
                    CheckPineapplePizzaSupply()
                End If
            End If
        End If
    End Sub

    Private Sub GenerateOrderListPasta()
        If chkSpaghetti.Checked = True Then
            If txtSpaghettiQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Spaghetti you want to order before proceeding!")
            Else
                If Val(txtSpaghettiQty.Text) > _Spaghetti Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtSpaghettiQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkSpaghetti.Text)
                    item.SubItems.Add(txtSpaghettiQty.Text)
                    Dim total As Double = qty * 2
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _Spaghetti = _Spaghetti - qty
                    tempSpaghetti = tempSpaghetti + qty
                    CheckSpaghettiSupply()
                End If
            End If
        End If

        If chkCarbonara.Checked = True Then
            If txtCarbonaraQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Carbonara you want to order before proceeding!")
            Else
                If Val(txtCarbonaraQty.Text) > _Carbonara Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtCarbonaraQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkCarbonara.Text)
                    item.SubItems.Add(txtCarbonaraQty.Text)
                    Dim total As Double = qty * 3
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _Carbonara = _Carbonara - qty
                    tempCarbonara = tempCarbonara + qty
                    CheckCarbonaraSupply()
                End If
            End If
        End If

        If chkMacAndCheese.Checked = True Then
            If txtMacAndCheeseQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Mac and Cheese you want to order before proceeding!")
            Else
                If Val(txtMacAndCheeseQty.Text) > _MacAndCheese Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtMacAndCheeseQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkMacAndCheese.Text)
                    item.SubItems.Add(txtMacAndCheeseQty.Text)
                    Dim total As Double = qty * 4
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _MacAndCheese = _MacAndCheese - qty
                    tempMacAndCheese = tempMacAndCheese + qty
                    CheckMacAndCheeseSupply()
                End If
            End If
        End If

        If chkLasagna.Checked = True Then
            If txtLasagnaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Lasagna you want to order before proceeding!")
            Else
                If Val(txtLasagnaQty.Text) > _Lasagna Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtMacAndCheeseQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkMacAndCheese.Text)
                    item.SubItems.Add(txtMacAndCheeseQty.Text)
                    Dim total As Double = qty * 4
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _MacAndCheese = _MacAndCheese - qty
                    tempMacAndCheese = tempMacAndCheese + qty
                    CheckLasagnaSupply()
                End If
            End If
        End If
    End Sub

    Private Sub GenerateOrderListDrinks()
        If chkCola.Checked = True Then
            If txtColaQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Cola you want to order before proceeding!")
            Else
                If Val(txtColaQty.Text) > _Cola Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtColaQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkCola.Text)
                    item.SubItems.Add(txtColaQty.Text)
                    Dim total As Double = qty * 2
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _Cola = _Cola - qty
                    tempCola = tempCola + qty
                    CheckColaSupply()
                End If
            End If
        End If

        If chkChoco.Checked = True Then
            If txtChocoQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Choco you want to order before proceeding!")
            Else
                If Val(txtChocoQty.Text) > _Choco Then
                    MetroMessageBox.Show(Me, "Order must not be greater than current stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim qty = Val(txtChocoQty.Text)
                    Dim item As ListViewItem = New ListViewItem(chkChoco.Text)
                    item.SubItems.Add(txtChocoQty.Text)
                    Dim total As Double = qty * 2
                    item.SubItems.Add(total)
                    lstItems_Checkout.Items.Add(item)
                    _Choco = _Choco - qty
                    tempChoco = tempChoco + qty
                    CheckChocoSupply()
                End If
            End If
        End If

        If chkWater.Checked = True Then
            If txtWaterQty.Text = Nothing Then
                MetroMessageBox.Show(Me, "Please input how many Water you want to order before proceeding!")
            Else
                Dim qty = Val(txtWaterQty.Text)
                Dim item As ListViewItem = New ListViewItem(chkWater.Text)
                item.SubItems.Add(txtWaterQty.Text)
                Dim total As Double = qty * 0
                item.SubItems.Add(total)
                lstItems_Checkout.Items.Add(item)
            End If
        End If
    End Sub
#End Region

End Class
