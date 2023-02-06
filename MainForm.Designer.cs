namespace RandomBytes
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RandomNumbersButton = new DataJuggler.Win.Controls.Button();
            this.CountControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MaxControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MinControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.DelimiterControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.ResultsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ShufflesControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.CopyCheckBoxControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.SuspendLayout();
            // 
            // RandomNumbersButton
            // 
            this.RandomNumbersButton.BackColor = System.Drawing.Color.Transparent;
            this.RandomNumbersButton.ButtonText = "Generate Random Numbers";
            this.RandomNumbersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomNumbersButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.RandomNumbersButton.Location = new System.Drawing.Point(43, 283);
            this.RandomNumbersButton.Margin = new System.Windows.Forms.Padding(4);
            this.RandomNumbersButton.Name = "RandomNumbersButton";
            this.RandomNumbersButton.Size = new System.Drawing.Size(258, 53);
            this.RandomNumbersButton.TabIndex = 0;
            this.RandomNumbersButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.RandomNumbersButton.Click += new System.EventHandler(this.RandomNumbersButton_Click);            
            // 
            // CountControl
            // 
            this.CountControl.BackColor = System.Drawing.Color.Transparent;
            this.CountControl.BottomMargin = 0;
            this.CountControl.Editable = true;
            this.CountControl.Encrypted = false;
            this.CountControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountControl.Inititialized = true;
            this.CountControl.LabelBottomMargin = 0;
            this.CountControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CountControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountControl.LabelText = "Count:";
            this.CountControl.LabelTopMargin = 0;
            this.CountControl.LabelWidth = 80;
            this.CountControl.Location = new System.Drawing.Point(37, 110);
            this.CountControl.MultiLine = false;
            this.CountControl.Name = "CountControl";
            this.CountControl.OnTextChangedListener = null;
            this.CountControl.PasswordMode = false;
            this.CountControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountControl.Size = new System.Drawing.Size(200, 32);
            this.CountControl.TabIndex = 2;
            this.CountControl.TextBoxBottomMargin = 0;
            this.CountControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.CountControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.CountControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountControl.TextBoxTopMargin = 0;
            this.CountControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(37, 348);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(277, 35);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxControl
            // 
            this.MaxControl.BackColor = System.Drawing.Color.Transparent;
            this.MaxControl.BottomMargin = 0;
            this.MaxControl.Editable = true;
            this.MaxControl.Encrypted = false;
            this.MaxControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxControl.Inititialized = true;
            this.MaxControl.LabelBottomMargin = 0;
            this.MaxControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MaxControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxControl.LabelText = "Max:";
            this.MaxControl.LabelTopMargin = 0;
            this.MaxControl.LabelWidth = 80;
            this.MaxControl.Location = new System.Drawing.Point(37, 68);
            this.MaxControl.MultiLine = false;
            this.MaxControl.Name = "MaxControl";
            this.MaxControl.OnTextChangedListener = null;
            this.MaxControl.PasswordMode = false;
            this.MaxControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MaxControl.Size = new System.Drawing.Size(200, 32);
            this.MaxControl.TabIndex = 1;
            this.MaxControl.TextBoxBottomMargin = 0;
            this.MaxControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MaxControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MaxControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaxControl.TextBoxTopMargin = 0;
            this.MaxControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MinControl
            // 
            this.MinControl.BackColor = System.Drawing.Color.Transparent;
            this.MinControl.BottomMargin = 0;
            this.MinControl.Editable = true;
            this.MinControl.Encrypted = false;
            this.MinControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinControl.Inititialized = true;
            this.MinControl.LabelBottomMargin = 0;
            this.MinControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MinControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinControl.LabelText = "Min:";
            this.MinControl.LabelTopMargin = 0;
            this.MinControl.LabelWidth = 80;
            this.MinControl.Location = new System.Drawing.Point(37, 26);
            this.MinControl.MultiLine = false;
            this.MinControl.Name = "MinControl";
            this.MinControl.OnTextChangedListener = null;
            this.MinControl.PasswordMode = false;
            this.MinControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MinControl.Size = new System.Drawing.Size(200, 32);
            this.MinControl.TabIndex = 0;
            this.MinControl.TextBoxBottomMargin = 0;
            this.MinControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.MinControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.MinControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinControl.TextBoxTopMargin = 0;
            this.MinControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DelimiterControl
            // 
            this.DelimiterControl.BackColor = System.Drawing.Color.Transparent;
            this.DelimiterControl.ComboBoxLeftMargin = 1;
            this.DelimiterControl.ComboBoxText = "";
            this.DelimiterControl.ComoboBoxFont = null;
            this.DelimiterControl.Editable = true;
            this.DelimiterControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelimiterControl.HideLabel = false;
            this.DelimiterControl.LabelBottomMargin = 0;
            this.DelimiterControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.DelimiterControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelimiterControl.LabelText = "Delimiter:";
            this.DelimiterControl.LabelTopMargin = 0;
            this.DelimiterControl.LabelWidth = 92;
            this.DelimiterControl.List = null;
            this.DelimiterControl.Location = new System.Drawing.Point(25, 194);
            this.DelimiterControl.Name = "DelimiterControl";
            this.DelimiterControl.SelectedIndex = -1;
            this.DelimiterControl.SelectedIndexListener = null;
            this.DelimiterControl.Size = new System.Drawing.Size(263, 28);
            this.DelimiterControl.Sorted = true;
            this.DelimiterControl.Source = null;
            this.DelimiterControl.TabIndex = 4;
            this.DelimiterControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            this.Graph.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Graph.Location = new System.Drawing.Point(0, 411);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(1080, 12);
            this.Graph.TabIndex = 7;
            this.Graph.Visible = false;
            // 
            // ResultsControl
            // 
            this.ResultsControl.BackColor = System.Drawing.Color.Transparent;
            this.ResultsControl.BottomMargin = 0;
            this.ResultsControl.Editable = true;
            this.ResultsControl.Encrypted = false;
            this.ResultsControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultsControl.Inititialized = true;
            this.ResultsControl.LabelBottomMargin = 0;
            this.ResultsControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ResultsControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResultsControl.LabelText = "Results:";
            this.ResultsControl.LabelTopMargin = 0;
            this.ResultsControl.LabelWidth = 80;
            this.ResultsControl.Location = new System.Drawing.Point(333, 26);
            this.ResultsControl.MultiLine = true;
            this.ResultsControl.Name = "ResultsControl";
            this.ResultsControl.OnTextChangedListener = null;
            this.ResultsControl.PasswordMode = false;
            this.ResultsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ResultsControl.Size = new System.Drawing.Size(626, 320);
            this.ResultsControl.TabIndex = 8;
            this.ResultsControl.TextBoxBottomMargin = 0;
            this.ResultsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ResultsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ResultsControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultsControl.TextBoxTopMargin = 0;
            this.ResultsControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ShufflesControl
            // 
            this.ShufflesControl.BackColor = System.Drawing.Color.Transparent;
            this.ShufflesControl.BottomMargin = 0;
            this.ShufflesControl.Editable = true;
            this.ShufflesControl.Encrypted = false;
            this.ShufflesControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShufflesControl.Inititialized = true;
            this.ShufflesControl.LabelBottomMargin = 0;
            this.ShufflesControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ShufflesControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShufflesControl.LabelText = "Shuffles:";
            this.ShufflesControl.LabelTopMargin = 0;
            this.ShufflesControl.LabelWidth = 92;
            this.ShufflesControl.Location = new System.Drawing.Point(25, 152);
            this.ShufflesControl.MultiLine = false;
            this.ShufflesControl.Name = "ShufflesControl";
            this.ShufflesControl.OnTextChangedListener = null;
            this.ShufflesControl.PasswordMode = false;
            this.ShufflesControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ShufflesControl.Size = new System.Drawing.Size(212, 32);
            this.ShufflesControl.TabIndex = 3;
            this.ShufflesControl.TextBoxBottomMargin = 0;
            this.ShufflesControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ShufflesControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ShufflesControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShufflesControl.TextBoxTopMargin = 0;
            this.ShufflesControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CopyCheckBoxControl
            // 
            this.CopyCheckBoxControl.BackColor = System.Drawing.Color.Transparent;
            this.CopyCheckBoxControl.CheckBoxHorizontalOffSet = 0;
            this.CopyCheckBoxControl.CheckBoxVerticalOffSet = 3;
            this.CopyCheckBoxControl.CheckChangedListener = null;
            this.CopyCheckBoxControl.Checked = true;
            this.CopyCheckBoxControl.Editable = true;
            this.CopyCheckBoxControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyCheckBoxControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CopyCheckBoxControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CopyCheckBoxControl.LabelText = "Copy:";
            this.CopyCheckBoxControl.LabelWidth = 92;
            this.CopyCheckBoxControl.Location = new System.Drawing.Point(25, 232);
            this.CopyCheckBoxControl.Name = "CopyCheckBoxControl";
            this.CopyCheckBoxControl.Size = new System.Drawing.Size(160, 28);
            this.CopyCheckBoxControl.TabIndex = 9;
            this.CopyCheckBoxControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RandomBytes.Properties.Resources.BlackImage;
            this.ClientSize = new System.Drawing.Size(1080, 423);
            this.Controls.Add(this.CopyCheckBoxControl);
            this.Controls.Add(this.ShufflesControl);
            this.Controls.Add(this.ResultsControl);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.DelimiterControl);
            this.Controls.Add(this.MinControl);
            this.Controls.Add(this.MaxControl);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CountControl);
            this.Controls.Add(this.RandomNumbersButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Bytes";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.Button RandomNumbersButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl CountControl;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.LabelTextBoxControl MaxControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl MinControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl DelimiterControl;
        private ProgressBar Graph;
        private DataJuggler.Win.Controls.LabelTextBoxControl ResultsControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl ShufflesControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl CopyCheckBoxControl;
    }
}