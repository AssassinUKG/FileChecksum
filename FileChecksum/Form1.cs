using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileChecksum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region "vars"

        private FileInfo Fi_current;

        #endregion "vars"

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.AddRange(new ColumnHeader[] { new ColumnHeader() { Text = "Hash", Width = 60, Tag = 1 }, new ColumnHeader() { Text = "Result", Width = -2, Tag = 2 } });
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            Fi_current = new FileInfo(file[0]);
            // textBox1.Invoke(new MethodInvoker(() => { textBox1.Text = Fi_current.FullName; }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.Filter = "Exe's (*.exe)|*.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Fi_current = new FileInfo(ofd.FileName);
                    // textBox1.Invoke(new MethodInvoker(() => { textBox1.Text = Fi.FullName;  }));
                }
            }
        }

        private void GetHashs()
        {
            if (Fi_current != null)
            {
                listView1.Items.Clear();
                if (File.Exists(Fi_current.FullName))
                {
                    //compute hash on selections.
                    if (cb_Md5.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.MD5, Fi_current.FullName); });
                       
                        t.Start();
                    }
                    if (cb_SHA1.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.SHA1, Fi_current.FullName); });
                        t.Start();
                    }

                    if (cb_SHA256.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.SAH256, Fi_current.FullName); });
                        t.Start();
                    }

                    if (cb_SHA348.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.SHA384, Fi_current.FullName); });
                        t.Start();
                    }
                    if (cb_SHA512.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.SHA512, Fi_current.FullName); });
                        t.Start();
                    }

                    if (cb_BAS64.Checked)
                    {
                        Task t = new Task(async () => { await ShowResult(CryptoHash.Hashs.BASE64, Fi_current.FullName); });
                        t.Start();
                    }
                }
            }
        }

        private async Task ShowResult(CryptoHash.Hashs hash, string filename)
        {
            CryptoHash ch = new CryptoHash();
            string hashResult = await ch.ComputeHash(filename, hash);
            ListViewItem lvi = new ListViewItem(Enum.GetName(typeof(CryptoHash.Hashs), hash));
            lvi.SubItems.Add(hashResult.ToUpper());

            listView1?.Invoke(new MethodInvoker(() => { listView1.Items.Add(lvi); }));
           // listView1?.Invoke(new MethodInvoker(() => { Invoke.SizeChanged(this, new EventArgs()); }));
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem lvi = listView1.GetItemAt(e.X, e.Y);
                if (lvi != null)
                {
                    Clipboard.SetText(lvi.SubItems[1].Text);
                }
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.cbmd5 = cb_Md5.Checked;
            Properties.Settings.Default.cbsha1 = cb_SHA1.Checked;
            Properties.Settings.Default.cbsha256 = cb_SHA256.Checked;
            Properties.Settings.Default.cbsha348 = cb_SHA348.Checked;
            Properties.Settings.Default.cbsha512 = cb_SHA512.Checked;
            Properties.Settings.Default.cbbas64 = cb_BAS64.Checked;
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            cb_Md5.Checked = Properties.Settings.Default.cbmd5;
            cb_SHA1.Checked = Properties.Settings.Default.cbsha1;
            cb_SHA256.Checked = Properties.Settings.Default.cbsha256;
            cb_SHA348.Checked = Properties.Settings.Default.cbsha348;
            cb_SHA512.Checked = Properties.Settings.Default.cbsha512;
            cb_BAS64.Checked = Properties.Settings.Default.cbbas64;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);

            Fi_current = new FileInfo(file[0]);
            GetHashs();

            Text = String.Format("CheckSum: {0}", Fi_current.FullName);
            // textBox1.Invoke(new MethodInvoker(() => { Fi_current.FullName = Fi.FullName; }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void listView1_SizeChanged(object sender, EventArgs e)
        {
            //listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.)
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}