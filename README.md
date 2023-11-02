Just a thought: Sometimes when an attempted solution causes problems of its own, it's worth taking a moment to ask if this is the right approach in the first place. This is a concept known as an [X-Y Problem](https://meta.stackexchange.com/a/66378).

Having experienced this same kind of issue myself many times, I have settled on an way of doing a "timed update" that doesn't rely on a timer to make the time intervals, but uses a `Task.Delay` to do the same thing with less fuss and bother. This is an alternative approach you might try:

```
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
}
```
___

**Example**

This routine polls the controls on the left ~ once per second, and also updates the Title Bar text with the current time.

[![screenshot][1]][1]

```

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
```


  [1]: https://i.stack.imgur.com/DMcLD.png