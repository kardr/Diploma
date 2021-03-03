namespace WindowsFormsApp7
{
    partial class Diploma
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MaquetteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiplomaDataSet = new WindowsFormsApp7.DiplomaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaquetteTableAdapter = new WindowsFormsApp7.DiplomaDataSetTableAdapters.MaquetteTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.участникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеНовыхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборУчастниковДляНагражденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.макетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеНовогоМакетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборМакетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеНвогоСтатусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборСтатусаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мероприятиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеМероприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборМероприятияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MaquetteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomaDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaquetteBindingSource
            // 
            this.MaquetteBindingSource.DataMember = "Maquette";
            this.MaquetteBindingSource.DataSource = this.DiplomaDataSet;
            // 
            // DiplomaDataSet
            // 
            this.DiplomaDataSet.DataSetName = "DiplomaDataSet";
            this.DiplomaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MaquetteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp7.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-32768, -1);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(0, 448);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // MaquetteTableAdapter
            // 
            this.MaquetteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(2, 28);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(747, 420);
            this.reportViewer3.TabIndex = 2;
            this.reportViewer3.Load += new System.EventHandler(this.reportViewer3_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.участникиToolStripMenuItem,
            this.макетыToolStripMenuItem,
            this.статусToolStripMenuItem,
            this.мероприятиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // участникиToolStripMenuItem
            // 
            this.участникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеНовыхToolStripMenuItem,
            this.выборУчастниковДляНагражденияToolStripMenuItem});
            this.участникиToolStripMenuItem.Name = "участникиToolStripMenuItem";
            this.участникиToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.участникиToolStripMenuItem.Text = "Участники ";
            // 
            // добавлениеНовыхToolStripMenuItem
            // 
            this.добавлениеНовыхToolStripMenuItem.Name = "добавлениеНовыхToolStripMenuItem";
            this.добавлениеНовыхToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.добавлениеНовыхToolStripMenuItem.Text = "Добавление новых";
            // 
            // выборУчастниковДляНагражденияToolStripMenuItem
            // 
            this.выборУчастниковДляНагражденияToolStripMenuItem.Name = "выборУчастниковДляНагражденияToolStripMenuItem";
            this.выборУчастниковДляНагражденияToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.выборУчастниковДляНагражденияToolStripMenuItem.Text = "Выбор участников для награждения";
            // 
            // макетыToolStripMenuItem
            // 
            this.макетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеНовогоМакетаToolStripMenuItem,
            this.выборМакетаToolStripMenuItem});
            this.макетыToolStripMenuItem.Name = "макетыToolStripMenuItem";
            this.макетыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.макетыToolStripMenuItem.Text = "Макеты";
            // 
            // добавлениеНовогоМакетаToolStripMenuItem
            // 
            this.добавлениеНовогоМакетаToolStripMenuItem.Name = "добавлениеНовогоМакетаToolStripMenuItem";
            this.добавлениеНовогоМакетаToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.добавлениеНовогоМакетаToolStripMenuItem.Text = "Добавление нового макета";
            this.добавлениеНовогоМакетаToolStripMenuItem.Click += new System.EventHandler(this.добавлениеНовогоМакетаToolStripMenuItem_Click);
            // 
            // выборМакетаToolStripMenuItem
            // 
            this.выборМакетаToolStripMenuItem.Name = "выборМакетаToolStripMenuItem";
            this.выборМакетаToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.выборМакетаToolStripMenuItem.Text = "Выбор макета";
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеНвогоСтатусаToolStripMenuItem,
            this.выборСтатусаToolStripMenuItem});
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.статусToolStripMenuItem.Text = "Статус";
            // 
            // добавлениеНвогоСтатусаToolStripMenuItem
            // 
            this.добавлениеНвогоСтатусаToolStripMenuItem.Name = "добавлениеНвогоСтатусаToolStripMenuItem";
            this.добавлениеНвогоСтатусаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.добавлениеНвогоСтатусаToolStripMenuItem.Text = "Добавление нвого статуса";
            // 
            // выборСтатусаToolStripMenuItem
            // 
            this.выборСтатусаToolStripMenuItem.Name = "выборСтатусаToolStripMenuItem";
            this.выборСтатусаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.выборСтатусаToolStripMenuItem.Text = "Выбор статуса";
            // 
            // мероприятиеToolStripMenuItem
            // 
            this.мероприятиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеМероприятияToolStripMenuItem,
            this.выборМероприятияToolStripMenuItem});
            this.мероприятиеToolStripMenuItem.Name = "мероприятиеToolStripMenuItem";
            this.мероприятиеToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.мероприятиеToolStripMenuItem.Text = "Мероприятие";
            // 
            // добавлениеМероприятияToolStripMenuItem
            // 
            this.добавлениеМероприятияToolStripMenuItem.Name = "добавлениеМероприятияToolStripMenuItem";
            this.добавлениеМероприятияToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.добавлениеМероприятияToolStripMenuItem.Text = "Добавление мероприятия";
            // 
            // выборМероприятияToolStripMenuItem
            // 
            this.выборМероприятияToolStripMenuItem.Name = "выборМероприятияToolStripMenuItem";
            this.выборМероприятияToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.выборМероприятияToolStripMenuItem.Text = "Выбор мероприятия";
            // 
            // Diploma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Diploma";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaquetteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiplomaDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MaquetteBindingSource;
        private DiplomaDataSet DiplomaDataSet;
        private DiplomaDataSetTableAdapters.MaquetteTableAdapter MaquetteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem участникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеНовыхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборУчастниковДляНагражденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem макетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеНовогоМакетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборМакетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеНвогоСтатусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборСтатусаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мероприятиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеМероприятияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборМероприятияToolStripMenuItem;
    }
}

