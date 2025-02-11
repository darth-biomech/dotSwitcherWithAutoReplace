using System.Windows.Forms;
using dotSwitcher.Data;

public partial class ReplacementEntryControl : UserControl
{
    public TextBox TextBoxReplace { get; private set; }
    public TextBox TextBoxTarget { get; private set; }
    public CheckBox CheckBoxIgnoreCase { get; private set; }

    public ReplacementEntryControl()
    {
        InitializeComponent();
    }

    public ReplacementEntryControl(ReplacementEntry entry)
    {
        InitializeComponent();
        SetData(entry);
    }

    
    private void InitializeComponent()
    {
        TextBoxReplace = new TextBox();
        TextBoxTarget = new TextBox();
        CheckBoxIgnoreCase = new CheckBox();
        Label labelReplace = new Label();
        Label labelTarget = new Label();
        Label labelIgnoreCase = new Label();

        int height = 16;
        
        int vertOffset = 3;
        int spacing = 1;
        
        labelReplace.Text = "Replace:";
        labelReplace.Location = new System.Drawing.Point(0, vertOffset);
        labelReplace.Size = new System.Drawing.Size(50, height);

        TextBoxReplace.Location = new System.Drawing.Point(labelReplace.Right + spacing, 0);
        TextBoxReplace.Size = new System.Drawing.Size(50, height);

        labelTarget.Text = "With:";
        labelTarget.Location = new System.Drawing.Point(TextBoxReplace.Right + spacing, vertOffset);
        labelTarget.Size = new System.Drawing.Size(30, height);

        TextBoxTarget.Location = new System.Drawing.Point(labelTarget.Right + spacing, 0);
        TextBoxTarget.Size = new System.Drawing.Size(50, height);

        labelIgnoreCase.Text = "Ignore Case:";
        labelIgnoreCase.Location = new System.Drawing.Point(TextBoxTarget.Right + spacing, vertOffset);
        labelIgnoreCase.Size = new System.Drawing.Size(70, height);

        CheckBoxIgnoreCase.Location = new System.Drawing.Point(labelIgnoreCase.Right + spacing, 0);
        CheckBoxIgnoreCase.Size = new System.Drawing.Size(height, height);

        Controls.Add(labelReplace);
        Controls.Add(TextBoxReplace);
        Controls.Add(labelTarget);
        Controls.Add(TextBoxTarget);
        Controls.Add(labelIgnoreCase);
        Controls.Add(CheckBoxIgnoreCase);

        Size = new System.Drawing.Size(CheckBoxIgnoreCase.Right, height+ (vertOffset * 2));
    }

    public void SetData(ReplacementEntry entry)
    {
        TextBoxReplace.Text = entry.source;
        TextBoxTarget.Text = entry.target;
        CheckBoxIgnoreCase.Checked = entry.ignoreCase;
    }
    public ReplacementEntry GetData()
    {
        ReplacementEntry result = new ReplacementEntry();
        result.source = TextBoxReplace.Text;
        result.target = TextBoxTarget.Text;
        result.ignoreCase = CheckBoxIgnoreCase.Checked;
        return result;
    }
}