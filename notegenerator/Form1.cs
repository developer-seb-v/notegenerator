using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.Sqlite;



namespace notegenerator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            LoadComboBoxData();

            DataAcess.InitializeDatabase();
            papPanel.Visible = false;
            dateOfStudy.Format = DateTimePickerFormat.Custom;
            dateOfStudy.CustomFormat = "MM/dd/yyyy";

            DateTime DOS = dateOfStudy.Value.ToLocalTime();
            string room = roomCombo.Text;
            ptIdBox.Text = DOS.ToString("MMddyyyy") + "-" + room;

        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generate Report button works", "Report Generation");
            DateTime DOS = dateOfStudy.Value.ToLocalTime();
            string location = locationCombo.Text;
            string ptName = ptNameTextBox.Text;
            string DOB = ptDOB.Value.ToLocalTime().ToString();
            string ordered = studyOrdered.SelectedItem?.ToString() ?? "Not selected";
            string performed = studyPerformed?.SelectedItem?.ToString() ?? "Not selected";
            string acq = AcqNumBox.Text;
            string referring = orderingMDComboBox.Text;
            string tech = techComboBox.Text;
            // frequency plus symptom for narrativew
            // checkbox for sleep issues from pt form
            string cpapMask = string.Empty;
            string startPressure = string.Empty;
            string endPressure = string.Empty;
            string comments = commentBox.Text;
            string baseline = $"{ptName} is in for a {ordered} study. {comments}";


            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UserInfo_OpenXml.docx");

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                {
                    MainDocumentPart mainpart = wordDoc.AddMainDocumentPart();
                    mainpart.Document = new Document();
                    Body body = new Body();

                    body.Append(
                        CreateParagraph($"Date of Study: {DOS}", bold: true, fontSize: "24"),
                        CreateParagraph($"Patient Name: {ptName}"),
                        CreateParagraph($"Date of Birth: {DOB}", bold: false, fontSize: "18"),
                        CreateParagraph($"Patient Id: {ptIdBox.Text}", bold: false, fontSize: "18"),
                        CreateParagraph($"Study Ordered: {ordered}", bold: false, fontSize: "18"),
                        CreateParagraph($"Study Performed: {performed}", bold: false, fontSize: "18"),
                        // CreateParagraph($"Mask Used: {maskComboBox.SelectedValue}", bold: false, fontSize: "18"),
                        // CreateParagraph($"Mask Size: {maskSizeBox.SelectedValue}", bold: false, fontSize: "18"),
                        CreateParagraph($"Acquisition Num: {acq}", bold: false, fontSize: "18"),
                        CreateParagraph($"Ordering MD: {referring}", bold: false, fontSize: "18"),
                        CreateParagraph($"Sleep Tech: {tech}", bold: false, fontSize: "18"),
                        CreateParagraph($"Location: {location} ", bold: false, fontSize: "18"),
                        CreateParagraph($"Height: {heightBox.Text} ", bold: false, fontSize: "18"),
                        CreateParagraph($"Weight: {weightBox.Text} ", bold: false, fontSize: "18"),
                        CreateParagraph($"Epworth: {epworthBox.Text} ", bold: false, fontSize: "18"),
                        CreateParagraph($"{Environment.NewLine} Summary: The patient is in for a {ordered}. {comments}")

                        );


                    mainpart.Document.Append(body);
                }
                MessageBox.Show("Word  Document created on Desktop", "Success");
            }
        }

        // TODO: create narratives for split night and titration studies
        // TODO: add logo to document
        // TODO: Use embedded Sqlite DB for data persistence?
        // TODO: Form validation
        // TODO: Get symptoms from patient paperwork
        // TODO: Add cardiac report fields
        // TODO: PLMs fields???
        // TODO: Pt medical history... medications?

        private Paragraph CreateParagraph(string text, bool bold = false, bool italic = false, string fontSize = "24", string spacingBefore = "120")
        {
            Run run = new Run();

            RunProperties runProps = new RunProperties();
            if (bold) runProps.Append(new Bold());
            if (italic) runProps.Append(new Italic());
            runProps.Append(new FontSize() { Val = fontSize });

            run.Append(runProps);
            run.Append(new Text(text));

            Paragraph paragraph = new Paragraph();
            ParagraphProperties pProps = new ParagraphProperties();
            pProps.SpacingBetweenLines = new SpacingBetweenLines() { Before = spacingBefore };
            paragraph.Append(pProps);
            paragraph.Append(run);

            return paragraph;
        }

        private void generateReportSplitBtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Split button works", "Split night study");
        }

        private void roomCombo_SelectedIndexChanged(object sender, EventArgs e)
        {


            ptIdBox.Text = dateOfStudy.Value.ToString("MMddyyyy") + "-" + roomCombo.Text;
        }

        private void dateOfStudy_ValueChanged(object sender, EventArgs e)
        {
            ptIdBox.Text = dateOfStudy.Value.ToString("MMddyyyy") + "-" + roomCombo.Text;
        }

        private void studyPerformed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (studyPerformed.SelectedItem?.ToString())
            {
                case "SPLIT":
                    generateReportBtn.Visible = false;
                    titrationBtn.Visible = false;
                    splitBtn.Visible = true;
                    papPanel.Visible = true;
                    break;
                case "TITRATION":
                    generateReportBtn.Visible = false;
                    titrationBtn.Visible = true;
                    splitBtn.Visible = false;
                    papPanel.Visible = true;
                    break;
                case "NPSG":
                    generateReportBtn.Visible = true;
                    titrationBtn.Visible = false;
                    splitBtn.Visible = false;
                    papPanel.Visible = false;
                    break;
            }
        }

        private void titrationBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titration button works", "Titration study");

        }

        private void splitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Split button works", "Split night study");
        }

        private void initalizeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAcess.InitializeDatabase();
        }

        private void addTechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTech addTech = new AddTech();
            addTech.ShowDialog();
        }
        private void LoadComboBoxData()
        {
            string connectionString = "Data Source=appdata.db"; // adjust path as needed

            using (var connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT name FROM techs";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            techComboBox.Items.Add(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void addMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMd addMd = new AddMd();
            addMd.ShowDialog();
        }

        private void LoadOrderingMds()
        {
            string connectionString = "Data Source=appdata.db"; // adjust path as needed
            using (var connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT name FROM ordering_mds";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(0);
                            orderingMDComboBox.Items.Add(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            if (weightBox.Text.Length == 0 || heightBox.Text.Length == 0)
            {
                bmiBox.Text = "0.00"; // Reset BMI if either field is empty
                return;
            }
            float height = heightBox.Text.Length > 0 ? float.Parse(heightBox.Text) : 0;
            float weight = weightBox.Text.Length > 0 ? float.Parse(weightBox.Text) : 0;
            float bmi = (weight / (height * height)) * 703; // BMI formula
            bmiBox.Text = bmi.ToString("F2"); // Display BMI with 2 decimal places
        }

        private void weightBox_TextChanged(object sender, EventArgs e)
        {
            if (weightBox.Text.Length == 0 || heightBox.Text.Length == 0)
            {
                bmiBox.Text = "0.00"; // Reset BMI if either field is empty
                return;
            }

            float height = heightBox.Text.Length > 0 ? float.Parse(heightBox.Text) : 0;
            float weight = weightBox.Text.Length > 0 ? float.Parse(weightBox.Text) : 0;
            float bmi = (weight / (height * height)) * 703; // BMI formula
            bmiBox.Text = bmi.ToString("F2"); // Display BMI with 2 decimal places

        }
    }
}
// if study performed == x, then fire off x event