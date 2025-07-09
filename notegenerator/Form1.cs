using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace notegenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dateOfStudy.Format = DateTimePickerFormat.Custom;
            dateOfStudy.CustomFormat = "MM/dd/yyyy";

            DateTime DOS = dateOfStudy.Value.ToLocalTime();
            string room = roomCombo.Text;
            ptIdBox.Text = DOS.ToString("MMddyyyy") + "-" + room;

        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            string location = locationCombo.Text;
            DateTime DOS = dateOfStudy.Value.ToLocalTime();
            string ptName = ptNameTextBox.Text;
            string DOB = ptDOB.Value.ToLocalTime().ToString();
            string ordered = studyOrdered.SelectedItem?.ToString() ?? "Not selected";
            string performed = studyPerformed?.SelectedItem?.ToString() ?? "Not selected";
            string acq = AcquisitionNum.Text;
            string referring = refMDtxtBox.Text;
            string tech = sleepTech.Text;
            // frequency plus symptom for narrative
            // checkbox for sleep issues from pt form
            string papMode = string.Empty;
            string cpapMask = string.Empty;
            string startPressure = string.Empty;
            string endPressure = string.Empty;
            string baseline = $"{ptName} is in for a sleep study. During the study, the patient had";


            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UserInfo_OpenXml.docx");

            using (WordprocessingDocument wordDoc = WordprocessingDocument.Create(filePath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                {
                    MainDocumentPart mainpart = wordDoc.AddMainDocumentPart();
                    mainpart.Document = new Document();
                    Body body = new Body();

                    body.Append(
                        CreateParagraph($"Location: {location} ", bold: true, fontSize: "18"),
                        CreateParagraph($"Date of Study: {DOS}", bold: true, fontSize: "24"),
                        CreateParagraph($"Patient Name: {ptName}"),
                        CreateParagraph($"Date of Birth: {DOB}", bold: false, fontSize: "18"),
                        CreateParagraph($"Study Ordered: {ordered}", bold: true, fontSize: "18"),
                        CreateParagraph($"Study Performed: {performed}", bold: true, fontSize: "18"),
                        CreateParagraph($"Acquisition Num: {acq}", bold: true, fontSize: "18"),
                        CreateParagraph($"Reffering Md: {referring}", bold: true, fontSize: "18"),
                        CreateParagraph($"Sleep Tech: {tech}", bold: true, fontSize: "18")

                        );
                    mainpart.Document.Append(body);
                }
                MessageBox.Show("Word  Document created on Desktop", "Success");
            }
        }


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
    }
}
// if study performed == x, then fire off x event