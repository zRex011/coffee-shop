namespace WindowsFormsApp1
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.LinkLabel();
            this.bntExit = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnUpdateItems = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.uC_PlaceOrder1 = new WindowsFormsApp1.AllUserControls.UC_PlaceOrder();
            this.uC_AddItems1 = new WindowsFormsApp1.AllUserControls.UC_AddItems();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.bntExit);
            this.panel1.Controls.Add(this.btnRemoveItems);
            this.panel1.Controls.Add(this.btnUpdateItems);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 501);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.AutoSize = true;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(67, 445);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(68, 18);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.TabStop = true;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogOut_LinkClicked);
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(0, -1);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(38, 41);
            this.bntExit.TabIndex = 2;
            this.bntExit.Text = "X";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.bntExit_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(27, 323);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(174, 51);
            this.btnRemoveItems.TabIndex = 5;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = false;
            this.btnRemoveItems.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdateItems
            // 
            this.btnUpdateItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnUpdateItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.Location = new System.Drawing.Point(27, 234);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.Size = new System.Drawing.Size(174, 51);
            this.btnUpdateItems.TabIndex = 4;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.UseVisualStyleBackColor = false;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(27, 145);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(174, 51);
            this.btnAddItems.TabIndex = 3;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(27, 50);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(174, 51);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(206, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(223, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tag = "Panel2";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tag = "panel2";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(221, 11);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(745, 502);
            this.uC_PlaceOrder1.TabIndex = 3;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.uC_AddItems1.Location = new System.Drawing.Point(226, 11);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(698, 502);
            this.uC_AddItems1.TabIndex = 2;
            this.uC_AddItems1.Load += new System.EventHandler(this.uC_AddItems1_Load);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.uC_PlaceOrder1);
            this.Controls.Add(this.uC_AddItems1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnUpdateItems;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bntExit;
        private System.Windows.Forms.LinkLabel btnLogOut;
        private System.Windows.Forms.Timer timer1;
        private AllUserControls.UC_AddItems uC_AddItems1;
        private System.Windows.Forms.Timer timer2;
        private AllUserControls.UC_PlaceOrder uC_PlaceOrder1;
    }
}