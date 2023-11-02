using System.Runtime.CompilerServices;

namespace pick_note_time_interval
{
public partial class MainForm : Form
{
    public MainForm() => InitializeComponent();
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        numericUpDown.ValueChanged += (sender, e) => 
        { 
            textBoxTitle.Clear();
            textBoxText.Clear(); 
        };
        _ = execTimerLoop();
    }

    private async Task execTimerLoop()
    {
        Cancel = new CancellationTokenSource();
        do
        {
            // Update title bar ~ every second or so
            Text = DateTime.Now.ToString(@"hh\:mm\:ss tt");

            getPickNoteDetails();
            await Task.Delay(TimeSpan.FromSeconds(1));
        } while (!Cancel.IsCancellationRequested);
    }

    CancellationTokenSource? Cancel { get; set; }
    .
    .
    .
    private void getPickNoteDetails()
    {
        var selectionFontB4 = richTextBox.Font;
        var selectionColorB4 = richTextBox.SelectionColor;
        richTextBox.Clear();

        richTextBox.SelectionFont = new Font(selectionFontB4.FontFamily, 14F, FontStyle.Bold);
        richTextBox.SelectionColor = Color.FromArgb(0x22, 0x22, 0x22);
        richTextBox.AppendText($"{numericUpDown.Value}");

        if(!string.IsNullOrWhiteSpace(textBoxTitle.Text) ) 
        {
            richTextBox.SelectionFont = new Font(selectionFontB4.FontFamily, 12F, FontStyle.Bold);
            richTextBox.SelectionColor = Color.CadetBlue;
            richTextBox.AppendText($" : {textBoxTitle.Text.ToUpper()}");
            richTextBox.AppendText(Environment.NewLine);
        }

        richTextBox.SelectionFont = selectionFontB4;
        richTextBox.SelectionColor = selectionColorB4;
        richTextBox.AppendText($"{textBoxText.Text}");
        richTextBox.AppendText(Environment.NewLine);
    }
}
}