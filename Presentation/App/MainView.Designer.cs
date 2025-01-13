namespace Presentation.App
{
    partial class MainView
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
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.body_PanelControl = new DevExpress.XtraEditors.PanelControl();
            this.screens_XtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.footer_PanelControl = new DevExpress.XtraEditors.PanelControl();
            this.header_PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.dashboard_AccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ticket_AccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.setting_AccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.body_PanelControl)).BeginInit();
            this.body_PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screens_XtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer_PanelControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_PanelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.body_PanelControl);
            this.fluentDesignFormContainer1.Controls.Add(this.footer_PanelControl);
            this.fluentDesignFormContainer1.Controls.Add(this.header_PanelControl1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(260, 31);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(638, 568);
            this.fluentDesignFormContainer1.TabIndex = 0;
            // 
            // body_PanelControl
            // 
            this.body_PanelControl.Controls.Add(this.screens_XtraTabControl);
            this.body_PanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body_PanelControl.Location = new System.Drawing.Point(0, 40);
            this.body_PanelControl.Name = "body_PanelControl";
            this.body_PanelControl.Size = new System.Drawing.Size(638, 488);
            this.body_PanelControl.TabIndex = 1;
            // 
            // screens_XtraTabControl
            // 
            this.screens_XtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screens_XtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.screens_XtraTabControl.Name = "screens_XtraTabControl";
            this.screens_XtraTabControl.Size = new System.Drawing.Size(634, 484);
            this.screens_XtraTabControl.TabIndex = 0;
            // 
            // footer_PanelControl
            // 
            this.footer_PanelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_PanelControl.Location = new System.Drawing.Point(0, 528);
            this.footer_PanelControl.Name = "footer_PanelControl";
            this.footer_PanelControl.Size = new System.Drawing.Size(638, 40);
            this.footer_PanelControl.TabIndex = 2;
            // 
            // header_PanelControl1
            // 
            this.header_PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_PanelControl1.Location = new System.Drawing.Point(0, 0);
            this.header_PanelControl1.Name = "header_PanelControl1";
            this.header_PanelControl1.Size = new System.Drawing.Size(638, 40);
            this.header_PanelControl1.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.dashboard_AccordionControlElement,
            this.ticket_AccordionControlElement,
            this.setting_AccordionControlElement});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 568);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // dashboard_AccordionControlElement
            // 
            this.dashboard_AccordionControlElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.dashboard_AccordionControlElement.Name = "dashboard_AccordionControlElement";
            this.dashboard_AccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.dashboard_AccordionControlElement.Text = "Dashboard";
            // 
            // ticket_AccordionControlElement
            // 
            this.ticket_AccordionControlElement.Name = "ticket_AccordionControlElement";
            this.ticket_AccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ticket_AccordionControlElement.Text = "Ticket";
            // 
            // setting_AccordionControlElement
            // 
            this.setting_AccordionControlElement.Name = "setting_AccordionControlElement";
            this.setting_AccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.setting_AccordionControlElement.Text = "Setting";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(898, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 599);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "MainView";
            this.NavigationControl = this.accordionControl1;
            this.Text = "IFIN";
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.body_PanelControl)).EndInit();
            this.body_PanelControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screens_XtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footer_PanelControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.header_PanelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement dashboard_AccordionControlElement;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ticket_AccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement setting_AccordionControlElement;
        private DevExpress.XtraEditors.PanelControl footer_PanelControl;
        private DevExpress.XtraEditors.PanelControl body_PanelControl;
        private DevExpress.XtraEditors.PanelControl header_PanelControl1;
        private DevExpress.XtraTab.XtraTabControl screens_XtraTabControl;
    }
}