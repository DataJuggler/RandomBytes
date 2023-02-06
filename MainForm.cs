

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.RandomShuffler;
using System.Text;
using RandomBytes.Enumerations;
using DataJuggler.UltimateHelper;

#endregion

namespace RandomBytes
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this app.
    /// </summary>
    public partial class MainForm : Form, ISelectedIndexListener
    {
        
        #region Private Variables
        private RandomShuffler shuffler;
        private string delimiter;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events
            
            #region OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            /// <summary>
            /// event is fired when a selection is made in the 'On'.
            /// </summary>
            public void OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            {
                // If the selectedItem object exists
                if (NullHelper.Exists(selectedItem))
                {
                    // get the sectedItem
                    string text = selectedItem.ToString();

                    switch (text)
                    {
                        case "Comma":

                            // Set the Delimiter
                            Delimiter = ",";

                            // required
                            break;

                         case "New Line":

                            // Set the Delimiter
                            Delimiter = Environment.NewLine;

                            // required
                            break;

                        case "Space":

                            // Set the Delimiter
                            Delimiter = " ";

                            // required
                            break;

                        default:

                             // Set the Delimiter
                            Delimiter = "";

                            // required
                            break;
                    }
                }
            }
            #endregion
            
            #region RandomNumbersButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'RandomNumbersButton' is clicked.
            /// </summary>
            private void RandomNumbersButton_Click(object sender, EventArgs e)
            {
                // get the values
                int min = MinControl.IntValue;
                int max = MaxControl.IntValue;
                int count = CountControl.IntValue;
                int shuffles = ShufflesControl.IntValue;

                // Perform validation
                bool isValid = ValidateInput(min, max, count, shuffles);

                // if the value for isValid is true
                if (isValid)
                {
                    // Create a new instance of a 'RandomShuffler' object.
                    Shuffler = new RandomShuffler(min, max, count, shuffles);

                    // Setup the Graph
                    Graph.Minimum = 0;
                    Graph.Maximum = count;
                    Graph.Value = 0;
                    Graph.Visible = true;

                    // Set the text
                    StatusLabel.Text = "Generating...";
                    StatusLabel.ForeColor = Color.LemonChiffon;

                    // Refresh
                    Refresh();
                    Application.DoEvents();

                    // Create a new instance of a 'StringBuilder' object.
                    StringBuilder sb = new StringBuilder();

                    // local
                    int value = 0;

                    // Perform extra shuffles
                    Shuffler.Shuffle(ShufflesControl.IntValue);

                    // if there is one or more items to create
                    if (CountControl.IntValue > 0)
                    {
                        // Increment the value for for
                        for (int x = 0; x < CountControl.IntValue; x++)
                        {
                            // Get the next random value
                            value = Shuffler.PullNextItem();

                            // add this item
                            sb.Append(value);

                            // add delimiter here
                            if (TextHelper.Exists(Delimiter))
                            {
                                // Add the delimiter
                                sb.Append(Delimiter);
                            }

                            // Show the Graph Value
                            Graph.Value = x;
                            Graph.Update();
                            Application.DoEvents();
                        }

                        // if Checked
                        if (CopyCheckBoxControl.Checked)
                        {
                            // Copy to clipboard
                            Clipboard.SetText(sb.ToString());
                        }

                        // Set the text
                        Graph.Visible = false;
                        StatusLabel.Text = "Finished.";
                        ResultsControl.Text = sb.ToString();
                        StatusLabel.ForeColor = Color.LemonChiffon;
                    }                
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Defaults
                MinControl.Text = "0";
                MaxControl.Text = "1";
                CountControl.Text = "1000";
                ShufflesControl.Text = "20";
                DelimiterControl.LoadItems(typeof(DelimiterEnum));
                DelimiterControl.SelectedIndexListener = this;
                
                // Select Space
                DelimiterControl.SelectedIndex = 3;

                // Set the initial value
                CountControl.Text = "1000";
            }
            #endregion

            #region ValidateInput(int min, int max, int count, int shuffles)
            /// <summary>
            /// returns the Input
            /// </summary>
            public bool ValidateInput(int min, int max, int count, int shuffles)
            {
                // initial value
                bool isValid = true;

                // default to red
                StatusLabel.ForeColor = Color.Firebrick;

                // max must be greater than min
                if (min >= max)
                {
                    // not valid
                    isValid = false;

                    // Show reason
                    StatusLabel.Text = "Max must be > min.";
                    
                }
                else if (count < 1)
                {
                    // not valid
                    isValid = false;

                    // Show reason
                    StatusLabel.Text = "Count must be set.";
                }
                 else if (shuffles < 1)
                {
                    // not valid
                    isValid = false;

                    // Show reason
                    StatusLabel.Text = "Shuffles must be set.";
                }
                else
                {
                    // Show reason
                    StatusLabel.Text = "Generating.";
                    StatusLabel.ForeColor = Color.LemonChiffon;
                }

                // Force update UI
                Refresh();
                Application.DoEvents();
                
                // return value
                return isValid;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Delimiter
            /// <summary>
            /// This property gets or sets the value for 'Delimiter'.
            /// </summary>
            public string Delimiter
            {
                get { return delimiter; }
                set { delimiter = value; }
            }
            #endregion
            
            #region HasShuffler
            /// <summary>
            /// This property returns true if this object has a 'Shuffler'.
            /// </summary>
            public bool HasShuffler
            {
                get
                {
                    // initial value
                    bool hasShuffler = (this.Shuffler != null);
                    
                    // return value
                    return hasShuffler;
                }
            }
            #endregion
            
            #region Shuffler
            /// <summary>
            /// This property gets or sets the value for 'Shuffler'.
            /// </summary>
            public RandomShuffler Shuffler
            {
                get { return shuffler; }
                set { shuffler = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
