namespace UartSerialTool
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label_StatusCOM = new System.Windows.Forms.Label();
            this.ComboBox_PortCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_RefreshPorts = new System.Windows.Forms.Button();
            this.Button_Open = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.TableLayoutPanel_SerialSettings = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
            this.ComboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.ComboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_ToSend = new System.Windows.Forms.TextBox();
            this.TextBox_Received = new System.Windows.Forms.TextBox();
            this.panel_send = new System.Windows.Forms.Panel();
            this.panel_receive = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.CheckBox_LastFrame = new System.Windows.Forms.CheckBox();
            this.CheckBox_ShowHexa = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.TableLayoutPanel_SerialSettings.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel_send.SuspendLayout();
            this.panel_receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel_receive, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.TextBox_Received, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 292);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(794, 155);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TableLayoutPanel_SerialSettings, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(51, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(697, 122);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label_StatusCOM, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ComboBox_PortCOM, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Button_RefreshPorts, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Button_Open, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Button_Close, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label_StatusCOM
            // 
            this.label_StatusCOM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_StatusCOM.AutoSize = true;
            this.label_StatusCOM.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StatusCOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_StatusCOM.Location = new System.Drawing.Point(3, 38);
            this.label_StatusCOM.Name = "label_StatusCOM";
            this.label_StatusCOM.Size = new System.Drawing.Size(43, 13);
            this.label_StatusCOM.TabIndex = 5;
            this.label_StatusCOM.Text = "Status";
            // 
            // ComboBox_PortCOM
            // 
            this.ComboBox_PortCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_PortCOM.BackColor = System.Drawing.Color.Silver;
            this.ComboBox_PortCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_PortCOM.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_PortCOM.FormattingEnabled = true;
            this.ComboBox_PortCOM.Location = new System.Drawing.Point(52, 4);
            this.ComboBox_PortCOM.Name = "ComboBox_PortCOM";
            this.ComboBox_PortCOM.Size = new System.Drawing.Size(138, 21);
            this.ComboBox_PortCOM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // Button_RefreshPorts
            // 
            this.Button_RefreshPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RefreshPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RefreshPorts.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_RefreshPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_RefreshPorts.Location = new System.Drawing.Point(196, 3);
            this.Button_RefreshPorts.Name = "Button_RefreshPorts";
            this.Button_RefreshPorts.Size = new System.Drawing.Size(139, 23);
            this.Button_RefreshPorts.TabIndex = 2;
            this.Button_RefreshPorts.Text = "Refresh";
            this.Button_RefreshPorts.UseVisualStyleBackColor = true;
            this.Button_RefreshPorts.Click += new System.EventHandler(this.Button_RefreshPorts_Click);
            // 
            // Button_Open
            // 
            this.Button_Open.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Open.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button_Open.Location = new System.Drawing.Point(115, 33);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(75, 23);
            this.Button_Open.TabIndex = 3;
            this.Button_Open.Text = "Open";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_Close.Location = new System.Drawing.Point(228, 33);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // TableLayoutPanel_SerialSettings
            // 
            this.TableLayoutPanel_SerialSettings.ColumnCount = 2;
            this.TableLayoutPanel_SerialSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel_SerialSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.label5, 0, 3);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.label2, 0, 0);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.label3, 0, 1);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.label4, 0, 2);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.ComboBox_BaudRate, 1, 0);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.ComboBox_Parity, 1, 1);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.ComboBox_DataBits, 1, 2);
            this.TableLayoutPanel_SerialSettings.Controls.Add(this.ComboBox_StopBits, 1, 3);
            this.TableLayoutPanel_SerialSettings.Location = new System.Drawing.Point(352, 4);
            this.TableLayoutPanel_SerialSettings.Name = "TableLayoutPanel_SerialSettings";
            this.TableLayoutPanel_SerialSettings.RowCount = 4;
            this.TableLayoutPanel_SerialSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_SerialSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_SerialSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_SerialSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel_SerialSettings.Size = new System.Drawing.Size(341, 114);
            this.TableLayoutPanel_SerialSettings.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stop bits:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Baud rate:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data bits:";
            // 
            // ComboBox_BaudRate
            // 
            this.ComboBox_BaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_BaudRate.BackColor = System.Drawing.Color.Silver;
            this.ComboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_BaudRate.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_BaudRate.FormattingEnabled = true;
            this.ComboBox_BaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57800",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.ComboBox_BaudRate.Location = new System.Drawing.Point(76, 3);
            this.ComboBox_BaudRate.Name = "ComboBox_BaudRate";
            this.ComboBox_BaudRate.Size = new System.Drawing.Size(262, 21);
            this.ComboBox_BaudRate.TabIndex = 10;
            // 
            // ComboBox_Parity
            // 
            this.ComboBox_Parity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Parity.BackColor = System.Drawing.Color.Silver;
            this.ComboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Parity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Parity.FormattingEnabled = true;
            this.ComboBox_Parity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even"});
            this.ComboBox_Parity.Location = new System.Drawing.Point(76, 31);
            this.ComboBox_Parity.Name = "ComboBox_Parity";
            this.ComboBox_Parity.Size = new System.Drawing.Size(262, 21);
            this.ComboBox_Parity.TabIndex = 11;
            // 
            // ComboBox_DataBits
            // 
            this.ComboBox_DataBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_DataBits.BackColor = System.Drawing.Color.Silver;
            this.ComboBox_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DataBits.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_DataBits.FormattingEnabled = true;
            this.ComboBox_DataBits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.ComboBox_DataBits.Location = new System.Drawing.Point(76, 59);
            this.ComboBox_DataBits.Name = "ComboBox_DataBits";
            this.ComboBox_DataBits.Size = new System.Drawing.Size(262, 21);
            this.ComboBox_DataBits.TabIndex = 12;
            // 
            // ComboBox_StopBits
            // 
            this.ComboBox_StopBits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_StopBits.BackColor = System.Drawing.Color.Silver;
            this.ComboBox_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_StopBits.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_StopBits.FormattingEnabled = true;
            this.ComboBox_StopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.ComboBox_StopBits.Location = new System.Drawing.Point(76, 88);
            this.ComboBox_StopBits.Name = "ComboBox_StopBits";
            this.ComboBox_StopBits.Size = new System.Drawing.Size(262, 21);
            this.ComboBox_StopBits.TabIndex = 13;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel_send, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.TextBox_ToSend, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(794, 155);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // TextBox_ToSend
            // 
            this.TextBox_ToSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextBox_ToSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_ToSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_ToSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ToSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox_ToSend.Location = new System.Drawing.Point(4, 18);
            this.TextBox_ToSend.Multiline = true;
            this.TextBox_ToSend.Name = "TextBox_ToSend";
            this.TextBox_ToSend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_ToSend.Size = new System.Drawing.Size(786, 84);
            this.TextBox_ToSend.TabIndex = 0;
            // 
            // TextBox_Received
            // 
            this.TextBox_Received.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TextBox_Received.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Received.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Received.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Received.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextBox_Received.Location = new System.Drawing.Point(4, 18);
            this.TextBox_Received.Multiline = true;
            this.TextBox_Received.Name = "TextBox_Received";
            this.TextBox_Received.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Received.Size = new System.Drawing.Size(786, 84);
            this.TextBox_Received.TabIndex = 1;
            // 
            // panel_send
            // 
            this.panel_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_send.Controls.Add(this.Button_Send);
            this.panel_send.Location = new System.Drawing.Point(4, 109);
            this.panel_send.Name = "panel_send";
            this.panel_send.Size = new System.Drawing.Size(786, 42);
            this.panel_send.TabIndex = 1;
            // 
            // panel_receive
            // 
            this.panel_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_receive.Controls.Add(this.CheckBox_ShowHexa);
            this.panel_receive.Controls.Add(this.CheckBox_LastFrame);
            this.panel_receive.Controls.Add(this.Button_Clean);
            this.panel_receive.Location = new System.Drawing.Point(4, 109);
            this.panel_receive.Name = "panel_receive";
            this.panel_receive.Size = new System.Drawing.Size(786, 42);
            this.panel_receive.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(4, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Data to be send.";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data received.";
            // 
            // Button_Send
            // 
            this.Button_Send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_Send.Enabled = false;
            this.Button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Send.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Send.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_Send.Location = new System.Drawing.Point(706, 3);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 36);
            this.Button_Send.TabIndex = 5;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Button_Clean
            // 
            this.Button_Clean.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clean.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button_Clean.Location = new System.Drawing.Point(706, 3);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(75, 36);
            this.Button_Clean.TabIndex = 6;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // CheckBox_LastFrame
            // 
            this.CheckBox_LastFrame.AutoSize = true;
            this.CheckBox_LastFrame.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_LastFrame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CheckBox_LastFrame.Location = new System.Drawing.Point(11, 13);
            this.CheckBox_LastFrame.Name = "CheckBox_LastFrame";
            this.CheckBox_LastFrame.Size = new System.Drawing.Size(116, 17);
            this.CheckBox_LastFrame.TabIndex = 7;
            this.CheckBox_LastFrame.Text = "Only last frame";
            this.CheckBox_LastFrame.UseVisualStyleBackColor = true;
            // 
            // CheckBox_ShowHexa
            // 
            this.CheckBox_ShowHexa.AutoSize = true;
            this.CheckBox_ShowHexa.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_ShowHexa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CheckBox_ShowHexa.Location = new System.Drawing.Point(137, 13);
            this.CheckBox_ShowHexa.Name = "CheckBox_ShowHexa";
            this.CheckBox_ShowHexa.Size = new System.Drawing.Size(170, 17);
            this.CheckBox_ShowHexa.TabIndex = 8;
            this.CheckBox_ShowHexa.Text = "Show data in hexadecimal";
            this.CheckBox_ShowHexa.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UART Serial Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.TableLayoutPanel_SerialSettings.ResumeLayout(false);
            this.TableLayoutPanel_SerialSettings.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel_send.ResumeLayout(false);
            this.panel_receive.ResumeLayout(false);
            this.panel_receive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_StatusCOM;
        private System.Windows.Forms.ComboBox ComboBox_PortCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_RefreshPorts;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_SerialSettings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_BaudRate;
        private System.Windows.Forms.ComboBox ComboBox_Parity;
        private System.Windows.Forms.ComboBox ComboBox_DataBits;
        private System.Windows.Forms.ComboBox ComboBox_StopBits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox TextBox_ToSend;
        private System.Windows.Forms.TextBox TextBox_Received;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_receive;
        private System.Windows.Forms.CheckBox CheckBox_ShowHexa;
        private System.Windows.Forms.CheckBox CheckBox_LastFrame;
        private System.Windows.Forms.Button Button_Clean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_send;
        private System.Windows.Forms.Button Button_Send;
    }
}

