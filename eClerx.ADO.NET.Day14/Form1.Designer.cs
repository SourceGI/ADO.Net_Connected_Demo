
namespace eClerx.ADO.NET.Day14
{
    partial class FormAdoEx
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
            this.LblEmpCode = new System.Windows.Forms.Label();
            this.TxtEmpCode = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.LblCity = new System.Windows.Forms.Label();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.LblState = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmpCode
            // 
            this.LblEmpCode.AutoSize = true;
            this.LblEmpCode.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpCode.Location = new System.Drawing.Point(22, 42);
            this.LblEmpCode.Name = "LblEmpCode";
            this.LblEmpCode.Size = new System.Drawing.Size(99, 18);
            this.LblEmpCode.TabIndex = 0;
            this.LblEmpCode.Text = "EmployeeCode";
            // 
            // TxtEmpCode
            // 
            this.TxtEmpCode.Location = new System.Drawing.Point(127, 42);
            this.TxtEmpCode.Name = "TxtEmpCode";
            this.TxtEmpCode.Size = new System.Drawing.Size(145, 20);
            this.TxtEmpCode.TabIndex = 1;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(127, 85);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(145, 20);
            this.TxtFirstName.TabIndex = 3;
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName.Location = new System.Drawing.Point(41, 87);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(80, 18);
            this.LblFirstName.TabIndex = 2;
            this.LblFirstName.Text = "First Name";
            // 
            // TxtCity
            // 
            this.TxtCity.Location = new System.Drawing.Point(127, 131);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(145, 20);
            this.TxtCity.TabIndex = 5;
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCity.Location = new System.Drawing.Point(64, 133);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(35, 18);
            this.LblCity.TabIndex = 4;
            this.LblCity.Text = "City";
            // 
            // TxtState
            // 
            this.TxtState.Location = new System.Drawing.Point(127, 174);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(145, 20);
            this.TxtState.TabIndex = 7;
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Font = new System.Drawing.Font("Bodoni MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblState.Location = new System.Drawing.Point(64, 176);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(41, 18);
            this.LblState.TabIndex = 6;
            this.LblState.Text = "State";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(278, 39);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 8;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.Location = new System.Drawing.Point(160, 214);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FormAdoEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 252);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtEmpCode);
            this.Controls.Add(this.LblEmpCode);
            this.Name = "FormAdoEx";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAdoEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmpCode;
        private System.Windows.Forms.TextBox TxtEmpCode;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReset;
    }
}

