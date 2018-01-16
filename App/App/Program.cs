using App.Common;
using App.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        public static ConfiguracaoBE ConfigBE;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartApp();
        }

        private static void StartApp()
        {
            if (File.Exists(Constants.CONFIG_FILE_NAME))
            {
                LoadConfigurationFromXml();
            }
            else
            {
                CreateNewXmlConfiguration();
            }

            Application.Run(new View.frmMain());
        }

        private static void CreateNewXmlConfiguration()
        {
            ConfigBE = new ConfiguracaoBE();

            Serialize.SerializeToXmlUft8<ConfiguracaoBE>(Constants.CONFIG_FILE_NAME, ConfigBE);
        }

        private static void LoadConfigurationFromXml()
        {
            ConfigBE = new ConfiguracaoBE();

            ConfigBE = Serialize.DeserializeFromXmlUtf8<ConfiguracaoBE>(Constants.CONFIG_FILE_NAME);
        }
    }
}
