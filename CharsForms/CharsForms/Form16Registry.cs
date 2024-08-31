using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharsForms
{
    public partial class Form16Registry : Form
    {
        public Form16Registry()
        {
            InitializeComponent();
        }

        private void Form16Registry_Load(object sender, EventArgs e)
        {
            //Registry Class cannot be instantiated
            //Registry is used to create a instance of RegistryKey
            //The instance of Registry represent a windows registry item.
            //User can check, create, read or edit key values

            RegistryKey registryKey = Registry.LocalMachine;
            RegistryKey systemKey = registryKey.OpenSubKey(@"SOFTWARE");
            foreach (string systemKeyName in systemKey.GetSubKeyNames())
            {
                rtbRegistry.Text += systemKeyName + "\n";

                // registryLb.Items.Add("Item name: "+ systemKeyName);
                RegistryKey subKey = systemKey.OpenSubKey(systemKeyName);
                foreach (string subkeyName in subKey.GetValueNames())
                    rtbRegistry.Text += subkeyName + ": " + subKey.GetValue(subkeyName) + "\n";
                // registryLb.Items.Add(subkeyName + subKey.GetValue(subkeyName));
            }

        }

        //Run 'Z:\CSharpRepos\CharsForms\CharsForms\bin\Debug\net8.0-windows7.0\CharsForms.exe' as administrator
        //Check the result in Resitry Editor/HKEY_LOCAL_MACHINE/HARDWARE
        private void createSubKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey machineSettings = Registry.LocalMachine;
                RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
                RegistryKey zwtSubKey = hardwareSubKey.CreateSubKey("zwt");
                RegistryKey zwt1SubKey = zwtSubKey.CreateSubKey("zwt1");
                zwt1SubKey.SetValue("value", "zwt1Value");
                MessageBox.Show("zwt subkey created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void hardwareSubKeyBtn_Click(object sender, EventArgs e)
        {
            RegistryKey machineSettings = Registry.LocalMachine;
            RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
            foreach (string keyName in hardwareSubKey.GetSubKeyNames())
            {
                rtbUpdateSubKey.Text += keyName + "\n";
            }
        }

        private void editSubKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey machineSettings = Registry.LocalMachine;
                RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
                RegistryKey zwtSubKey = hardwareSubKey.OpenSubKey("zwt", true);
                RegistryKey zwt1SubKey = zwtSubKey.OpenSubKey("zwt1", true);
                zwt1SubKey.SetValue("value", "zwt1Value1");
                MessageBox.Show("zwt subkey edited");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteSubKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey machineSettings = Registry.LocalMachine;
                RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
                RegistryKey zwtSubKey = hardwareSubKey.OpenSubKey("zwt", true);
                zwtSubKey.DeleteSubKey("zwt1");
                MessageBox.Show("zwt1 subkey deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteSubKeyTree_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey machineSettings = Registry.LocalMachine;
                RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
                hardwareSubKey.DeleteSubKeyTree("zwt");
                //RegistryKey zwtSubKey = hardwareSubKey.OpenSubKey("zwt", true);
                //zwtSubKey.DeleteSubKeyTree("zwt1");
                MessageBox.Show("zwt subkey tree deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void deleteSubKeyValue_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey machineSettings = Registry.LocalMachine;
                RegistryKey hardwareSubKey = machineSettings.OpenSubKey(@"HARDWARE", true);
                RegistryKey zwtSubKey = hardwareSubKey.OpenSubKey("zwt", true);
                RegistryKey zwt1SubKey = zwtSubKey.OpenSubKey("zwt1", true);
                zwt1SubKey.DeleteValue("value");
                MessageBox.Show("zwt1 subkey value deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Registry TreeView
        public static string userRoot = string.Empty;
        public static string subKey = string.Empty;
        public static string strProperty = string.Empty;
        public static string str = string.Empty;
        public static string strReader = string.Empty;
        public RegistryKey rKey;
        public string HKEY_CLASSES_ROOT = "HKEY_CLASSES_ROOT";
        public string HKEY_CURRENT_USER = "HKEY_CURRENT_USER";
        public string HKEY_LOCAL_MACHINE = "HKEY_LOCAL_MACHINE";
        public string HKEY_USERS = "HKEY_USERS";
        public string HKEY_CURRENT_CONFIG = "HKEY_CURRENT_CONFIG";


        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void createKeyBtn_Click(object sender, EventArgs e)
        {
            string keyName = propertyLabel.Text.Trim().ToString() + "\\" + itemNameTb.Text.Trim().ToString();
            object obj = nodeItemTb.Text.Trim();
            string strName = nodeValueTb.Text.Trim();
            if (strReader != string.Empty)
            {
                switch (strReader)
                {
                    case "string":
                        {
                            Registry.SetValue(keyName, strName, obj, RegistryValueKind.String);
                            break;
                        }

                    case "ExpandString":
                        {
                            Registry.SetValue(keyName, strName, obj, RegistryValueKind.ExpandString);
                            break;
                        }
                }
                MessageBox.Show("Node Created!");
                refresh();
            }
            else
            {
                MessageBox.Show("Choose create type: chars or extended");
            }
        }

        private void displayConfigItemBtn_Click(object sender, EventArgs e)
        {
            string str = propertyLabel.Text.Trim().ToString();
            string defaultResult = "";
            if (str.IndexOf("\\") != -1)
            {
                defaultResult = str.Substring(0, str.IndexOf("\\"));
                str = str.Substring(str.IndexOf("\\") + 1);

            }

            else
            {
                defaultResult = str;
            }

            switch (defaultResult)
            {
                case "HKEY_CLASSES_ROOT":
                    {
                        rKey = Registry.ClassesRoot;
                        break;
                    }
                case "HKEY_CURRENT_USER":
                    {
                        rKey = Registry.CurrentUser;
                        break;
                    }
                case "HKEY_LOCAL_MACHINE":
                    {
                        rKey = Registry.LocalMachine;
                        break;
                    }
                case "HKEY_USERS":
                    {
                        rKey = Registry.Users;
                        break;
                    }
                case "HKEY_CURRENT_CONFIG":
                    {
                        rKey = Registry.CurrentConfig;
                        break;
                    }

            }

            try
            {
                RegistryKey registryKeys = rKey.OpenSubKey(str);
                if (registryKeys.ValueCount > 0)
                {
                    foreach (string strValue in registryKeys.GetValueNames())
                    {
                        MessageBox.Show("The value of " + strValue + " is " + registryKeys.GetValue(strValue).ToString());
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("No value");
                }

            }
            catch
            {
                MessageBox.Show("No value");
            }
        }


        private void createConfigItemBtn_Click(object sender, EventArgs e)
        {
            RegistryKey registryKey = Registry.CurrentConfig.CreateSubKey(itemNameTb.Text.Trim().ToString());
            MessageBox.Show("Created!");
            refresh();
        }

        private void deleteConfigItemBtn_Click(object sender, EventArgs e)
        {
            string node = propertyLabel.Text.Trim().ToString();
            string childnNode = node.Substring(node.IndexOf("\\") + 1);

            if (MessageBox.Show("Delete the node?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Registry.CurrentConfig.DeleteSubKeyTree(childnNode);
                refresh();
                MessageBox.Show(childnNode + " is removed");
            }

        }

        private void extendedCharsRb_CheckedChanged(object sender, EventArgs e)
        {
            if (extendedCharsRb.Checked)
                strReader = "ExpandString";
        }

        private void charsRb_CheckedChanged(object sender, EventArgs e)
        {
            if (charsRb.Checked)
                strReader = "string";
        }

        private void refresh()
        {
            treeViewRegistry.Nodes.Clear();
            RegistryKey rkRoot = Registry.ClassesRoot;
            RegistryKey rkLocalUser = Registry.CurrentUser;
            RegistryKey rkMachine = Registry.LocalMachine;
            RegistryKey rkUsers = Registry.Users;
            RegistryKey rkConfig = Registry.CurrentConfig;

            TreeNode root = new TreeNode(HKEY_CLASSES_ROOT);
            foreach (string subKeyName in rkRoot.GetSubKeyNames())
                root.Nodes.Add(subKeyName.ToString());

            TreeNode localUser = new TreeNode(HKEY_CURRENT_USER);
            foreach (string subKeyName in rkLocalUser.GetSubKeyNames())
                localUser.Nodes.Add(subKeyName.ToString());

            TreeNode machine = new TreeNode(HKEY_LOCAL_MACHINE);
            foreach (string subKeyName in rkMachine.GetSubKeyNames())
                machine.Nodes.Add(subKeyName.ToString());

            TreeNode users = new TreeNode(HKEY_USERS);
            foreach (string subKeyName in rkUsers.GetSubKeyNames())
                users.Nodes.Add(subKeyName.ToString());

            TreeNode config = new TreeNode(HKEY_CURRENT_CONFIG);
            foreach (string subKeyName in rkConfig.GetSubKeyNames())
                config.Nodes.Add(subKeyName.ToString());

            treeViewRegistry.Nodes.Add(root);
            treeViewRegistry.Nodes.Add(localUser);
            treeViewRegistry.Nodes.Add(machine);
            treeViewRegistry.Nodes.Add(users);
            treeViewRegistry.Nodes.Add(config);
        }

        private void treeViewRegistry_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                strProperty = treeViewRegistry.SelectedNode.Parent.Text;
            }
            catch
            {
                strProperty = string.Empty;
            }

            str = e.Node.Text;
            if (strProperty != string.Empty)
                propertyLabel.Text = strProperty + "\\" + str;
            else
                propertyLabel.Text = str;
        }

        private void tryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 trialCount = (Int32)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ZwtSoftware", "TrialCount", 0);
                if (trialCount < 10)
                {
                    int count = trialCount + 1;
                    Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ZwtSoftware", "TrialCount", count);
                    MessageBox.Show("Count: " + count);
                }
                else
                {
                    MessageBox.Show("Trial is end");
                    Application.Exit();
                }
            }
            catch
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\ZwtSoftware", "TrialCount", 1, RegistryValueKind.DWord);
                MessageBox.Show("Welcome! This is your first time.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    RegistryKey rgK = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                    rgK.SetValue("HungAppTimeout", 700);
                    rgK.SetValue("WaitToKillAppTimeout", 1000);

                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control", "HungAppTimeout", 400);
                    Registry.SetValue(@"HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control", "WaitToKillServiceTimeout", 1000);
                    MessageBox.Show("Update, please restart your computer");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!");
                }
            }
            catch 
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rgK = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Update");
                rgK.SetValue("UpdateMode", 0);
                MessageBox.Show("Update, please restart your computer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey rgK = Registry.CurrentUser.CreateSubKey(@"Control Panel\Desktop");
                rgK.SetValue("MenuShowDelay", 0);
                MessageBox.Show("Update, please restart your computer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
