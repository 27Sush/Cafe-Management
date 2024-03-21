namespace Cafemanage2.AllUserControls
{
    partial class UC_RemoveItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemoveSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaDataGridView3 = new Guna.UI.WinForms.GunaDataGridView();
            this.DelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 30;
            this.gunaElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Items";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(496, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRemoveSearch
            // 
            this.txtRemoveSearch.BackColor = System.Drawing.Color.White;
            this.txtRemoveSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemoveSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRemoveSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemoveSearch.LineColor = System.Drawing.Color.Black;
            this.txtRemoveSearch.Location = new System.Drawing.Point(497, 150);
            this.txtRemoveSearch.Name = "txtRemoveSearch";
            this.txtRemoveSearch.PasswordChar = '\0';
            this.txtRemoveSearch.SelectedText = "";
            this.txtRemoveSearch.Size = new System.Drawing.Size(160, 44);
            this.txtRemoveSearch.TabIndex = 3;
            this.txtRemoveSearch.TextChanged += new System.EventHandler(this.txtRemoveSearch_TextChanged);
            // 
            // gunaDataGridView3
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.gunaDataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gunaDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView3.DefaultCellStyle = dataGridViewCellStyle15;
            this.gunaDataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gunaDataGridView3.EnableHeadersVisualStyles = false;
            this.gunaDataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView3.Location = new System.Drawing.Point(89, 229);
            this.gunaDataGridView3.Name = "gunaDataGridView3";
            this.gunaDataGridView3.RowHeadersVisible = false;
            this.gunaDataGridView3.RowHeadersWidth = 51;
            this.gunaDataGridView3.RowTemplate.Height = 24;
            this.gunaDataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView3.Size = new System.Drawing.Size(943, 357);
            this.gunaDataGridView3.TabIndex = 4;
            this.gunaDataGridView3.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView3.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView3.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView3.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView3.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView3.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView3.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gunaDataGridView3.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView3.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView3.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView3.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView3.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView3.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView3.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView3.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView3.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView3_CellClick);
            // 
            // DelLabel
            // 
            this.DelLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelLabel.ForeColor = System.Drawing.Color.Black;
            this.DelLabel.Location = new System.Drawing.Point(608, 643);
            this.DelLabel.Name = "DelLabel";
            this.DelLabel.Size = new System.Drawing.Size(305, 47);
            this.DelLabel.TabIndex = 5;
            this.DelLabel.Text = "Label";
            this.DelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelLabel.Click += new System.EventHandler(this.DelLabel_Click);
            // 
            // UC_RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelLabel);
            this.Controls.Add(this.gunaDataGridView3);
            this.Controls.Add(this.txtRemoveSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_RemoveItem";
            this.Size = new System.Drawing.Size(1127, 780);
            this.Load += new System.EventHandler(this.UC_RemoveItem_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveItem_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txtRemoveSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView3;
        private System.Windows.Forms.Label DelLabel;
    }
}
