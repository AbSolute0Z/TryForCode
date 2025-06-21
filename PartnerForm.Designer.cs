namespace pol
{
    partial class PartnerForm
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
            this.PartnerGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.viewHistoryButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partnerIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PartnerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartnerGridView
            // 
            this.PartnerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartnerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIdColumn,
            this.companyNameColumn,
            this.partnerTypeColumn,
            this.directorNameColumn,
            this.emailColumn,
            this.phoneColumn,
            this.addressColumn,
            this.innColumn,
            this.ratingColumn});
            this.PartnerGridView.Location = new System.Drawing.Point(16, 15);
            this.PartnerGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PartnerGridView.Name = "PartnerGridView";
            this.PartnerGridView.RowHeadersWidth = 51;
            this.PartnerGridView.Size = new System.Drawing.Size(1035, 372);
            this.PartnerGridView.TabIndex = 0;
            this.PartnerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartnerGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(16, 394);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(177, 60);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(201, 394);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(183, 60);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // viewHistoryButton
            // 
            this.viewHistoryButton.Location = new System.Drawing.Point(392, 394);
            this.viewHistoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewHistoryButton.Name = "viewHistoryButton";
            this.viewHistoryButton.Size = new System.Drawing.Size(184, 60);
            this.viewHistoryButton.TabIndex = 3;
            this.viewHistoryButton.Text = "Просмотреть";
            this.viewHistoryButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(584, 394);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(193, 60);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(785, 430);
            this.searchtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(264, 22);
            this.searchtextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск";
            // 
            // partnerIdColumn
            // 
            this.partnerIdColumn.DataPropertyName = "partner_id";
            this.partnerIdColumn.HeaderText = "ID";
            this.partnerIdColumn.MinimumWidth = 6;
            this.partnerIdColumn.Name = "partnerIdColumn";
            this.partnerIdColumn.Width = 125;
            // 
            // companyNameColumn
            // 
            this.companyNameColumn.DataPropertyName = "company_name";
            this.companyNameColumn.HeaderText = "Названии компании";
            this.companyNameColumn.MinimumWidth = 6;
            this.companyNameColumn.Name = "companyNameColumn";
            this.companyNameColumn.Width = 125;
            // 
            // partnerTypeColumn
            // 
            this.partnerTypeColumn.DataPropertyName = "partner_type";
            this.partnerTypeColumn.HeaderText = "Тип партнера";
            this.partnerTypeColumn.MinimumWidth = 6;
            this.partnerTypeColumn.Name = "partnerTypeColumn";
            this.partnerTypeColumn.Width = 125;
            // 
            // directorNameColumn
            // 
            this.directorNameColumn.DataPropertyName = "director_name";
            this.directorNameColumn.HeaderText = "Директор";
            this.directorNameColumn.MinimumWidth = 6;
            this.directorNameColumn.Name = "directorNameColumn";
            this.directorNameColumn.Width = 125;
            // 
            // emailColumn
            // 
            this.emailColumn.DataPropertyName = "email";
            this.emailColumn.HeaderText = "E-Mail";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 125;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "phone";
            this.phoneColumn.HeaderText = "Телефон";
            this.phoneColumn.MinimumWidth = 6;
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Width = 125;
            // 
            // addressColumn
            // 
            this.addressColumn.DataPropertyName = "legal_address";
            this.addressColumn.HeaderText = "Адрес";
            this.addressColumn.MinimumWidth = 6;
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.Width = 125;
            // 
            // innColumn
            // 
            this.innColumn.DataPropertyName = "inn";
            this.innColumn.HeaderText = "ИНН";
            this.innColumn.MinimumWidth = 6;
            this.innColumn.Name = "innColumn";
            this.innColumn.Width = 125;
            // 
            // ratingColumn
            // 
            this.ratingColumn.DataPropertyName = "rating";
            this.ratingColumn.HeaderText = "Рейтинг";
            this.ratingColumn.MinimumWidth = 6;
            this.ratingColumn.Name = "ratingColumn";
            this.ratingColumn.Width = 125;
            // 
            // PartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.viewHistoryButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.PartnerGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PartnerForm";
            this.Text = "Система Мастер-Пол";
            ((System.ComponentModel.ISupportInitialize)(this.PartnerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PartnerGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button viewHistoryButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingColumn;
    }
}