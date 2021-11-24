using System.IO.MemoryMappedFiles;
using System.Text;

namespace ChatFromMMF
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void startNewFormButton_Click(object sender, EventArgs e)
        {
            Program.StartNewProcess();
        }
       
        private void sendMessageInMMF(string message)
        {
            ManageMemoryMappedFile.WriteLine(message);

        }
        
        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            sendMessageInMMF($"{this.nicknameTextBox.Text}: {this.messageTextBox.Text}");
        }

        private void updateChatButton_Click(object sender, EventArgs e)
        {
            this.chatTextBox.Lines = ManageMemoryMappedFile.ReadToEnd().Split(new char[] {'\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries);
        }
    }
}