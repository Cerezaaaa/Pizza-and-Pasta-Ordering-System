<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstItems_Checkout = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnl_Checkout = New System.Windows.Forms.Panel()
        Me.txt_TotalToPay = New MetroFramework.Controls.MetroLabel()
        Me.btn_BackToMenu = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.btn_SubmitOrder = New MetroFramework.Controls.MetroButton()
        Me.rad_CardPayment = New MetroFramework.Controls.MetroRadioButton()
        Me.rad_CashPayment = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.pnl_CashPayment = New System.Windows.Forms.Panel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txt_UserChange = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txt_UserBalance = New MetroFramework.Controls.MetroTextBox()
        Me.pnl_CardPayment = New System.Windows.Forms.Panel()
        Me.txt_CVV4 = New MetroFramework.Controls.MetroTextBox()
        Me.txt_CVV3 = New MetroFramework.Controls.MetroTextBox()
        Me.txt_CVV2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txt_CVV1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txt_UserCardNumber = New MetroFramework.Controls.MetroTextBox()
        Me.btn_VoidOrder = New MetroFramework.Controls.MetroButton()
        Me.txtCodetoVoid = New MetroFramework.Controls.MetroTextBox()
        Me.btn_ProceedCheckout = New MetroFramework.Controls.MetroButton()
        Me.pnl_MenuOrder = New System.Windows.Forms.Panel()
        Me.btn_ClearInputs = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.txtPineapplePizzaQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtPineapplePizzaStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtPepperoniPizzaQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtPepperoniPizzaStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtTomatoesPizzaQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtTomatoesPizzaStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtMushroomPizzaQty = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.radSmallTomatoesPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radMediumTomatoesPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radLargeTomatoesPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.radSmallPineapplePizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radMediumPineapplePizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radLargePineapplePizza = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.radSmallPepperoniPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radMediumPepperoniPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radLargePepperoniPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radSmallMushroomPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radMediumMushroomPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.radLargeMushroomPizza = New MetroFramework.Controls.MetroRadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chkPepperoniPizza = New MetroFramework.Controls.MetroCheckBox()
        Me.txtMushroomPizzaStock = New MetroFramework.Controls.MetroTextBox()
        Me.chkTomatoesPizza = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.chkMushroomPizza = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.chkPineapplePizza = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.txtMacAndCheeseQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtMacAndCheeseStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtLasagnaQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtLasagnaStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtCarbonaraQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtCarbonaraStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtSpaghettiQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtSpaghettiStock = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkLasagna = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCarbonara = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.chkSpaghetti = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.chkMacAndCheese = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.txtWaterQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtWaterStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtChocoQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtChocoStock = New MetroFramework.Controls.MetroTextBox()
        Me.txtColaQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtColaStock = New MetroFramework.Controls.MetroTextBox()
        Me.chkWater = New MetroFramework.Controls.MetroCheckBox()
        Me.chkChoco = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCola = New MetroFramework.Controls.MetroCheckBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.stockCheckerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnl_Checkout.SuspendLayout()
        Me.pnl_CashPayment.SuspendLayout()
        Me.pnl_CardPayment.SuspendLayout()
        Me.pnl_MenuOrder.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl3.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstItems_Checkout
        '
        Me.lstItems_Checkout.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstItems_Checkout.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems_Checkout.HideSelection = False
        Me.lstItems_Checkout.Location = New System.Drawing.Point(20, 60)
        Me.lstItems_Checkout.Name = "lstItems_Checkout"
        Me.lstItems_Checkout.Size = New System.Drawing.Size(466, 371)
        Me.lstItems_Checkout.TabIndex = 12
        Me.lstItems_Checkout.UseCompatibleStateImageBehavior = False
        Me.lstItems_Checkout.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Quantity"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.Width = 80
        '
        'pnl_Checkout
        '
        Me.pnl_Checkout.Controls.Add(Me.txt_TotalToPay)
        Me.pnl_Checkout.Controls.Add(Me.btn_BackToMenu)
        Me.pnl_Checkout.Controls.Add(Me.MetroLabel8)
        Me.pnl_Checkout.Controls.Add(Me.btn_SubmitOrder)
        Me.pnl_Checkout.Controls.Add(Me.rad_CardPayment)
        Me.pnl_Checkout.Controls.Add(Me.rad_CashPayment)
        Me.pnl_Checkout.Controls.Add(Me.MetroLabel7)
        Me.pnl_Checkout.Controls.Add(Me.MetroLabel5)
        Me.pnl_Checkout.Controls.Add(Me.lstItems_Checkout)
        Me.pnl_Checkout.Controls.Add(Me.pnl_CashPayment)
        Me.pnl_Checkout.Controls.Add(Me.pnl_CardPayment)
        Me.pnl_Checkout.Controls.Add(Me.btn_VoidOrder)
        Me.pnl_Checkout.Controls.Add(Me.txtCodetoVoid)
        Me.pnl_Checkout.Location = New System.Drawing.Point(18, 63)
        Me.pnl_Checkout.Name = "pnl_Checkout"
        Me.pnl_Checkout.Size = New System.Drawing.Size(693, 451)
        Me.pnl_Checkout.TabIndex = 23
        '
        'txt_TotalToPay
        '
        Me.txt_TotalToPay.AutoSize = True
        Me.txt_TotalToPay.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.txt_TotalToPay.Location = New System.Drawing.Point(512, 292)
        Me.txt_TotalToPay.Name = "txt_TotalToPay"
        Me.txt_TotalToPay.Size = New System.Drawing.Size(21, 19)
        Me.txt_TotalToPay.TabIndex = 21
        Me.txt_TotalToPay.Text = "--"
        '
        'btn_BackToMenu
        '
        Me.btn_BackToMenu.Location = New System.Drawing.Point(501, 396)
        Me.btn_BackToMenu.Name = "btn_BackToMenu"
        Me.btn_BackToMenu.Size = New System.Drawing.Size(175, 35)
        Me.btn_BackToMenu.TabIndex = 20
        Me.btn_BackToMenu.Text = "Back to Menu"
        Me.btn_BackToMenu.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(512, 266)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(134, 19)
        Me.MetroLabel8.TabIndex = 19
        Me.MetroLabel8.Text = "Total Amount to Pay: "
        '
        'btn_SubmitOrder
        '
        Me.btn_SubmitOrder.Location = New System.Drawing.Point(501, 321)
        Me.btn_SubmitOrder.Name = "btn_SubmitOrder"
        Me.btn_SubmitOrder.Size = New System.Drawing.Size(175, 31)
        Me.btn_SubmitOrder.TabIndex = 18
        Me.btn_SubmitOrder.Text = "Submit Order"
        Me.btn_SubmitOrder.UseSelectable = True
        '
        'rad_CardPayment
        '
        Me.rad_CardPayment.AutoSize = True
        Me.rad_CardPayment.Location = New System.Drawing.Point(579, 91)
        Me.rad_CardPayment.Name = "rad_CardPayment"
        Me.rad_CardPayment.Size = New System.Drawing.Size(48, 15)
        Me.rad_CardPayment.TabIndex = 16
        Me.rad_CardPayment.Text = "Card"
        Me.rad_CardPayment.UseSelectable = True
        '
        'rad_CashPayment
        '
        Me.rad_CashPayment.AutoSize = True
        Me.rad_CashPayment.Checked = True
        Me.rad_CashPayment.Location = New System.Drawing.Point(512, 91)
        Me.rad_CashPayment.Name = "rad_CashPayment"
        Me.rad_CashPayment.Size = New System.Drawing.Size(49, 15)
        Me.rad_CashPayment.TabIndex = 15
        Me.rad_CashPayment.TabStop = True
        Me.rad_CashPayment.Text = "Cash"
        Me.rad_CashPayment.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(501, 60)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Payment Method:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(20, 14)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = "Checkout"
        '
        'pnl_CashPayment
        '
        Me.pnl_CashPayment.Controls.Add(Me.MetroLabel10)
        Me.pnl_CashPayment.Controls.Add(Me.txt_UserChange)
        Me.pnl_CashPayment.Controls.Add(Me.MetroLabel9)
        Me.pnl_CashPayment.Controls.Add(Me.txt_UserBalance)
        Me.pnl_CashPayment.Location = New System.Drawing.Point(501, 117)
        Me.pnl_CashPayment.Name = "pnl_CashPayment"
        Me.pnl_CashPayment.Size = New System.Drawing.Size(175, 136)
        Me.pnl_CashPayment.TabIndex = 17
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(11, 72)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel10.TabIndex = 23
        Me.MetroLabel10.Text = "Change:"
        '
        'txt_UserChange
        '
        '
        '
        '
        Me.txt_UserChange.CustomButton.Image = Nothing
        Me.txt_UserChange.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txt_UserChange.CustomButton.Name = ""
        Me.txt_UserChange.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_UserChange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_UserChange.CustomButton.TabIndex = 1
        Me.txt_UserChange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_UserChange.CustomButton.UseSelectable = True
        Me.txt_UserChange.CustomButton.Visible = False
        Me.txt_UserChange.Lines = New String(-1) {}
        Me.txt_UserChange.Location = New System.Drawing.Point(11, 94)
        Me.txt_UserChange.MaxLength = 32767
        Me.txt_UserChange.Name = "txt_UserChange"
        Me.txt_UserChange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserChange.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UserChange.SelectedText = ""
        Me.txt_UserChange.SelectionLength = 0
        Me.txt_UserChange.SelectionStart = 0
        Me.txt_UserChange.ShortcutsEnabled = True
        Me.txt_UserChange.Size = New System.Drawing.Size(150, 23)
        Me.txt_UserChange.TabIndex = 22
        Me.txt_UserChange.UseSelectable = True
        Me.txt_UserChange.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_UserChange.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(11, 17)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel9.TabIndex = 21
        Me.MetroLabel9.Text = "Balance:"
        '
        'txt_UserBalance
        '
        '
        '
        '
        Me.txt_UserBalance.CustomButton.Image = Nothing
        Me.txt_UserBalance.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txt_UserBalance.CustomButton.Name = ""
        Me.txt_UserBalance.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_UserBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_UserBalance.CustomButton.TabIndex = 1
        Me.txt_UserBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_UserBalance.CustomButton.UseSelectable = True
        Me.txt_UserBalance.CustomButton.Visible = False
        Me.txt_UserBalance.Lines = New String(-1) {}
        Me.txt_UserBalance.Location = New System.Drawing.Point(11, 39)
        Me.txt_UserBalance.MaxLength = 32767
        Me.txt_UserBalance.Name = "txt_UserBalance"
        Me.txt_UserBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UserBalance.SelectedText = ""
        Me.txt_UserBalance.SelectionLength = 0
        Me.txt_UserBalance.SelectionStart = 0
        Me.txt_UserBalance.ShortcutsEnabled = True
        Me.txt_UserBalance.Size = New System.Drawing.Size(150, 23)
        Me.txt_UserBalance.TabIndex = 0
        Me.txt_UserBalance.UseSelectable = True
        Me.txt_UserBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_UserBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pnl_CardPayment
        '
        Me.pnl_CardPayment.Controls.Add(Me.txt_CVV4)
        Me.pnl_CardPayment.Controls.Add(Me.txt_CVV3)
        Me.pnl_CardPayment.Controls.Add(Me.txt_CVV2)
        Me.pnl_CardPayment.Controls.Add(Me.MetroLabel11)
        Me.pnl_CardPayment.Controls.Add(Me.txt_CVV1)
        Me.pnl_CardPayment.Controls.Add(Me.MetroLabel12)
        Me.pnl_CardPayment.Controls.Add(Me.txt_UserCardNumber)
        Me.pnl_CardPayment.Location = New System.Drawing.Point(501, 117)
        Me.pnl_CardPayment.Name = "pnl_CardPayment"
        Me.pnl_CardPayment.Size = New System.Drawing.Size(175, 136)
        Me.pnl_CardPayment.TabIndex = 22
        '
        'txt_CVV4
        '
        '
        '
        '
        Me.txt_CVV4.CustomButton.Image = Nothing
        Me.txt_CVV4.CustomButton.Location = New System.Drawing.Point(12, 1)
        Me.txt_CVV4.CustomButton.Name = ""
        Me.txt_CVV4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_CVV4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_CVV4.CustomButton.TabIndex = 1
        Me.txt_CVV4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_CVV4.CustomButton.UseSelectable = True
        Me.txt_CVV4.CustomButton.Visible = False
        Me.txt_CVV4.Lines = New String(-1) {}
        Me.txt_CVV4.Location = New System.Drawing.Point(130, 95)
        Me.txt_CVV4.MaxLength = 32767
        Me.txt_CVV4.Name = "txt_CVV4"
        Me.txt_CVV4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CVV4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CVV4.SelectedText = ""
        Me.txt_CVV4.SelectionLength = 0
        Me.txt_CVV4.SelectionStart = 0
        Me.txt_CVV4.ShortcutsEnabled = True
        Me.txt_CVV4.Size = New System.Drawing.Size(34, 23)
        Me.txt_CVV4.TabIndex = 30
        Me.txt_CVV4.UseSelectable = True
        Me.txt_CVV4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_CVV4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_CVV3
        '
        '
        '
        '
        Me.txt_CVV3.CustomButton.Image = Nothing
        Me.txt_CVV3.CustomButton.Location = New System.Drawing.Point(12, 1)
        Me.txt_CVV3.CustomButton.Name = ""
        Me.txt_CVV3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_CVV3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_CVV3.CustomButton.TabIndex = 1
        Me.txt_CVV3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_CVV3.CustomButton.UseSelectable = True
        Me.txt_CVV3.CustomButton.Visible = False
        Me.txt_CVV3.Lines = New String(-1) {}
        Me.txt_CVV3.Location = New System.Drawing.Point(90, 95)
        Me.txt_CVV3.MaxLength = 32767
        Me.txt_CVV3.Name = "txt_CVV3"
        Me.txt_CVV3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CVV3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CVV3.SelectedText = ""
        Me.txt_CVV3.SelectionLength = 0
        Me.txt_CVV3.SelectionStart = 0
        Me.txt_CVV3.ShortcutsEnabled = True
        Me.txt_CVV3.Size = New System.Drawing.Size(34, 23)
        Me.txt_CVV3.TabIndex = 29
        Me.txt_CVV3.UseSelectable = True
        Me.txt_CVV3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_CVV3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_CVV2
        '
        '
        '
        '
        Me.txt_CVV2.CustomButton.Image = Nothing
        Me.txt_CVV2.CustomButton.Location = New System.Drawing.Point(12, 1)
        Me.txt_CVV2.CustomButton.Name = ""
        Me.txt_CVV2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_CVV2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_CVV2.CustomButton.TabIndex = 1
        Me.txt_CVV2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_CVV2.CustomButton.UseSelectable = True
        Me.txt_CVV2.CustomButton.Visible = False
        Me.txt_CVV2.Lines = New String(-1) {}
        Me.txt_CVV2.Location = New System.Drawing.Point(50, 95)
        Me.txt_CVV2.MaxLength = 32767
        Me.txt_CVV2.Name = "txt_CVV2"
        Me.txt_CVV2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CVV2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CVV2.SelectedText = ""
        Me.txt_CVV2.SelectionLength = 0
        Me.txt_CVV2.SelectionStart = 0
        Me.txt_CVV2.ShortcutsEnabled = True
        Me.txt_CVV2.Size = New System.Drawing.Size(34, 23)
        Me.txt_CVV2.TabIndex = 28
        Me.txt_CVV2.UseSelectable = True
        Me.txt_CVV2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_CVV2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(10, 73)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel11.TabIndex = 27
        Me.MetroLabel11.Text = "CVV:"
        '
        'txt_CVV1
        '
        '
        '
        '
        Me.txt_CVV1.CustomButton.Image = Nothing
        Me.txt_CVV1.CustomButton.Location = New System.Drawing.Point(12, 1)
        Me.txt_CVV1.CustomButton.Name = ""
        Me.txt_CVV1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_CVV1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_CVV1.CustomButton.TabIndex = 1
        Me.txt_CVV1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_CVV1.CustomButton.UseSelectable = True
        Me.txt_CVV1.CustomButton.Visible = False
        Me.txt_CVV1.Lines = New String(-1) {}
        Me.txt_CVV1.Location = New System.Drawing.Point(10, 95)
        Me.txt_CVV1.MaxLength = 32767
        Me.txt_CVV1.Name = "txt_CVV1"
        Me.txt_CVV1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_CVV1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CVV1.SelectedText = ""
        Me.txt_CVV1.SelectionLength = 0
        Me.txt_CVV1.SelectionStart = 0
        Me.txt_CVV1.ShortcutsEnabled = True
        Me.txt_CVV1.Size = New System.Drawing.Size(34, 23)
        Me.txt_CVV1.TabIndex = 26
        Me.txt_CVV1.UseSelectable = True
        Me.txt_CVV1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_CVV1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(10, 18)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel12.TabIndex = 25
        Me.MetroLabel12.Text = "Card Number:"
        '
        'txt_UserCardNumber
        '
        '
        '
        '
        Me.txt_UserCardNumber.CustomButton.Image = Nothing
        Me.txt_UserCardNumber.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.txt_UserCardNumber.CustomButton.Name = ""
        Me.txt_UserCardNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_UserCardNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_UserCardNumber.CustomButton.TabIndex = 1
        Me.txt_UserCardNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_UserCardNumber.CustomButton.UseSelectable = True
        Me.txt_UserCardNumber.CustomButton.Visible = False
        Me.txt_UserCardNumber.Lines = New String(-1) {}
        Me.txt_UserCardNumber.Location = New System.Drawing.Point(10, 40)
        Me.txt_UserCardNumber.MaxLength = 32767
        Me.txt_UserCardNumber.Name = "txt_UserCardNumber"
        Me.txt_UserCardNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserCardNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UserCardNumber.SelectedText = ""
        Me.txt_UserCardNumber.SelectionLength = 0
        Me.txt_UserCardNumber.SelectionStart = 0
        Me.txt_UserCardNumber.ShortcutsEnabled = True
        Me.txt_UserCardNumber.Size = New System.Drawing.Size(155, 23)
        Me.txt_UserCardNumber.TabIndex = 24
        Me.txt_UserCardNumber.UseSelectable = True
        Me.txt_UserCardNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_UserCardNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_VoidOrder
        '
        Me.btn_VoidOrder.Location = New System.Drawing.Point(501, 358)
        Me.btn_VoidOrder.Name = "btn_VoidOrder"
        Me.btn_VoidOrder.Size = New System.Drawing.Size(175, 31)
        Me.btn_VoidOrder.TabIndex = 23
        Me.btn_VoidOrder.Text = "Void Order"
        Me.btn_VoidOrder.UseSelectable = True
        '
        'txtCodetoVoid
        '
        '
        '
        '
        Me.txtCodetoVoid.CustomButton.Image = Nothing
        Me.txtCodetoVoid.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtCodetoVoid.CustomButton.Name = ""
        Me.txtCodetoVoid.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCodetoVoid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodetoVoid.CustomButton.TabIndex = 1
        Me.txtCodetoVoid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodetoVoid.CustomButton.UseSelectable = True
        Me.txtCodetoVoid.CustomButton.Visible = False
        Me.txtCodetoVoid.Lines = New String(-1) {}
        Me.txtCodetoVoid.Location = New System.Drawing.Point(515, 362)
        Me.txtCodetoVoid.MaxLength = 32767
        Me.txtCodetoVoid.Name = "txtCodetoVoid"
        Me.txtCodetoVoid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodetoVoid.PromptText = "Input code to void order"
        Me.txtCodetoVoid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodetoVoid.SelectedText = ""
        Me.txtCodetoVoid.SelectionLength = 0
        Me.txtCodetoVoid.SelectionStart = 0
        Me.txtCodetoVoid.ShortcutsEnabled = True
        Me.txtCodetoVoid.Size = New System.Drawing.Size(150, 23)
        Me.txtCodetoVoid.TabIndex = 24
        Me.txtCodetoVoid.UseSelectable = True
        Me.txtCodetoVoid.WaterMark = "Input code to void order"
        Me.txtCodetoVoid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodetoVoid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_ProceedCheckout
        '
        Me.btn_ProceedCheckout.Location = New System.Drawing.Point(539, 402)
        Me.btn_ProceedCheckout.Name = "btn_ProceedCheckout"
        Me.btn_ProceedCheckout.Size = New System.Drawing.Size(133, 35)
        Me.btn_ProceedCheckout.TabIndex = 21
        Me.btn_ProceedCheckout.Text = "Proceed Checkout"
        Me.btn_ProceedCheckout.UseSelectable = True
        '
        'pnl_MenuOrder
        '
        Me.pnl_MenuOrder.Controls.Add(Me.btn_ClearInputs)
        Me.pnl_MenuOrder.Controls.Add(Me.MetroTabControl1)
        Me.pnl_MenuOrder.Controls.Add(Me.btn_ProceedCheckout)
        Me.pnl_MenuOrder.Controls.Add(Me.MetroTabControl3)
        Me.pnl_MenuOrder.Location = New System.Drawing.Point(18, 63)
        Me.pnl_MenuOrder.Name = "pnl_MenuOrder"
        Me.pnl_MenuOrder.Size = New System.Drawing.Size(693, 455)
        Me.pnl_MenuOrder.TabIndex = 22
        '
        'btn_ClearInputs
        '
        Me.btn_ClearInputs.Location = New System.Drawing.Point(400, 402)
        Me.btn_ClearInputs.Name = "btn_ClearInputs"
        Me.btn_ClearInputs.Size = New System.Drawing.Size(133, 35)
        Me.btn_ClearInputs.TabIndex = 22
        Me.btn_ClearInputs.Text = "Clear"
        Me.btn_ClearInputs.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Location = New System.Drawing.Point(3, 8)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(466, 382)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.txtPineapplePizzaQty)
        Me.MetroTabPage1.Controls.Add(Me.txtPineapplePizzaStock)
        Me.MetroTabPage1.Controls.Add(Me.txtPepperoniPizzaQty)
        Me.MetroTabPage1.Controls.Add(Me.txtPepperoniPizzaStock)
        Me.MetroTabPage1.Controls.Add(Me.txtTomatoesPizzaQty)
        Me.MetroTabPage1.Controls.Add(Me.txtTomatoesPizzaStock)
        Me.MetroTabPage1.Controls.Add(Me.txtMushroomPizzaQty)
        Me.MetroTabPage1.Controls.Add(Me.Panel2)
        Me.MetroTabPage1.Controls.Add(Me.Panel5)
        Me.MetroTabPage1.Controls.Add(Me.Panel3)
        Me.MetroTabPage1.Controls.Add(Me.Panel1)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox1)
        Me.MetroTabPage1.Controls.Add(Me.chkPepperoniPizza)
        Me.MetroTabPage1.Controls.Add(Me.txtMushroomPizzaStock)
        Me.MetroTabPage1.Controls.Add(Me.chkTomatoesPizza)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox6)
        Me.MetroTabPage1.Controls.Add(Me.chkMushroomPizza)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox5)
        Me.MetroTabPage1.Controls.Add(Me.chkPineapplePizza)
        Me.MetroTabPage1.Controls.Add(Me.PictureBox4)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(458, 340)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Pizza"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'txtPineapplePizzaQty
        '
        '
        '
        '
        Me.txtPineapplePizzaQty.CustomButton.Image = Nothing
        Me.txtPineapplePizzaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtPineapplePizzaQty.CustomButton.Name = ""
        Me.txtPineapplePizzaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPineapplePizzaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPineapplePizzaQty.CustomButton.TabIndex = 1
        Me.txtPineapplePizzaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPineapplePizzaQty.CustomButton.UseSelectable = True
        Me.txtPineapplePizzaQty.CustomButton.Visible = False
        Me.txtPineapplePizzaQty.Lines = New String(-1) {}
        Me.txtPineapplePizzaQty.Location = New System.Drawing.Point(360, 184)
        Me.txtPineapplePizzaQty.MaxLength = 32767
        Me.txtPineapplePizzaQty.Name = "txtPineapplePizzaQty"
        Me.txtPineapplePizzaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPineapplePizzaQty.PromptText = "Qty"
        Me.txtPineapplePizzaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPineapplePizzaQty.SelectedText = ""
        Me.txtPineapplePizzaQty.SelectionLength = 0
        Me.txtPineapplePizzaQty.SelectionStart = 0
        Me.txtPineapplePizzaQty.ShortcutsEnabled = True
        Me.txtPineapplePizzaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtPineapplePizzaQty.TabIndex = 50
        Me.txtPineapplePizzaQty.UseSelectable = True
        Me.txtPineapplePizzaQty.WaterMark = "Qty"
        Me.txtPineapplePizzaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPineapplePizzaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPineapplePizzaStock
        '
        '
        '
        '
        Me.txtPineapplePizzaStock.CustomButton.Image = Nothing
        Me.txtPineapplePizzaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtPineapplePizzaStock.CustomButton.Name = ""
        Me.txtPineapplePizzaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPineapplePizzaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPineapplePizzaStock.CustomButton.TabIndex = 1
        Me.txtPineapplePizzaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPineapplePizzaStock.CustomButton.UseSelectable = True
        Me.txtPineapplePizzaStock.CustomButton.Visible = False
        Me.txtPineapplePizzaStock.Lines = New String() {"25"}
        Me.txtPineapplePizzaStock.Location = New System.Drawing.Point(402, 184)
        Me.txtPineapplePizzaStock.MaxLength = 32767
        Me.txtPineapplePizzaStock.Name = "txtPineapplePizzaStock"
        Me.txtPineapplePizzaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPineapplePizzaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPineapplePizzaStock.SelectedText = ""
        Me.txtPineapplePizzaStock.SelectionLength = 0
        Me.txtPineapplePizzaStock.SelectionStart = 0
        Me.txtPineapplePizzaStock.ShortcutsEnabled = True
        Me.txtPineapplePizzaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtPineapplePizzaStock.TabIndex = 49
        Me.txtPineapplePizzaStock.Text = "25"
        Me.txtPineapplePizzaStock.UseSelectable = True
        Me.txtPineapplePizzaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPineapplePizzaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPepperoniPizzaQty
        '
        '
        '
        '
        Me.txtPepperoniPizzaQty.CustomButton.Image = Nothing
        Me.txtPepperoniPizzaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtPepperoniPizzaQty.CustomButton.Name = ""
        Me.txtPepperoniPizzaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPepperoniPizzaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPepperoniPizzaQty.CustomButton.TabIndex = 1
        Me.txtPepperoniPizzaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPepperoniPizzaQty.CustomButton.UseSelectable = True
        Me.txtPepperoniPizzaQty.CustomButton.Visible = False
        Me.txtPepperoniPizzaQty.Lines = New String(-1) {}
        Me.txtPepperoniPizzaQty.Location = New System.Drawing.Point(133, 184)
        Me.txtPepperoniPizzaQty.MaxLength = 32767
        Me.txtPepperoniPizzaQty.Name = "txtPepperoniPizzaQty"
        Me.txtPepperoniPizzaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPepperoniPizzaQty.PromptText = "Qty"
        Me.txtPepperoniPizzaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPepperoniPizzaQty.SelectedText = ""
        Me.txtPepperoniPizzaQty.SelectionLength = 0
        Me.txtPepperoniPizzaQty.SelectionStart = 0
        Me.txtPepperoniPizzaQty.ShortcutsEnabled = True
        Me.txtPepperoniPizzaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtPepperoniPizzaQty.TabIndex = 48
        Me.txtPepperoniPizzaQty.UseSelectable = True
        Me.txtPepperoniPizzaQty.WaterMark = "Qty"
        Me.txtPepperoniPizzaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPepperoniPizzaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPepperoniPizzaStock
        '
        '
        '
        '
        Me.txtPepperoniPizzaStock.CustomButton.Image = Nothing
        Me.txtPepperoniPizzaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtPepperoniPizzaStock.CustomButton.Name = ""
        Me.txtPepperoniPizzaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPepperoniPizzaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPepperoniPizzaStock.CustomButton.TabIndex = 1
        Me.txtPepperoniPizzaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPepperoniPizzaStock.CustomButton.UseSelectable = True
        Me.txtPepperoniPizzaStock.CustomButton.Visible = False
        Me.txtPepperoniPizzaStock.Lines = New String() {"25"}
        Me.txtPepperoniPizzaStock.Location = New System.Drawing.Point(175, 184)
        Me.txtPepperoniPizzaStock.MaxLength = 32767
        Me.txtPepperoniPizzaStock.Name = "txtPepperoniPizzaStock"
        Me.txtPepperoniPizzaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPepperoniPizzaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPepperoniPizzaStock.SelectedText = ""
        Me.txtPepperoniPizzaStock.SelectionLength = 0
        Me.txtPepperoniPizzaStock.SelectionStart = 0
        Me.txtPepperoniPizzaStock.ShortcutsEnabled = True
        Me.txtPepperoniPizzaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtPepperoniPizzaStock.TabIndex = 47
        Me.txtPepperoniPizzaStock.Text = "25"
        Me.txtPepperoniPizzaStock.UseSelectable = True
        Me.txtPepperoniPizzaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPepperoniPizzaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTomatoesPizzaQty
        '
        '
        '
        '
        Me.txtTomatoesPizzaQty.CustomButton.Image = Nothing
        Me.txtTomatoesPizzaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtTomatoesPizzaQty.CustomButton.Name = ""
        Me.txtTomatoesPizzaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTomatoesPizzaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTomatoesPizzaQty.CustomButton.TabIndex = 1
        Me.txtTomatoesPizzaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTomatoesPizzaQty.CustomButton.UseSelectable = True
        Me.txtTomatoesPizzaQty.CustomButton.Visible = False
        Me.txtTomatoesPizzaQty.Lines = New String(-1) {}
        Me.txtTomatoesPizzaQty.Location = New System.Drawing.Point(360, 19)
        Me.txtTomatoesPizzaQty.MaxLength = 32767
        Me.txtTomatoesPizzaQty.Name = "txtTomatoesPizzaQty"
        Me.txtTomatoesPizzaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTomatoesPizzaQty.PromptText = "Qty"
        Me.txtTomatoesPizzaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTomatoesPizzaQty.SelectedText = ""
        Me.txtTomatoesPizzaQty.SelectionLength = 0
        Me.txtTomatoesPizzaQty.SelectionStart = 0
        Me.txtTomatoesPizzaQty.ShortcutsEnabled = True
        Me.txtTomatoesPizzaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtTomatoesPizzaQty.TabIndex = 46
        Me.txtTomatoesPizzaQty.UseSelectable = True
        Me.txtTomatoesPizzaQty.WaterMark = "Qty"
        Me.txtTomatoesPizzaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTomatoesPizzaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTomatoesPizzaStock
        '
        '
        '
        '
        Me.txtTomatoesPizzaStock.CustomButton.Image = Nothing
        Me.txtTomatoesPizzaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtTomatoesPizzaStock.CustomButton.Name = ""
        Me.txtTomatoesPizzaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTomatoesPizzaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTomatoesPizzaStock.CustomButton.TabIndex = 1
        Me.txtTomatoesPizzaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTomatoesPizzaStock.CustomButton.UseSelectable = True
        Me.txtTomatoesPizzaStock.CustomButton.Visible = False
        Me.txtTomatoesPizzaStock.Lines = New String() {"25"}
        Me.txtTomatoesPizzaStock.Location = New System.Drawing.Point(402, 19)
        Me.txtTomatoesPizzaStock.MaxLength = 32767
        Me.txtTomatoesPizzaStock.Name = "txtTomatoesPizzaStock"
        Me.txtTomatoesPizzaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTomatoesPizzaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTomatoesPizzaStock.SelectedText = ""
        Me.txtTomatoesPizzaStock.SelectionLength = 0
        Me.txtTomatoesPizzaStock.SelectionStart = 0
        Me.txtTomatoesPizzaStock.ShortcutsEnabled = True
        Me.txtTomatoesPizzaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtTomatoesPizzaStock.TabIndex = 45
        Me.txtTomatoesPizzaStock.Text = "25"
        Me.txtTomatoesPizzaStock.UseSelectable = True
        Me.txtTomatoesPizzaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTomatoesPizzaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMushroomPizzaQty
        '
        '
        '
        '
        Me.txtMushroomPizzaQty.CustomButton.Image = Nothing
        Me.txtMushroomPizzaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtMushroomPizzaQty.CustomButton.Name = ""
        Me.txtMushroomPizzaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMushroomPizzaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMushroomPizzaQty.CustomButton.TabIndex = 1
        Me.txtMushroomPizzaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMushroomPizzaQty.CustomButton.UseSelectable = True
        Me.txtMushroomPizzaQty.CustomButton.Visible = False
        Me.txtMushroomPizzaQty.Lines = New String(-1) {}
        Me.txtMushroomPizzaQty.Location = New System.Drawing.Point(133, 19)
        Me.txtMushroomPizzaQty.MaxLength = 2
        Me.txtMushroomPizzaQty.Name = "txtMushroomPizzaQty"
        Me.txtMushroomPizzaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMushroomPizzaQty.PromptText = "Qty"
        Me.txtMushroomPizzaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMushroomPizzaQty.SelectedText = ""
        Me.txtMushroomPizzaQty.SelectionLength = 0
        Me.txtMushroomPizzaQty.SelectionStart = 0
        Me.txtMushroomPizzaQty.ShortcutsEnabled = True
        Me.txtMushroomPizzaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtMushroomPizzaQty.TabIndex = 44
        Me.txtMushroomPizzaQty.UseSelectable = True
        Me.txtMushroomPizzaQty.WaterMark = "Qty"
        Me.txtMushroomPizzaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMushroomPizzaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.radSmallTomatoesPizza)
        Me.Panel2.Controls.Add(Me.radMediumTomatoesPizza)
        Me.Panel2.Controls.Add(Me.radLargeTomatoesPizza)
        Me.Panel2.Location = New System.Drawing.Point(360, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(72, 73)
        Me.Panel2.TabIndex = 42
        '
        'radSmallTomatoesPizza
        '
        Me.radSmallTomatoesPizza.AutoSize = True
        Me.radSmallTomatoesPizza.Checked = True
        Me.radSmallTomatoesPizza.Location = New System.Drawing.Point(8, 5)
        Me.radSmallTomatoesPizza.Name = "radSmallTomatoesPizza"
        Me.radSmallTomatoesPizza.Size = New System.Drawing.Size(52, 15)
        Me.radSmallTomatoesPizza.TabIndex = 29
        Me.radSmallTomatoesPizza.TabStop = True
        Me.radSmallTomatoesPizza.Text = "S - $2"
        Me.radSmallTomatoesPizza.UseSelectable = True
        '
        'radMediumTomatoesPizza
        '
        Me.radMediumTomatoesPizza.AutoSize = True
        Me.radMediumTomatoesPizza.Location = New System.Drawing.Point(8, 26)
        Me.radMediumTomatoesPizza.Name = "radMediumTomatoesPizza"
        Me.radMediumTomatoesPizza.Size = New System.Drawing.Size(57, 15)
        Me.radMediumTomatoesPizza.TabIndex = 30
        Me.radMediumTomatoesPizza.Text = "M - $5"
        Me.radMediumTomatoesPizza.UseSelectable = True
        '
        'radLargeTomatoesPizza
        '
        Me.radLargeTomatoesPizza.AutoSize = True
        Me.radLargeTomatoesPizza.Location = New System.Drawing.Point(8, 47)
        Me.radLargeTomatoesPizza.Name = "radLargeTomatoesPizza"
        Me.radLargeTomatoesPizza.Size = New System.Drawing.Size(52, 15)
        Me.radLargeTomatoesPizza.TabIndex = 31
        Me.radLargeTomatoesPizza.Text = "L - $7"
        Me.radLargeTomatoesPizza.UseSelectable = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.radSmallPineapplePizza)
        Me.Panel5.Controls.Add(Me.radMediumPineapplePizza)
        Me.Panel5.Controls.Add(Me.radLargePineapplePizza)
        Me.Panel5.Location = New System.Drawing.Point(360, 213)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(72, 73)
        Me.Panel5.TabIndex = 43
        '
        'radSmallPineapplePizza
        '
        Me.radSmallPineapplePizza.AutoSize = True
        Me.radSmallPineapplePizza.Checked = True
        Me.radSmallPineapplePizza.Location = New System.Drawing.Point(8, 5)
        Me.radSmallPineapplePizza.Name = "radSmallPineapplePizza"
        Me.radSmallPineapplePizza.Size = New System.Drawing.Size(52, 15)
        Me.radSmallPineapplePizza.TabIndex = 29
        Me.radSmallPineapplePizza.TabStop = True
        Me.radSmallPineapplePizza.Text = "S - $4"
        Me.radSmallPineapplePizza.UseSelectable = True
        '
        'radMediumPineapplePizza
        '
        Me.radMediumPineapplePizza.AutoSize = True
        Me.radMediumPineapplePizza.Location = New System.Drawing.Point(8, 26)
        Me.radMediumPineapplePizza.Name = "radMediumPineapplePizza"
        Me.radMediumPineapplePizza.Size = New System.Drawing.Size(57, 15)
        Me.radMediumPineapplePizza.TabIndex = 30
        Me.radMediumPineapplePizza.Text = "M - $7"
        Me.radMediumPineapplePizza.UseSelectable = True
        '
        'radLargePineapplePizza
        '
        Me.radLargePineapplePizza.AutoSize = True
        Me.radLargePineapplePizza.Location = New System.Drawing.Point(8, 47)
        Me.radLargePineapplePizza.Name = "radLargePineapplePizza"
        Me.radLargePineapplePizza.Size = New System.Drawing.Size(58, 15)
        Me.radLargePineapplePizza.TabIndex = 31
        Me.radLargePineapplePizza.Text = "L - $10"
        Me.radLargePineapplePizza.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.radSmallPepperoniPizza)
        Me.Panel3.Controls.Add(Me.radMediumPepperoniPizza)
        Me.Panel3.Controls.Add(Me.radLargePepperoniPizza)
        Me.Panel3.Location = New System.Drawing.Point(133, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 73)
        Me.Panel3.TabIndex = 42
        '
        'radSmallPepperoniPizza
        '
        Me.radSmallPepperoniPizza.AutoSize = True
        Me.radSmallPepperoniPizza.Checked = True
        Me.radSmallPepperoniPizza.Location = New System.Drawing.Point(8, 5)
        Me.radSmallPepperoniPizza.Name = "radSmallPepperoniPizza"
        Me.radSmallPepperoniPizza.Size = New System.Drawing.Size(52, 15)
        Me.radSmallPepperoniPizza.TabIndex = 29
        Me.radSmallPepperoniPizza.TabStop = True
        Me.radSmallPepperoniPizza.Text = "S - $4"
        Me.radSmallPepperoniPizza.UseSelectable = True
        '
        'radMediumPepperoniPizza
        '
        Me.radMediumPepperoniPizza.AutoSize = True
        Me.radMediumPepperoniPizza.Location = New System.Drawing.Point(8, 26)
        Me.radMediumPepperoniPizza.Name = "radMediumPepperoniPizza"
        Me.radMediumPepperoniPizza.Size = New System.Drawing.Size(57, 15)
        Me.radMediumPepperoniPizza.TabIndex = 30
        Me.radMediumPepperoniPizza.Text = "M - $7"
        Me.radMediumPepperoniPizza.UseSelectable = True
        '
        'radLargePepperoniPizza
        '
        Me.radLargePepperoniPizza.AutoSize = True
        Me.radLargePepperoniPizza.Location = New System.Drawing.Point(8, 47)
        Me.radLargePepperoniPizza.Name = "radLargePepperoniPizza"
        Me.radLargePepperoniPizza.Size = New System.Drawing.Size(58, 15)
        Me.radLargePepperoniPizza.TabIndex = 31
        Me.radLargePepperoniPizza.Text = "L - $10"
        Me.radLargePepperoniPizza.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.radSmallMushroomPizza)
        Me.Panel1.Controls.Add(Me.radMediumMushroomPizza)
        Me.Panel1.Controls.Add(Me.radLargeMushroomPizza)
        Me.Panel1.Location = New System.Drawing.Point(133, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(72, 73)
        Me.Panel1.TabIndex = 41
        '
        'radSmallMushroomPizza
        '
        Me.radSmallMushroomPizza.AutoSize = True
        Me.radSmallMushroomPizza.Checked = True
        Me.radSmallMushroomPizza.Location = New System.Drawing.Point(8, 5)
        Me.radSmallMushroomPizza.Name = "radSmallMushroomPizza"
        Me.radSmallMushroomPizza.Size = New System.Drawing.Size(52, 15)
        Me.radSmallMushroomPizza.TabIndex = 29
        Me.radSmallMushroomPizza.TabStop = True
        Me.radSmallMushroomPizza.Text = "S - $2"
        Me.radSmallMushroomPizza.UseSelectable = True
        '
        'radMediumMushroomPizza
        '
        Me.radMediumMushroomPizza.AutoSize = True
        Me.radMediumMushroomPizza.Location = New System.Drawing.Point(8, 26)
        Me.radMediumMushroomPizza.Name = "radMediumMushroomPizza"
        Me.radMediumMushroomPizza.Size = New System.Drawing.Size(57, 15)
        Me.radMediumMushroomPizza.TabIndex = 30
        Me.radMediumMushroomPizza.Text = "M - $5"
        Me.radMediumMushroomPizza.UseSelectable = True
        '
        'radLargeMushroomPizza
        '
        Me.radLargeMushroomPizza.AutoSize = True
        Me.radLargeMushroomPizza.Location = New System.Drawing.Point(8, 47)
        Me.radLargeMushroomPizza.Name = "radLargeMushroomPizza"
        Me.radLargeMushroomPizza.Size = New System.Drawing.Size(52, 15)
        Me.radLargeMushroomPizza.TabIndex = 31
        Me.radLargeMushroomPizza.Text = "L - $7"
        Me.radLargeMushroomPizza.UseSelectable = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'chkPepperoniPizza
        '
        Me.chkPepperoniPizza.AutoSize = True
        Me.chkPepperoniPizza.Location = New System.Drawing.Point(22, 292)
        Me.chkPepperoniPizza.Name = "chkPepperoniPizza"
        Me.chkPepperoniPizza.Size = New System.Drawing.Size(106, 15)
        Me.chkPepperoniPizza.TabIndex = 18
        Me.chkPepperoniPizza.Text = "Pepperoni Pizza"
        Me.chkPepperoniPizza.UseSelectable = True
        '
        'txtMushroomPizzaStock
        '
        '
        '
        '
        Me.txtMushroomPizzaStock.CustomButton.Image = Nothing
        Me.txtMushroomPizzaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtMushroomPizzaStock.CustomButton.Name = ""
        Me.txtMushroomPizzaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMushroomPizzaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMushroomPizzaStock.CustomButton.TabIndex = 1
        Me.txtMushroomPizzaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMushroomPizzaStock.CustomButton.UseSelectable = True
        Me.txtMushroomPizzaStock.CustomButton.Visible = False
        Me.txtMushroomPizzaStock.Lines = New String() {"25"}
        Me.txtMushroomPizzaStock.Location = New System.Drawing.Point(175, 19)
        Me.txtMushroomPizzaStock.MaxLength = 32767
        Me.txtMushroomPizzaStock.Name = "txtMushroomPizzaStock"
        Me.txtMushroomPizzaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMushroomPizzaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMushroomPizzaStock.SelectedText = ""
        Me.txtMushroomPizzaStock.SelectionLength = 0
        Me.txtMushroomPizzaStock.SelectionStart = 0
        Me.txtMushroomPizzaStock.ShortcutsEnabled = True
        Me.txtMushroomPizzaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtMushroomPizzaStock.TabIndex = 37
        Me.txtMushroomPizzaStock.Text = "25"
        Me.txtMushroomPizzaStock.UseSelectable = True
        Me.txtMushroomPizzaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMushroomPizzaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkTomatoesPizza
        '
        Me.chkTomatoesPizza.AutoSize = True
        Me.chkTomatoesPizza.Location = New System.Drawing.Point(249, 127)
        Me.chkTomatoesPizza.Name = "chkTomatoesPizza"
        Me.chkTomatoesPizza.Size = New System.Drawing.Size(163, 15)
        Me.chkTomatoesPizza.TabIndex = 33
        Me.chkTomatoesPizza.Text = "Regular Pizza w/ Tomatoes"
        Me.chkTomatoesPizza.UseSelectable = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(249, 19)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'chkMushroomPizza
        '
        Me.chkMushroomPizza.AutoSize = True
        Me.chkMushroomPizza.Location = New System.Drawing.Point(22, 127)
        Me.chkMushroomPizza.Name = "chkMushroomPizza"
        Me.chkMushroomPizza.Size = New System.Drawing.Size(171, 15)
        Me.chkMushroomPizza.TabIndex = 28
        Me.chkMushroomPizza.Text = "Regular Pizza w/ Mushroom"
        Me.chkMushroomPizza.UseSelectable = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(22, 19)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'chkPineapplePizza
        '
        Me.chkPineapplePizza.AutoSize = True
        Me.chkPineapplePizza.Location = New System.Drawing.Point(249, 292)
        Me.chkPineapplePizza.Name = "chkPineapplePizza"
        Me.chkPineapplePizza.Size = New System.Drawing.Size(156, 15)
        Me.chkPineapplePizza.TabIndex = 23
        Me.chkPineapplePizza.Text = "Pineapple and Ham Pizza"
        Me.chkPineapplePizza.UseSelectable = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(249, 184)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage4.Controls.Add(Me.txtMacAndCheeseQty)
        Me.MetroTabPage4.Controls.Add(Me.txtMacAndCheeseStock)
        Me.MetroTabPage4.Controls.Add(Me.txtLasagnaQty)
        Me.MetroTabPage4.Controls.Add(Me.txtLasagnaStock)
        Me.MetroTabPage4.Controls.Add(Me.txtCarbonaraQty)
        Me.MetroTabPage4.Controls.Add(Me.txtCarbonaraStock)
        Me.MetroTabPage4.Controls.Add(Me.txtSpaghettiQty)
        Me.MetroTabPage4.Controls.Add(Me.txtSpaghettiStock)
        Me.MetroTabPage4.Controls.Add(Me.PictureBox2)
        Me.MetroTabPage4.Controls.Add(Me.chkLasagna)
        Me.MetroTabPage4.Controls.Add(Me.chkCarbonara)
        Me.MetroTabPage4.Controls.Add(Me.PictureBox9)
        Me.MetroTabPage4.Controls.Add(Me.chkSpaghetti)
        Me.MetroTabPage4.Controls.Add(Me.PictureBox10)
        Me.MetroTabPage4.Controls.Add(Me.chkMacAndCheese)
        Me.MetroTabPage4.Controls.Add(Me.PictureBox11)
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.HorizontalScrollbarSize = 10
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(458, 340)
        Me.MetroTabPage4.TabIndex = 1
        Me.MetroTabPage4.Text = "Pasta"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        Me.MetroTabPage4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage4.VerticalScrollbarSize = 10
        '
        'txtMacAndCheeseQty
        '
        '
        '
        '
        Me.txtMacAndCheeseQty.CustomButton.Image = Nothing
        Me.txtMacAndCheeseQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtMacAndCheeseQty.CustomButton.Name = ""
        Me.txtMacAndCheeseQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMacAndCheeseQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMacAndCheeseQty.CustomButton.TabIndex = 1
        Me.txtMacAndCheeseQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMacAndCheeseQty.CustomButton.UseSelectable = True
        Me.txtMacAndCheeseQty.CustomButton.Visible = False
        Me.txtMacAndCheeseQty.Lines = New String(-1) {}
        Me.txtMacAndCheeseQty.Location = New System.Drawing.Point(360, 184)
        Me.txtMacAndCheeseQty.MaxLength = 32767
        Me.txtMacAndCheeseQty.Name = "txtMacAndCheeseQty"
        Me.txtMacAndCheeseQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMacAndCheeseQty.PromptText = "Qty"
        Me.txtMacAndCheeseQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMacAndCheeseQty.SelectedText = ""
        Me.txtMacAndCheeseQty.SelectionLength = 0
        Me.txtMacAndCheeseQty.SelectionStart = 0
        Me.txtMacAndCheeseQty.ShortcutsEnabled = True
        Me.txtMacAndCheeseQty.Size = New System.Drawing.Size(36, 23)
        Me.txtMacAndCheeseQty.TabIndex = 63
        Me.txtMacAndCheeseQty.UseSelectable = True
        Me.txtMacAndCheeseQty.WaterMark = "Qty"
        Me.txtMacAndCheeseQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMacAndCheeseQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMacAndCheeseStock
        '
        '
        '
        '
        Me.txtMacAndCheeseStock.CustomButton.Image = Nothing
        Me.txtMacAndCheeseStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtMacAndCheeseStock.CustomButton.Name = ""
        Me.txtMacAndCheeseStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMacAndCheeseStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMacAndCheeseStock.CustomButton.TabIndex = 1
        Me.txtMacAndCheeseStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMacAndCheeseStock.CustomButton.UseSelectable = True
        Me.txtMacAndCheeseStock.CustomButton.Visible = False
        Me.txtMacAndCheeseStock.Lines = New String() {"25"}
        Me.txtMacAndCheeseStock.Location = New System.Drawing.Point(402, 184)
        Me.txtMacAndCheeseStock.MaxLength = 32767
        Me.txtMacAndCheeseStock.Name = "txtMacAndCheeseStock"
        Me.txtMacAndCheeseStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMacAndCheeseStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMacAndCheeseStock.SelectedText = ""
        Me.txtMacAndCheeseStock.SelectionLength = 0
        Me.txtMacAndCheeseStock.SelectionStart = 0
        Me.txtMacAndCheeseStock.ShortcutsEnabled = True
        Me.txtMacAndCheeseStock.Size = New System.Drawing.Size(30, 23)
        Me.txtMacAndCheeseStock.TabIndex = 62
        Me.txtMacAndCheeseStock.Text = "25"
        Me.txtMacAndCheeseStock.UseSelectable = True
        Me.txtMacAndCheeseStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMacAndCheeseStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLasagnaQty
        '
        '
        '
        '
        Me.txtLasagnaQty.CustomButton.Image = Nothing
        Me.txtLasagnaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtLasagnaQty.CustomButton.Name = ""
        Me.txtLasagnaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLasagnaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLasagnaQty.CustomButton.TabIndex = 1
        Me.txtLasagnaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLasagnaQty.CustomButton.UseSelectable = True
        Me.txtLasagnaQty.CustomButton.Visible = False
        Me.txtLasagnaQty.Lines = New String(-1) {}
        Me.txtLasagnaQty.Location = New System.Drawing.Point(133, 184)
        Me.txtLasagnaQty.MaxLength = 32767
        Me.txtLasagnaQty.Name = "txtLasagnaQty"
        Me.txtLasagnaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLasagnaQty.PromptText = "Qty"
        Me.txtLasagnaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLasagnaQty.SelectedText = ""
        Me.txtLasagnaQty.SelectionLength = 0
        Me.txtLasagnaQty.SelectionStart = 0
        Me.txtLasagnaQty.ShortcutsEnabled = True
        Me.txtLasagnaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtLasagnaQty.TabIndex = 61
        Me.txtLasagnaQty.UseSelectable = True
        Me.txtLasagnaQty.WaterMark = "Qty"
        Me.txtLasagnaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLasagnaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLasagnaStock
        '
        '
        '
        '
        Me.txtLasagnaStock.CustomButton.Image = Nothing
        Me.txtLasagnaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtLasagnaStock.CustomButton.Name = ""
        Me.txtLasagnaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLasagnaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLasagnaStock.CustomButton.TabIndex = 1
        Me.txtLasagnaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLasagnaStock.CustomButton.UseSelectable = True
        Me.txtLasagnaStock.CustomButton.Visible = False
        Me.txtLasagnaStock.Lines = New String() {"25"}
        Me.txtLasagnaStock.Location = New System.Drawing.Point(175, 184)
        Me.txtLasagnaStock.MaxLength = 32767
        Me.txtLasagnaStock.Name = "txtLasagnaStock"
        Me.txtLasagnaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLasagnaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLasagnaStock.SelectedText = ""
        Me.txtLasagnaStock.SelectionLength = 0
        Me.txtLasagnaStock.SelectionStart = 0
        Me.txtLasagnaStock.ShortcutsEnabled = True
        Me.txtLasagnaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtLasagnaStock.TabIndex = 60
        Me.txtLasagnaStock.Text = "25"
        Me.txtLasagnaStock.UseSelectable = True
        Me.txtLasagnaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLasagnaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCarbonaraQty
        '
        '
        '
        '
        Me.txtCarbonaraQty.CustomButton.Image = Nothing
        Me.txtCarbonaraQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtCarbonaraQty.CustomButton.Name = ""
        Me.txtCarbonaraQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCarbonaraQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCarbonaraQty.CustomButton.TabIndex = 1
        Me.txtCarbonaraQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCarbonaraQty.CustomButton.UseSelectable = True
        Me.txtCarbonaraQty.CustomButton.Visible = False
        Me.txtCarbonaraQty.Lines = New String(-1) {}
        Me.txtCarbonaraQty.Location = New System.Drawing.Point(360, 19)
        Me.txtCarbonaraQty.MaxLength = 32767
        Me.txtCarbonaraQty.Name = "txtCarbonaraQty"
        Me.txtCarbonaraQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarbonaraQty.PromptText = "Qty"
        Me.txtCarbonaraQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCarbonaraQty.SelectedText = ""
        Me.txtCarbonaraQty.SelectionLength = 0
        Me.txtCarbonaraQty.SelectionStart = 0
        Me.txtCarbonaraQty.ShortcutsEnabled = True
        Me.txtCarbonaraQty.Size = New System.Drawing.Size(36, 23)
        Me.txtCarbonaraQty.TabIndex = 59
        Me.txtCarbonaraQty.UseSelectable = True
        Me.txtCarbonaraQty.WaterMark = "Qty"
        Me.txtCarbonaraQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCarbonaraQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCarbonaraStock
        '
        '
        '
        '
        Me.txtCarbonaraStock.CustomButton.Image = Nothing
        Me.txtCarbonaraStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtCarbonaraStock.CustomButton.Name = ""
        Me.txtCarbonaraStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCarbonaraStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCarbonaraStock.CustomButton.TabIndex = 1
        Me.txtCarbonaraStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCarbonaraStock.CustomButton.UseSelectable = True
        Me.txtCarbonaraStock.CustomButton.Visible = False
        Me.txtCarbonaraStock.Lines = New String() {"25"}
        Me.txtCarbonaraStock.Location = New System.Drawing.Point(402, 19)
        Me.txtCarbonaraStock.MaxLength = 32767
        Me.txtCarbonaraStock.Name = "txtCarbonaraStock"
        Me.txtCarbonaraStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCarbonaraStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCarbonaraStock.SelectedText = ""
        Me.txtCarbonaraStock.SelectionLength = 0
        Me.txtCarbonaraStock.SelectionStart = 0
        Me.txtCarbonaraStock.ShortcutsEnabled = True
        Me.txtCarbonaraStock.Size = New System.Drawing.Size(30, 23)
        Me.txtCarbonaraStock.TabIndex = 58
        Me.txtCarbonaraStock.Text = "25"
        Me.txtCarbonaraStock.UseSelectable = True
        Me.txtCarbonaraStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCarbonaraStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSpaghettiQty
        '
        '
        '
        '
        Me.txtSpaghettiQty.CustomButton.Image = Nothing
        Me.txtSpaghettiQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtSpaghettiQty.CustomButton.Name = ""
        Me.txtSpaghettiQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSpaghettiQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSpaghettiQty.CustomButton.TabIndex = 1
        Me.txtSpaghettiQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSpaghettiQty.CustomButton.UseSelectable = True
        Me.txtSpaghettiQty.CustomButton.Visible = False
        Me.txtSpaghettiQty.Lines = New String(-1) {}
        Me.txtSpaghettiQty.Location = New System.Drawing.Point(133, 19)
        Me.txtSpaghettiQty.MaxLength = 32767
        Me.txtSpaghettiQty.Name = "txtSpaghettiQty"
        Me.txtSpaghettiQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSpaghettiQty.PromptText = "Qty"
        Me.txtSpaghettiQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSpaghettiQty.SelectedText = ""
        Me.txtSpaghettiQty.SelectionLength = 0
        Me.txtSpaghettiQty.SelectionStart = 0
        Me.txtSpaghettiQty.ShortcutsEnabled = True
        Me.txtSpaghettiQty.Size = New System.Drawing.Size(36, 23)
        Me.txtSpaghettiQty.TabIndex = 57
        Me.txtSpaghettiQty.UseSelectable = True
        Me.txtSpaghettiQty.WaterMark = "Qty"
        Me.txtSpaghettiQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSpaghettiQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtSpaghettiStock
        '
        '
        '
        '
        Me.txtSpaghettiStock.CustomButton.Image = Nothing
        Me.txtSpaghettiStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtSpaghettiStock.CustomButton.Name = ""
        Me.txtSpaghettiStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSpaghettiStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSpaghettiStock.CustomButton.TabIndex = 1
        Me.txtSpaghettiStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSpaghettiStock.CustomButton.UseSelectable = True
        Me.txtSpaghettiStock.CustomButton.Visible = False
        Me.txtSpaghettiStock.Lines = New String() {"25"}
        Me.txtSpaghettiStock.Location = New System.Drawing.Point(175, 19)
        Me.txtSpaghettiStock.MaxLength = 32767
        Me.txtSpaghettiStock.Name = "txtSpaghettiStock"
        Me.txtSpaghettiStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSpaghettiStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSpaghettiStock.SelectedText = ""
        Me.txtSpaghettiStock.SelectionLength = 0
        Me.txtSpaghettiStock.SelectionStart = 0
        Me.txtSpaghettiStock.ShortcutsEnabled = True
        Me.txtSpaghettiStock.Size = New System.Drawing.Size(30, 23)
        Me.txtSpaghettiStock.TabIndex = 56
        Me.txtSpaghettiStock.Text = "25"
        Me.txtSpaghettiStock.UseSelectable = True
        Me.txtSpaghettiStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSpaghettiStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(22, 184)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'chkLasagna
        '
        Me.chkLasagna.AutoSize = True
        Me.chkLasagna.Location = New System.Drawing.Point(22, 292)
        Me.chkLasagna.Name = "chkLasagna"
        Me.chkLasagna.Size = New System.Drawing.Size(89, 15)
        Me.chkLasagna.TabIndex = 45
        Me.chkLasagna.Text = "Lasagna - $4"
        Me.chkLasagna.UseSelectable = True
        '
        'chkCarbonara
        '
        Me.chkCarbonara.AutoSize = True
        Me.chkCarbonara.Location = New System.Drawing.Point(249, 127)
        Me.chkCarbonara.Name = "chkCarbonara"
        Me.chkCarbonara.Size = New System.Drawing.Size(101, 15)
        Me.chkCarbonara.TabIndex = 51
        Me.chkCarbonara.Text = "Carbonara - $3"
        Me.chkCarbonara.UseSelectable = True
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(249, 19)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 50
        Me.PictureBox9.TabStop = False
        '
        'chkSpaghetti
        '
        Me.chkSpaghetti.AutoSize = True
        Me.chkSpaghetti.Location = New System.Drawing.Point(22, 127)
        Me.chkSpaghetti.Name = "chkSpaghetti"
        Me.chkSpaghetti.Size = New System.Drawing.Size(96, 15)
        Me.chkSpaghetti.TabIndex = 49
        Me.chkSpaghetti.Text = "Spaghetti - $2"
        Me.chkSpaghetti.UseSelectable = True
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(22, 19)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 48
        Me.PictureBox10.TabStop = False
        '
        'chkMacAndCheese
        '
        Me.chkMacAndCheese.AutoSize = True
        Me.chkMacAndCheese.Location = New System.Drawing.Point(249, 292)
        Me.chkMacAndCheese.Name = "chkMacAndCheese"
        Me.chkMacAndCheese.Size = New System.Drawing.Size(160, 15)
        Me.chkMacAndCheese.TabIndex = 47
        Me.chkMacAndCheese.Text = "Macaroni and Cheese - $4"
        Me.chkMacAndCheese.UseSelectable = True
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(249, 184)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(105, 102)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 46
        Me.PictureBox11.TabStop = False
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl3.Location = New System.Drawing.Point(475, 8)
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(201, 382)
        Me.MetroTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl3.TabIndex = 0
        Me.MetroTabControl3.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage3.Controls.Add(Me.txtWaterQty)
        Me.MetroTabPage3.Controls.Add(Me.txtWaterStock)
        Me.MetroTabPage3.Controls.Add(Me.txtChocoQty)
        Me.MetroTabPage3.Controls.Add(Me.txtChocoStock)
        Me.MetroTabPage3.Controls.Add(Me.txtColaQty)
        Me.MetroTabPage3.Controls.Add(Me.txtColaStock)
        Me.MetroTabPage3.Controls.Add(Me.chkWater)
        Me.MetroTabPage3.Controls.Add(Me.chkChoco)
        Me.MetroTabPage3.Controls.Add(Me.chkCola)
        Me.MetroTabPage3.Controls.Add(Me.PictureBox8)
        Me.MetroTabPage3.Controls.Add(Me.PictureBox3)
        Me.MetroTabPage3.Controls.Add(Me.PictureBox7)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(193, 340)
        Me.MetroTabPage3.TabIndex = 0
        Me.MetroTabPage3.Text = "Drinks"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'txtWaterQty
        '
        '
        '
        '
        Me.txtWaterQty.CustomButton.Image = Nothing
        Me.txtWaterQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtWaterQty.CustomButton.Name = ""
        Me.txtWaterQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtWaterQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtWaterQty.CustomButton.TabIndex = 1
        Me.txtWaterQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWaterQty.CustomButton.UseSelectable = True
        Me.txtWaterQty.CustomButton.Visible = False
        Me.txtWaterQty.Lines = New String(-1) {}
        Me.txtWaterQty.Location = New System.Drawing.Point(96, 270)
        Me.txtWaterQty.MaxLength = 32767
        Me.txtWaterQty.Name = "txtWaterQty"
        Me.txtWaterQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWaterQty.PromptText = "Qty"
        Me.txtWaterQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWaterQty.SelectedText = ""
        Me.txtWaterQty.SelectionLength = 0
        Me.txtWaterQty.SelectionStart = 0
        Me.txtWaterQty.ShortcutsEnabled = True
        Me.txtWaterQty.Size = New System.Drawing.Size(36, 23)
        Me.txtWaterQty.TabIndex = 50
        Me.txtWaterQty.UseSelectable = True
        Me.txtWaterQty.WaterMark = "Qty"
        Me.txtWaterQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtWaterQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtWaterStock
        '
        '
        '
        '
        Me.txtWaterStock.CustomButton.Image = Nothing
        Me.txtWaterStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtWaterStock.CustomButton.Name = ""
        Me.txtWaterStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtWaterStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtWaterStock.CustomButton.TabIndex = 1
        Me.txtWaterStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtWaterStock.CustomButton.UseSelectable = True
        Me.txtWaterStock.CustomButton.Visible = False
        Me.txtWaterStock.Lines = New String() {"∞"}
        Me.txtWaterStock.Location = New System.Drawing.Point(138, 270)
        Me.txtWaterStock.MaxLength = 32767
        Me.txtWaterStock.Name = "txtWaterStock"
        Me.txtWaterStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWaterStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtWaterStock.SelectedText = ""
        Me.txtWaterStock.SelectionLength = 0
        Me.txtWaterStock.SelectionStart = 0
        Me.txtWaterStock.ShortcutsEnabled = True
        Me.txtWaterStock.Size = New System.Drawing.Size(30, 23)
        Me.txtWaterStock.TabIndex = 49
        Me.txtWaterStock.Text = "∞"
        Me.txtWaterStock.UseSelectable = True
        Me.txtWaterStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtWaterStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtChocoQty
        '
        '
        '
        '
        Me.txtChocoQty.CustomButton.Image = Nothing
        Me.txtChocoQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtChocoQty.CustomButton.Name = ""
        Me.txtChocoQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtChocoQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChocoQty.CustomButton.TabIndex = 1
        Me.txtChocoQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChocoQty.CustomButton.UseSelectable = True
        Me.txtChocoQty.CustomButton.Visible = False
        Me.txtChocoQty.Lines = New String(-1) {}
        Me.txtChocoQty.Location = New System.Drawing.Point(96, 169)
        Me.txtChocoQty.MaxLength = 32767
        Me.txtChocoQty.Name = "txtChocoQty"
        Me.txtChocoQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChocoQty.PromptText = "Qty"
        Me.txtChocoQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChocoQty.SelectedText = ""
        Me.txtChocoQty.SelectionLength = 0
        Me.txtChocoQty.SelectionStart = 0
        Me.txtChocoQty.ShortcutsEnabled = True
        Me.txtChocoQty.Size = New System.Drawing.Size(36, 23)
        Me.txtChocoQty.TabIndex = 48
        Me.txtChocoQty.UseSelectable = True
        Me.txtChocoQty.WaterMark = "Qty"
        Me.txtChocoQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChocoQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtChocoStock
        '
        '
        '
        '
        Me.txtChocoStock.CustomButton.Image = Nothing
        Me.txtChocoStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtChocoStock.CustomButton.Name = ""
        Me.txtChocoStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtChocoStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtChocoStock.CustomButton.TabIndex = 1
        Me.txtChocoStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtChocoStock.CustomButton.UseSelectable = True
        Me.txtChocoStock.CustomButton.Visible = False
        Me.txtChocoStock.Lines = New String() {"25"}
        Me.txtChocoStock.Location = New System.Drawing.Point(138, 169)
        Me.txtChocoStock.MaxLength = 32767
        Me.txtChocoStock.Name = "txtChocoStock"
        Me.txtChocoStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChocoStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtChocoStock.SelectedText = ""
        Me.txtChocoStock.SelectionLength = 0
        Me.txtChocoStock.SelectionStart = 0
        Me.txtChocoStock.ShortcutsEnabled = True
        Me.txtChocoStock.Size = New System.Drawing.Size(30, 23)
        Me.txtChocoStock.TabIndex = 47
        Me.txtChocoStock.Text = "25"
        Me.txtChocoStock.UseSelectable = True
        Me.txtChocoStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtChocoStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColaQty
        '
        '
        '
        '
        Me.txtColaQty.CustomButton.Image = Nothing
        Me.txtColaQty.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.txtColaQty.CustomButton.Name = ""
        Me.txtColaQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtColaQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColaQty.CustomButton.TabIndex = 1
        Me.txtColaQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColaQty.CustomButton.UseSelectable = True
        Me.txtColaQty.CustomButton.Visible = False
        Me.txtColaQty.Lines = New String(-1) {}
        Me.txtColaQty.Location = New System.Drawing.Point(96, 65)
        Me.txtColaQty.MaxLength = 32767
        Me.txtColaQty.Name = "txtColaQty"
        Me.txtColaQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColaQty.PromptText = "Qty"
        Me.txtColaQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColaQty.SelectedText = ""
        Me.txtColaQty.SelectionLength = 0
        Me.txtColaQty.SelectionStart = 0
        Me.txtColaQty.ShortcutsEnabled = True
        Me.txtColaQty.Size = New System.Drawing.Size(36, 23)
        Me.txtColaQty.TabIndex = 46
        Me.txtColaQty.UseSelectable = True
        Me.txtColaQty.WaterMark = "Qty"
        Me.txtColaQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtColaQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtColaStock
        '
        '
        '
        '
        Me.txtColaStock.CustomButton.Image = Nothing
        Me.txtColaStock.CustomButton.Location = New System.Drawing.Point(8, 1)
        Me.txtColaStock.CustomButton.Name = ""
        Me.txtColaStock.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtColaStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtColaStock.CustomButton.TabIndex = 1
        Me.txtColaStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtColaStock.CustomButton.UseSelectable = True
        Me.txtColaStock.CustomButton.Visible = False
        Me.txtColaStock.Lines = New String() {"25"}
        Me.txtColaStock.Location = New System.Drawing.Point(138, 65)
        Me.txtColaStock.MaxLength = 32767
        Me.txtColaStock.Name = "txtColaStock"
        Me.txtColaStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtColaStock.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtColaStock.SelectedText = ""
        Me.txtColaStock.SelectionLength = 0
        Me.txtColaStock.SelectionStart = 0
        Me.txtColaStock.ShortcutsEnabled = True
        Me.txtColaStock.Size = New System.Drawing.Size(30, 23)
        Me.txtColaStock.TabIndex = 45
        Me.txtColaStock.Text = "25"
        Me.txtColaStock.UseSelectable = True
        Me.txtColaStock.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtColaStock.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkWater
        '
        Me.chkWater.AutoSize = True
        Me.chkWater.Location = New System.Drawing.Point(96, 249)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(87, 15)
        Me.chkWater.TabIndex = 38
        Me.chkWater.Text = "Water (Free)"
        Me.chkWater.UseSelectable = True
        '
        'chkChoco
        '
        Me.chkChoco.AutoSize = True
        Me.chkChoco.Location = New System.Drawing.Point(96, 148)
        Me.chkChoco.Name = "chkChoco"
        Me.chkChoco.Size = New System.Drawing.Size(81, 15)
        Me.chkChoco.TabIndex = 37
        Me.chkChoco.Text = "Choco ($1)"
        Me.chkChoco.UseSelectable = True
        '
        'chkCola
        '
        Me.chkCola.AutoSize = True
        Me.chkCola.Location = New System.Drawing.Point(96, 44)
        Me.chkCola.Name = "chkCola"
        Me.chkCola.Size = New System.Drawing.Size(70, 15)
        Me.chkCola.TabIndex = 21
        Me.chkCola.Text = "Cola ($1)"
        Me.chkCola.UseSelectable = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(4, 228)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 126)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(4, 27)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(86, 83)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 34
        Me.PictureBox7.TabStop = False
        '
        'stockCheckerTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 537)
        Me.Controls.Add(Me.pnl_MenuOrder)
        Me.Controls.Add(Me.pnl_Checkout)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.Text = "Super Sale Shop"
        Me.pnl_Checkout.ResumeLayout(False)
        Me.pnl_Checkout.PerformLayout()
        Me.pnl_CashPayment.ResumeLayout(False)
        Me.pnl_CashPayment.PerformLayout()
        Me.pnl_CardPayment.ResumeLayout(False)
        Me.pnl_CardPayment.PerformLayout()
        Me.pnl_MenuOrder.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl3.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstItems_Checkout As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents pnl_Checkout As Panel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_SubmitOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents pnl_CashPayment As Panel
    Friend WithEvents rad_CardPayment As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rad_CashPayment As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_BackToMenu As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_TotalToPay As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_UserChange As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_UserBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnl_CardPayment As Panel
    Friend WithEvents btn_VoidOrder As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_CVV4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_CVV3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_CVV2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_CVV1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_UserCardNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_ProceedCheckout As MetroFramework.Controls.MetroButton
    Friend WithEvents pnl_MenuOrder As Panel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtMushroomPizzaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkTomatoesPizza As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents radLargeMushroomPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMediumMushroomPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radSmallMushroomPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents chkMushroomPizza As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents chkPineapplePizza As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents chkPepperoniPizza As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents chkWater As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkChoco As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCola As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents radSmallPepperoniPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMediumPepperoniPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radLargePepperoniPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents radSmallPineapplePizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMediumPineapplePizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radLargePineapplePizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents radSmallTomatoesPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radMediumTomatoesPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radLargeTomatoesPizza As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkLasagna As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCarbonara As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents chkSpaghetti As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents chkMacAndCheese As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents txtPineapplePizzaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPineapplePizzaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPepperoniPizzaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPepperoniPizzaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTomatoesPizzaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTomatoesPizzaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMushroomPizzaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMacAndCheeseQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMacAndCheeseStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLasagnaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLasagnaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCarbonaraQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCarbonaraStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSpaghettiQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtSpaghettiStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtWaterQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtWaterStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtChocoQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtChocoStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColaQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtColaStock As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_ClearInputs As MetroFramework.Controls.MetroButton
    Friend WithEvents stockCheckerTimer As Timer
    Friend WithEvents txtCodetoVoid As MetroFramework.Controls.MetroTextBox
End Class
