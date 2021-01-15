namespace ASDBFramework.Windows.WinControls
{
    partial class ASDateTimePicker
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
            this.SuspendLayout();
            // 
            // ASDateTimePicker
            // 
            this.CustomFormat = " ";
            this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ValueChanged += new System.EventHandler(this.ASDateTimePicker_ValueChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ASDateTimePicker_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
